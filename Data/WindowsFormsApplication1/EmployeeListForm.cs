using BaseFormProject;
using Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telerik.WinControls.UI;
using System.Linq.Dynamic;
using Telerik.OpenAccess;
namespace WindowsFormsApplication1
{
    public class EmployeeListForm : BaseActiveForm, ISearchForm
    {
        private readonly string _tableName = "DenemeD";
        IApplicationContext _context = new Data.ApplicationContext(prp.conn);
        IRepository _repo;
        private RadGridView searchGrid;
        public EmployeeListForm() : base()
        {
            _repo = new DataAccessRepository(_context);
            InitializeComponent();
            loadToolBar();
            initControls();
            base.ApplyThemeRecursively(this.Controls);
        }


        #region Public Methods

        public void refreshView()
        {
            refreshGrid();
        }

        public void search(string searchText)
        {
            var searcdata = _repo.getAll(_tableName).
                Where(string.Format("{0}.Contains(\"{1}\")", "Ad", searchText))
                .Cast<object>()
                .ToList();
            searchGrid.DataSource = searcdata;
            lblSearch.Text = "";

        }

        #endregion Public Methods

        #region Private Methods
        private void initControls()
        {
            refreshView();
        }

        private void loadToolBar()
        {

            base.loadToolBar();
            lblFormName.Text = "Employee List";
            RadButton btnSearch = new BaseFormProject.ToolBarButton(0, "lightMagnify");
            RadButton btnDelete = new BaseFormProject.ToolBarButton(2, "lightDelete");
            //  RadButton btnNewRecord= new BaseFormProject.ToolBarButton(1, "lightLayerAdd");
            btnSearch.Click += searchClick;
            //      btnNewRecord.Click += addNewClick;            
            this.panel1.Controls.Add(btnSearch);
            this.panel1.Controls.Add(btnDelete);
            //    this.panel1.Controls.Add(btnNewRecord);
            searchGrid.MasterTemplate.AllowAddNewRow = false;

        }

        private void searchClick(object sender, EventArgs e)
        {
            new SearchDialog(this).ShowDialog();
        }

        private void addNewClick(object sender, EventArgs e)
        {
        }

        private void _searchGrid_CurrentRowChanged(object sender, CurrentRowChangedEventArgs e)
        {
        }
        private void refreshGrid()
        {
            var searcdata = _repo.getAll(_tableName)
              .Cast<object>()
              .ToList();
            searchGrid.DataSource = searcdata;
        }

        #endregion Private Methods
        private void InitializeComponent()
        {
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            this.searchGrid = new Telerik.WinControls.UI.RadGridView();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lblFormName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchGrid.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Size = new System.Drawing.Size(45, 536);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.searchGrid);
            this.panel2.Size = new System.Drawing.Size(869, 536);
            this.panel2.Controls.SetChildIndex(this.lblFormName, 0);
            this.panel2.Controls.SetChildIndex(this.lblSearch, 0);
            this.panel2.Controls.SetChildIndex(this.searchGrid, 0);
            // 
            // searchGrid
            // 
            this.searchGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.searchGrid.Location = new System.Drawing.Point(6, 34);
            // 
            // 
            // 
            this.searchGrid.MasterTemplate.AllowAddNewRow = false;
            this.searchGrid.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.searchGrid.Name = "searchGrid";
            this.searchGrid.Size = new System.Drawing.Size(851, 490);
            this.searchGrid.TabIndex = 2;
            this.searchGrid.Text = "radGridView1";
            // 
            // EmployeeListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(914, 536);
            this.Name = "EmployeeListForm";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lblFormName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchGrid.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }
    }
}
