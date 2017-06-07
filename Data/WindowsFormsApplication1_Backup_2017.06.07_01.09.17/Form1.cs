using BaseFormProject;
using Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Dynamic;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telerik.WinControls.UI;
using Telerik.OpenAccess;

namespace WindowsFormsApplication1
{
    public partial class Form1 : BaseActiveForm, IRefresh, ISearchForm
    {
        #region Private Fields

        private readonly string _tableName = "DenemeD";
        IApplicationContext _context = new Data.ApplicationContext(prp.conn);
        IRepository _repo;
        RadGridView _searchGrid;

        #endregion Private Fields

        #region Public Constructors

        public Form1() : base()
        {
            _repo = new DataAccessRepository(_context);
            InitializeComponent();
            loadToolBar();
            initControls();
            base.ApplyThemeRecursively(this.Controls);
        }

        #endregion Public Constructors

        #region Public Methods

        public void refreshView()
        {
            refreshGrid();
        }

        public void search(string searchText)
        {
            if (_searchGrid == null)
                createSearchGrid();
            var searcdata = _repo.getAll(_tableName).
                Where(string.Format("{0}.Contains(\"{1}\")", "Ad", searchText))
                .Cast<object>()
                .ToList();
            _searchGrid.DataSource = searcdata;
            lblSearch.Text = searcdata.Count.ToString() + "▼";
            lblSearch.Click += LblSearch_Click;
            lblSearch.Show();

        }

        private void LblSearch_Click(object sender, EventArgs e)
        {
            if (_searchGrid.Visible)
                _searchGrid.Hide();
            else _searchGrid.Show();
            _searchGrid.BringToFront();

        }

        #endregion Public Methods

        #region Private Methods

        private void addFieldClick(object sender, EventArgs e)
        {
            AddField f = new AddField(_repo, "DenemeD", this);
            f.ShowDialog();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            _context.UpdateSchema();
        }

        private void createSearchGrid()
        {
            _searchGrid = new RadGridView();
            _searchGrid.Hide();
            _searchGrid.ThemeName = base.themeName;
            _searchGrid.MasterTemplate.AllowAddNewRow = false;
            _searchGrid.MasterTemplate.ShowGroupedColumns = false;
            _searchGrid.ShowGroupedColumns = false;
            _searchGrid.ShowGroupPanel = false;
            _searchGrid.Size = new Size(500, 250);
            _searchGrid.Location = new Point(0, 30);
            this.panel2.Controls.Add(_searchGrid);
            _searchGrid.CurrentRowChanged += new Telerik.WinControls.UI.CurrentRowChangedEventHandler(this._searchGrid_CurrentRowChanged);

        }

        private void initControls()
        {
            refreshView();
        }

        private void loadToolBar()
        {

            base.loadToolBar();
            lblFormName.Text = "Employee";
            RadButton btnSearch = new BaseFormProject.ToolBarButton(0, "lightMagnify");
            RadButton btnSave = new BaseFormProject.ToolBarButton(1, "lightSave");
            RadButton btnDelete = new BaseFormProject.ToolBarButton(2, "lightDelete");
            RadButton btnFieldAdd = new BaseFormProject.ToolBarButton(3, "lightLayerAdd");
            btnSearch.Click += searchClick;
            btnFieldAdd.Click += addFieldClick;
            btnSave.Click += saveClick;
            this.panel1.Controls.Add(btnSave);
            this.panel1.Controls.Add(btnSearch);
            this.panel1.Controls.Add(btnDelete);
            this.panel1.Controls.Add(btnFieldAdd);

        }

        private void _searchGrid_CurrentRowChanged(object sender, CurrentRowChangedEventArgs e)
        {
            var data = _repo.getById(_tableName, e.CurrentRow.Cells["Id"].Value.ToString());
            if (data != null)
            {
                radGridView1.Rows.Clear();
                GridViewDataRowInfo rowInfo = new GridViewDataRowInfo(this.radGridView1.MasterView);
                foreach (var item in radGridView1.Columns)
                {
                    Type a = item.DataType;
                    rowInfo.Cells[item.Name].Value = data.FieldValue<object>(item.Name);
                }
                radGridView1.Rows.Add(rowInfo);
                radGridView1.BringToFront();
                _searchGrid.Hide();
            }

        }

        private void refreshGrid()
        {
            radGridView1.Columns.Clear();
            var data = _repo.getColumns(_tableName);
            GridViewDataColumn colmn = null;
            foreach (var item in data)
            {
                var itemType = MetaDataSourceExtension.GetArtificialFieldType(item.FieldType, false);
                if (itemType == typeof(string))
                {
                    colmn = new GridViewTextBoxColumn();
                    colmn.TextAlignment = ContentAlignment.BottomLeft;
                    colmn.Width = 50;
                }
                else if (itemType == typeof(bool))
                {
                    colmn = new GridViewCheckBoxColumn();
                    colmn.TextAlignment = ContentAlignment.MiddleCenter;
                    colmn.Width = 50;
                }
                else
                {
                    colmn = new GridViewTextBoxColumn();
                    colmn.TextAlignment = ContentAlignment.MiddleCenter;
                    colmn.Width = 50;
                }
                colmn.DataType = itemType;
                colmn.Name = item.Name;
                colmn.HeaderText = item.Name;
                colmn.FieldName = item.Name;
                radGridView1.Columns.Add(colmn);
            }

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

        private void searchClick(object sender, EventArgs e)
        {
            new SearchDialog(this).ShowDialog();
        }

        #endregion Private Methods
    }
}
