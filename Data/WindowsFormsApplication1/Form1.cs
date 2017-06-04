using BaseFormProject;
using Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telerik.WinControls.UI;

namespace WindowsFormsApplication1
{
    public partial class Form1 : BaseActiveForm, IRefresh
    {
        IApplicationContext _context = new Data.ApplicationContext(prp.conn);

        IRepository _repo;
        public Form1():base()
        {
             _repo = new DataAccessRepository(_context);     
            InitializeComponent();
            loadToolBar();
            initControls();
            base.ApplyThemeRecursively(this.Controls);
        }

        private void initControls()
        {
            refreshGrid();
        }

        private void loadToolBar()
        {

            base.loadToolBar();
            lblFormName.Text = "Employee";
            RadButton btnSearch = new BaseFormProject.ToolBarButton(0, "lightMagnify");
            RadButton btnSave = new BaseFormProject.ToolBarButton(1, "lightSave");
            RadButton btnDelete = new BaseFormProject.ToolBarButton(2, "lightDelete");
            RadButton btnFieldAdd = new BaseFormProject.ToolBarButton(3, "lightLayerAdd");
            btnFieldAdd.Click += addFieldClick;
            btnSave.Click += saveClick;            
            this.panel1.Controls.Add(btnSave);
            this.panel1.Controls.Add(btnSearch);
            this.panel1.Controls.Add(btnDelete);
            this.panel1.Controls.Add(btnFieldAdd); 
         
        }

        private void addFieldClick(object sender, EventArgs e)
        {
            AddField f = new AddField(_repo, "DenemeD", this);
            f.ShowDialog();
        }
        public void refreshView()
        {
            refreshGrid();
        }
        private void refreshGrid()
        {
            var data = _repo.getAll("DenemeD").Cast<object>().ToList();
            radGridView1.DataSource = data;
            radGridView1.Rows.Clear();
        }

        private void saveClick(object sender, EventArgs e)
        {
            Dictionary<string, string> entity = new Dictionary<string, string>();
            foreach (var col in radGridView1.Columns)
            {
                if (radGridView1.Rows[0].Cells[col.Name].Value == null)
                    continue;
                entity.Add(col.Name, radGridView1.Rows[0].Cells[col.Name].Value.ToString());
            }
            _repo.Insert("DenemeD", entity);
        }
       
        private void button1_Click_1(object sender, EventArgs e)
        {
            _context.UpdateSchema();
        }
       
    }
}
