using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alimex
{
   public class PreperForm
    {
       public static Form getForm(string dllName, string formName)
       {
           Assembly quickStartAssembly = Assembly.Load(dllName);
           Form mainForm = Activator.CreateInstance(quickStartAssembly.GetType(formName)) as Form;
            
           return mainForm;
       }
    }
}
