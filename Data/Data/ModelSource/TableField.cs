using Newtonsoft.Json;
namespace Data
{
    public enum FieldStringBehaviour
    {       
        None = 0,
        ToLowerCase = 1,
        ToUpperCase = 2,
        ToTitleCase = 3
    }

    public enum FieldType
    {
        String = 0,
        Int32 = 1,
        Decimal = 2,
        Boolean = 3,
        DateTime = 4,
        Time = 5,
        Guid = 6,
        Single = 7, 
    }

    public class TableField
    {
        #region Public Properties

        public string Name { get; set; }

        public FieldType FieldType { get; set; }

        public int Id { get; set; }

        public bool IsIdentity { get; set; }

        public bool IsNullable { get; set; }

        public bool IsUnique { get; set; }

        public int Length { get; set; }


        public bool IsOriginal { get; set; }

        public int Scale { get; set; }

        public FieldStringBehaviour StringBehaviour { get; set; }

       
        public virtual Table Table { get; set; }
        #endregion Public Properties
    }
}