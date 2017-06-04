using System;
using System.Collections.Generic;
using Telerik.OpenAccess.Metadata;
using Telerik.OpenAccess.Metadata.Fluent;
using Telerik.OpenAccess.Metadata.Fluent.Artificial;

namespace ClassLibrary1
{
    public class ClassLibrary1MetadataSource : FluentMetadataSource
    {
        protected override IList<MappingConfiguration> PrepareMapping()
        {
            List<MappingConfiguration> configurations = new List<MappingConfiguration>();

            MappingConfiguration productConfiguration = new MappingConfiguration("Product", "FluentModel");
            productConfiguration.HasArtificialPrimitiveProperty<int>("Id").IsIdentity();

            MappingConfiguration categoryConfiguration = new MappingConfiguration("Category", "FluentModel");
            categoryConfiguration.HasArtificialPrimitiveProperty<int>("Id").IsIdentity();

         
                        
            configurations.Add(productConfiguration);
            configurations.Add(categoryConfiguration);

            return configurations;
        }
    }
}
