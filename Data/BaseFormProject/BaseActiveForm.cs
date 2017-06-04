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
            this.FormBorderStyle = FormBorderStyle.Sizable;
            InitializeComponent();         
        }
    }
}
