using Newtonsoft.Json;
using System.Collections.Generic;

namespace Data
{
    public class Table
    {
        #region Public Constructors

        public Table()
        {
            this.Fields = new List<TableField>();
            this.Relations = new List<TableRelation>();
        }

        #endregion Public Constructors

        #region Public Properties



        public string Name { get; set; }
        public bool IsOriginal { get; set; }

        [JsonIgnore]
        public virtual IList<TableRelation> Relations { get; set; }
        [JsonIgnore]
        
        public virtual IList<TableField> Fields { get; set; }

        

        #endregion Public Properties
    }
}