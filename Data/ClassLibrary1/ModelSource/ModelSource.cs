using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.ModelSource
{
    public class ModelSource
    {
        public IList<Table> getSource()
        {
         //   return  JObject.Parse(File.ReadAllText(@"C:\projeler\alimex\Data\Data\ModelSource\Tables.json"));
            using (StreamReader file = File.OpenText(@"C:\projeler\alimex\Data\ClassLibrary1\ModelSource\Tables.json"))
                    {
                        JsonSerializer serializer = new JsonSerializer();                       
                        return (IList<Table>)serializer.Deserialize(file, typeof(IList<Table>));
                    }
        }
    }
}
