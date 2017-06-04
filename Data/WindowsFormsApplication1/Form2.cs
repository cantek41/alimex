using BaseFormProject;
using Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telerik.WinControls.UI;

namespace WindowsFormsApplication1
{
    public partial class Form2 : BaseForm
    {
        IRepository _repo;
        string _tableName;
        IRefresh _parentform;
        public Form2(IRepository repo,string tableName,IRefresh parentform):base()
        {
            InitializeComponent();
            base.ApplyThemeRecursively(this.Controls);
            _repo = repo;
            _tableName = tableName;
            Dictionary<string, FieldType> test = new Dictionary<string, FieldType>();
            test.Add("integer", FieldType.Int32);
            test.Add("string", FieldType.String);
            test.Add("boolean", FieldType.Boolean);          
            comboBox1.DataSource = new BindingSource(test, null);
            comboBox1.DisplayMember = "Value";
            comboBox1.ValueMember = "Key";
            _parentform = parentform;           
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var tables = _repo.getTables();
            tables.Where(x => x.Name == _tableName).FirstOrDefault().Fields.Add(new TableField()
            {
                Name=textBox1.Text,
                FieldType =(FieldType)comboBox1.SelectedItem.Value,
                IsNullable=true,
                IsUnique=false

            });
            _repo.UpdateDb(tables);
            _parentform.refreshView();
            this.Close();
            
        }
    }
}
