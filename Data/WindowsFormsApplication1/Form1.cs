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
    public partial class Form1 : RadForm, IRefresh
    {
        IApplicationContext _context = new Data.ApplicationContext(@"data source=.\sqlexpress;initial catalog=Denemeff;integrated security=True");

        IRepository _repo;
        public Form1()
        {
             _repo = new DataAccessRepository(_context);
             _context.UpdateSchema();
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
        //    panel1.Controls.Clear();

        //    Form2 objForm = new Form2();
        //    objForm.TopLevel = false;
        //    panel1.Controls.Add(objForm);
        //    objForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
        //    objForm.Dock = DockStyle.Fill;
        //    objForm.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //panel1.Controls.Clear();
            //Form3 objForm = new Form3();
            //objForm.TopLevel = false;
            //panel1.Controls.Add(objForm);
            //objForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            //objForm.Dock = DockStyle.Fill;
            //objForm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            refreshGrid();              
        }

        private void refreshGrid()
        {

            var data = _repo.getAll("DenemeD").Cast<object>().ToList();
            //radGridView1.DataSource = data;
            //radGridView1.Rows.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Dictionary<string, string> entity = new Dictionary<string, string>();
            //foreach (var col in radGridView1.Columns)
            //{
            //    if (radGridView1.Rows[0].Cells[col.Name].Value == null)
            //        continue;
            //    entity.Add(col.Name, radGridView1.Rows[0].Cells[col.Name].Value.ToString());
            //}
            _repo.Insert("DenemeD", entity);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2(_repo,"DenemeD",this);
            f.ShowDialog();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            _context.UpdateSchema();
        }


        public void refreshView()
        {
            refreshGrid();
        }
    }
}
