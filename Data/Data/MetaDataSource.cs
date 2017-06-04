using System;
using System.Collections.Generic;
using System.Linq;
using Telerik.OpenAccess;
using Telerik.OpenAccess.Metadata;
using Telerik.OpenAccess.Metadata.Fluent;
using Telerik.OpenAccess.Metadata.Fluent.Artificial;

namespace Data
{
    public static class MetaDataSourceExtension
    {
        #region Public Methods

        /// <summary>
        /// Dinamik alan için geçerli database veri türünü döndürür
        /// </summary>
        /// <param name="fieldType"></param>
        /// <param name="length"></param>
        /// <returns></returns>
        public static string GetArtificialColumnType(FieldType fieldType, int length)
        {
            switch (fieldType)
            {
                case FieldType.Boolean:
                    return "tinyint";

                case FieldType.DateTime:
                    return "datetime2";

                case FieldType.Decimal:
                    return "decimal";

                case FieldType.Int32:
                    return "int";

                case FieldType.String:
                    if (length < 0)
                        return "nvarchar(MAX)";
                    break;

                case FieldType.Time:
                    return "time";

                case FieldType.Guid:
                    return "uniqueidentifier";
            }
            return "nvarchar";
        }

        /// <summary>
        /// Dinamik alan için geçerli system tipini döndürür
        /// </summary>
        /// <param name="type"></param>
        /// <param name="isNullable"></param>
        /// <returns></returns>
        public static Type GetArtificialFieldType(this FieldType type, bool isNullable)
        {
            switch (type)
            {
                case FieldType.Boolean:
                    if (isNullable) return typeof(bool?);
                    return typeof(bool);

                case FieldType.DateTime:
                case FieldType.Time:
                    if (isNullable) return typeof(DateTime?);
                    return typeof(DateTime);

                case FieldType.Decimal:
                    if (isNullable) return typeof(decimal?);
                    return typeof(decimal);

                case FieldType.Int32:
                    if (isNullable) return typeof(int?);
                    return typeof(int);
            }
            return typeof(string);
        }

        public static PrimitivePropertyConfiguration SetArtificialFieldProperties(this PrimitivePropertyConfiguration primitivePropertyConfiguration, TableField field)
        {
            primitivePropertyConfiguration.HasColumnType(GetArtificialColumnType(field.FieldType, field.Length));

            if (field.IsIdentity)
                primitivePropertyConfiguration.IsIdentity(KeyGenerator.Autoinc);
            else
            {
                if (field.Length > 0)
                    primitivePropertyConfiguration.HasPrecision(field.Length);
                if (field.Scale > 0)
                    primitivePropertyConfiguration.HasScale(field.Scale);
                if (field.IsNullable)
                    primitivePropertyConfiguration.IsNullable();
                else
                    primitivePropertyConfiguration.IsNotNullable();
            }
            return primitivePropertyConfiguration;
        }

        public static MappingConfiguration SetArtificialFields(this Telerik.OpenAccess.Metadata.Fluent.MappingConfiguration configuration, IList<TableField> fields)
        {
            foreach (var field in fields)
            {
                configuration.HasArtificialPrimitiveProperty(field.Name, field.FieldType.GetArtificialFieldType(field.IsNullable)).SetArtificialFieldProperties(field);//.HasFieldName(field.Name);
                //Unique alanlarý tanýmla
                if (field.IsUnique)
                {
                    configuration
                        .HasIndex()
                        .IsUnique()
                        .WithName("IX_" + field.Table.Name + "_" + field.Name)
                        .WithMember(field.Name);
                }
            }
            return configuration;
        }

        #endregion Public Methods
    }

    public class MetaDataSource : FluentMetadataSource
    {
        #region Public Fields

        public static readonly string PERSISTENT_TYPE_PREFIX = "FluentModel";

        #endregion Public Fields

        #region Protected Methods

        protected override IList<MappingConfiguration> PrepareMapping()
        {
            List<MappingConfiguration> configurations = new List<MappingConfiguration>();
            Dictionary<string, MappingConfiguration> tableProp = new Dictionary<string, MappingConfiguration>();
            MappingConfiguration propConfiguration;
            IList<Table> tables=null;
            try
            {
                tables = new ModelSource().getSource();
            }
            catch (Exception ex)
            {
                //TODO:Loglama yap

            }
            if (tables==null)
            return configurations;
           
            foreach (var table in tables)
            {
                propConfiguration = new MappingConfiguration(table.Name, PERSISTENT_TYPE_PREFIX);
                propConfiguration.FieldNamingRules.CaseMode = CaseChangeModes.Unchanged;
                propConfiguration.MapType().WithConcurencyControl(OptimisticConcurrencyControlStrategy.None)
                  .ToTable(table.Name);
                propConfiguration.HasArtificialPrimitiveProperty<Guid>("Id").IsIdentity();
                table.Fields.ToList().ForEach(x => x.Table = table);
                propConfiguration.SetArtificialFields(table.Fields);
                tableProp.Add(table.Name, propConfiguration);
            }
            tableProp = setAssociation(tables, tableProp);
            foreach (KeyValuePair<string, MappingConfiguration> configuration in tableProp)
            {
                configurations.Add(configuration.Value);
            }

            return configurations;
        }

        protected override void SetContainerSettings(MetadataContainer container)
        {
            container.NameGenerator.RemoveCamelCase = false;

            container.NameGenerator.ResolveReservedWords = false;

            container.NameGenerator.SourceStrategy = Telerik.OpenAccess.Metadata.NamingSourceStrategy.Property;
        }

        #endregion Protected Methods

        #region Private Methods

        private Dictionary<string, MappingConfiguration> setAssociation(IList<Table> tables, Dictionary<string, MappingConfiguration> propConfiguration)
        {
            foreach (var sourceTable in tables.Where(x => x.Relations.Count > 0))
            {
                var relation = sourceTable.Relations.First();
                switch (relation.RelationType)
                {
                    case TableRelationType.OneToOne:

                        //propConfiguration[sourceTable.Name].
                        //   HasArtificialCollectionAssociation(relation.RelatedTable, propConfiguration[relation.RelatedTable].ConfiguredType).
                        //   WithOppositeCollection(sourceTable.Name);

                        //propConfiguration[relation.RelatedTable]
                        //    .HasArtificialCollectionAssociation(sourceTable.Name, propConfiguration[relation.RelatedTable].ConfiguredType)
                        //    .WithOpposite(relation.RelatedTable);

                        break;

                    case TableRelationType.OneToMany:
                        //bire
                        //    propConfiguration[sourceTable.Name]
                        //        .HasArtificialAssociation(relation.RelatedTable, propConfiguration[relation.RelatedTable].ConfiguredType)
                        //        .WithOpposite(sourceTable.Name)
                        //        .ToColumn(relation.ForeignKey); ;

                        ////çok
                        //    propConfiguration[relation.RelatedTable]
                        //       .HasArtificialCollectionAssociation(sourceTable.Name, propConfiguration[relation.RelatedTable].ConfiguredType)
                        //       .WithOpposite(relation.RelatedTable);
                        break;

                    default:
                        break;
                }
            }
            return propConfiguration;
        }

        #endregion Private Methods
    }
}