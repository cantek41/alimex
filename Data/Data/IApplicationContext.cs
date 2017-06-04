using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using Telerik.OpenAccess;
using Telerik.OpenAccess.Metadata;

namespace Data
{
    public interface IApplicationContext
    {
        IContextEvents Events { get; }

        MetadataContainer Metadata { get; }     

        OpenAccessContext getContext();

        string getPreinstanceName();     
        
        void UpdateSchema();
    }
}