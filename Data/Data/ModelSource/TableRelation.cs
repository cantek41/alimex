namespace Data
{
    public enum TableRelationType
    {
        OneToOne, 
        OneToMany
    }

    public class TableRelation
    {
        #region Public Properties

        public string ForeignKey { get; set; }

        public string RelatedTable { get; set; }

        public TableRelationType RelationType { get; set; }     


        #endregion Public Properties
    }
}