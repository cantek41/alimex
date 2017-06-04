using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alimex.MenuForm
{
    public partial class NarrowMenu : UserControl
    {
        public int Width = 60;
      
        public NarrowMenu()
        {
            InitializeComponent();

        }

        public void btnOpenClose_Click(object sender, EventArgs e)
        {
            ((MainForm)this.FindForm()).btnOpenClose_Click(sender, e);
        }


      
    }
}
