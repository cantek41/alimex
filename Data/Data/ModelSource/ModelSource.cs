using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class ModelSource
    {
        #region Public Methods
        public IList<Table> getSource() 
        {
            using (StreamReader file = File.OpenText(@"C:\projeler\alimex\Data\Data\ModelSource\Tables.json"))
            {
                JsonSerializer serializer = new JsonSerializer();
                return (IList<Table>)serializer.Deserialize(file, typeof(IList<Table>));

            }
        }

        public bool setSource(IList<Table> tables)
        {
            using (StreamWriter file = new StreamWriter(@"C:\projeler\alimex\Data\Data\ModelSource\Tables.json",false))
            {
                string data = JsonConvert.SerializeObject(tables);
                file.Write(data);
                return true;
            }
        }
        #endregion Public Methods

    }
}
