using Newtonsoft.Json;
namespace Data
{
   
    public class TableField
    {
        #region Public Properties

        public string Name { get; set; }

        public string FieldType { get; set; }

        public int Id { get; set; }

        public bool IsIdentity { get; set; }

        public bool IsNullable { get; set; }

        public bool IsUnique { get; set; }

        public int Length { get; set; }


        public bool IsOriginal { get; set; }

        public int Scale { get; set; }

        public string StringBehaviour { get; set; }

        [JsonIgnore]
        public virtual Table Table { get; set; }
        #endregion Public Properties
    }
}