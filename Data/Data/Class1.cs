using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telerik.OpenAccess;

namespace Data
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
             string DbConnection = @"data source=.\sqlexpress;initial catalog=Denemeff;integrated security=True";
             using (ApplicationContext dbContext = new ApplicationContext(DbConnection))
            {
                dbContext.UpdateSchema();
            }
           
        }      
    }
}
