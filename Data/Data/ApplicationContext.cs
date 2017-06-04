using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Dynamic;
using System.Linq;
using System.Linq.Dynamic;
using Telerik.OpenAccess;
using Telerik.OpenAccess.Metadata;

namespace Data
{
    public class ApplicationContext : IApplicationContext, IDisposable
    {
        #region Private Fields

        private string _connectionString;
        private OpenAccessContext _context;


        #endregion Private Fields

        #region Public Constructors

        public ApplicationContext(string connectionString)
        {
            _connectionString = connectionString;
            _context = new OpenAccessContext(_connectionString, 
                getPreinstanceName(), GetBackendConfiguration(),
                new MetaDataSource().GetModel());
        }

        public string getPreinstanceName()
        {
            return MetaDataSource.PERSISTENT_TYPE_PREFIX;
        }

        
        private BackendConfiguration GetBackendConfiguration()
        {
            BackendConfiguration backend = new BackendConfiguration();

            backend.Backend = "MsSql";

            backend.ProviderName = "System.Data.SqlClient";

            return backend;
        }

        public void UpdateSchema()
        {
            OpenAccessContextBase.ReplaceMetadata(_context, new MetaDataSource().GetModel(), null);
            _context = new OpenAccessContext(_connectionString,
              getPreinstanceName(), GetBackendConfiguration(),
              new MetaDataSource().GetModel());
            var handler = this._context.GetSchemaHandler();
            string script = null;

            try
            {
                script = handler.CreateUpdateDDLScript(null);
            }
            catch
            {
                bool throwException = false;

                try
                {
                    handler.CreateDatabase();

                    script = handler.CreateDDLScript();
                }
                catch
                {
                    throwException = true;
                }

                if (throwException)
                {
                    throw;
                }
            }
            if (string.IsNullOrEmpty(script) == false)
            {
                handler.ForceExecuteDDLScript(script);
            }
        }
        #endregion Public Constructors


        public IContextEvents Events
        {
            get { return _context.Events; }
        }

        public MetadataContainer Metadata
        {
            get
            {
                return _context.Metadata;
            }
        }

        public OpenAccessContext getContext()
        {
            return _context;
        }              

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        protected virtual void Dispose(bool disposing)
        {
            if (_context == null)
            {
                return;
            }
            _context.Dispose();

        }

    }

}