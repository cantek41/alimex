namespace Data
{
    public enum TableRelationType
    {
        OneToOne = 0,

        OneToMany = 1,
    }

    public class TableRelation
    {
        #region Public Properties

        public string ForeignKey { get; set; }

        public int Id { get; set; }

        public bool Protected { get; set; }

        public int RelatedTableId { get; set; }

        public TableRelationType RelationType { get; set; }

        public virtual Table Table { get; set; }

        public int TableId { get; set; }

        public string Version { get; set; }

        public string Description { get; set; }

        #endregion Public Properties
    }
}