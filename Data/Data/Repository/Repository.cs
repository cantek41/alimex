using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using Telerik.OpenAccess;

namespace Data
{
    public class DataAccessRepository : IRepository
    {
        #region Private Fields

        private readonly IApplicationContext _context;
        public IList<Table> _tables;

        #endregion Private Fields

        #region Public Constructors

        public DataAccessRepository(IApplicationContext context)
        {
            _context = context;
            _tables = new ModelSource().getSource();
        }

        #endregion Public Constructors

        #region Public Methods

        public bool Delete(string tableName, string Id)
        {
            checkParameters(tableName);
            checkParameters(Id);
            var data = getById(tableName, Id);
            if (data == null)
                throw new Exception("Not Found Exception");
            data.SetFieldValue("IsDelete", true);
            _context.getContext().SaveChanges();
            return true;
        }

        public IQueryable getAll(string tableName)
        {
            return _context
               .getContext()
               .GetAll(
               preperToTableName(tableName));
        }

        public object getById(string tableName, string id)
        {
            checkParameters(tableName);
            checkParameters(id);

            var Id = Guid.Parse(id);
            return _context
                .getContext()
                .GetAll(preperToTableName(tableName))
                .Cast<object>()
                .Where(q => q.FieldValue<Guid>("Id") == Id)
                .FirstOrDefault();
        }

        public object Insert(string tableName, Dictionary<string, string> entity)
        {
            checkParameters(tableName);
            checkParameters(entity);

            var data = _context.getContext().CreateInstance(preperToTableName(tableName));
            _context.getContext().Add(data);
            data.SetFieldValue("Id", Guid.NewGuid());
            setFields(tableName, entity, data);
            _context.getContext().SaveChanges();
            return data;
        }

        public object Update(string tableName, Dictionary<string, string> entity)
        {
            checkParameters(tableName);
            checkParameters(entity);
            var data = getById(tableName, entity["Id"]);
            if (data == null)
                throw new Exception("Not Found Exception");
            setFields(tableName,entity, data);
            _context.getContext().SaveChanges();
            return data;
        }

        public int Count(string tableName)
        {
            return getAll(tableName).Cast<object>().Count();
        }

        public JArray ExecuteSqlQueryJson(string sql)
        {
            var result = new JArray();
            using (IDbConnection oaConnection = _context.getContext().Connection)
            {
                using (IDbCommand oaCommand = oaConnection.CreateCommand())
                {
                    oaCommand.CommandText = sql;
                    using (IDataReader reader = oaCommand.ExecuteReader())
                    {
                        JObject row;
                        while (reader.Read())
                        {
                            row = new JObject();
                            for (int i = 0; i < reader.FieldCount; i++)
                            {
                                row.Add(reader.GetName(i), new JValue(reader.GetValue(i) ?? JValue.CreateNull()));
                            }
                            result.Add(row);
                        }                     
                    }
                }
            }
            return result;
        }

        public bool UpdateDb(IList<Table> table)
        {
            _tables = table;
            new ModelSource().setSource(_tables);
            _context.UpdateSchema();
            return true;
        }
        public IList<Table> getTables()
        {
            return _tables;
        }
        #endregion Public Methods

        #region Private Methods

        private void checkParameters(object param)
        {
            if (param == null)
            {
                throw new ArgumentNullException();
            }
        }

        private string preperToTableName(string tableName)
        {
            return String.Concat(_context.getPreinstanceName(), ".", tableName);
        }

        private void setFields(string tableName, Dictionary<string, string> entity, object data)
        {
         
            foreach (var field in entity.Keys.Where(x => x != "Id"))
            {
                if (entity[field] == null) continue;
                data.SetFieldValue(field,ConvertToAdoType(tableName, field,entity[field]));
            }
        }

        private object ConvertToAdoType(string tableName, string fieldName, string value)
        {
            var field = _tables.Where(q => q.Name == tableName).First().Fields.Where(q => q.Name == fieldName).First();         
            switch (field.FieldType)
            {
                case FieldType.String:
                    return value;

                case FieldType.Int32:
                    if (String.IsNullOrWhiteSpace(value)) return 0;
                    return Int32.Parse(value, System.Globalization.CultureInfo.CurrentCulture);

                case FieldType.Decimal:
                    if (String.IsNullOrWhiteSpace(value)) return 0;
                    return Decimal.Parse(value, System.Globalization.CultureInfo.CurrentCulture);

                case FieldType.Boolean:
                    if (String.IsNullOrWhiteSpace(value)) return false;
                    return Boolean.Parse(value);

                case FieldType.DateTime:
                    if (value == "/Date(-62135596800000)/") //null tarih 1/1/1970
                    {
                        if (field.IsNullable) return null;
                        return DateTime.Now;
                    }
                   // if (value.StartsWith("/Date")) return ConvertJavaTimeToSystemTime(value);
                    return DateTime.Parse(value, System.Globalization.CultureInfo.CurrentCulture);

                case FieldType.Time:
                    if (value == "/Date(-62135596800000)/") //null tarih 1/1/1970
                    {
                        if (field.IsNullable) return null;
                        return DateTime.Now;
                    }
                 //   if (value.StartsWith("/Date")) return ConvertJavaTimeToSystemTime(value);
                    return DateTime.Parse(value, System.Globalization.CultureInfo.CurrentCulture);

                case FieldType.Guid:
                    if (String.IsNullOrWhiteSpace(value))
                    {
                        if (field.IsNullable) return Guid.Empty;
                        return Guid.NewGuid();
                    }
                    return Guid.Parse(value);
            }
            return null;
        }


        #endregion Private Methods
        
    }
}