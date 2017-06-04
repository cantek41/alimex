using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;
namespace BaseFormProject
{
    public partial class BaseActiveForm : BaseForm
    {
        public BaseActiveForm():base()
        {
            InitializeComponent();         
        }

        public void loadToolBar()
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.panel1.Size = new Size(42, this.Height);

        }
    }
}
