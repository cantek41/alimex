using Data.ModelSource;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telerik.OpenAccess;

namespace ClassLibrary1
{
    public class Class1
    {
        public Class1()
        {
           ModelSource m=new ModelSource();

           foreach (var item in m.getSource())
           {
               Console.WriteLine(item);
           }
            
        }
        public void updateSchema()
        {
            using (ClassLibrary1Context dbContext = new ClassLibrary1Context())
            {
                dbContext.UpdateSchema();
            }
           
        }
        public void insert()
        {
            using (ClassLibrary1Context fluentContext = new ClassLibrary1Context())
            {
                object product = fluentContext.CreateInstance("FluentModel.Product");
                object category = fluentContext.CreateInstance("FluentModel.Category");

                fluentContext.Add(product);
                fluentContext.Add(category);

                fluentContext.SaveChanges();
            }
        }

    }
}
