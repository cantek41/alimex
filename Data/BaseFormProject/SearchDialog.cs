using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaseFormProject
{
    public partial class SearchDialog : BaseForm
    {
        ISearchForm _searchForm;
        public SearchDialog(ISearchForm searchForm) :base()
        {
            _searchForm = searchForm;
            InitializeComponent();
            btnSearch.Click += BtnSearch_Click;            
            this.ApplyThemeRecursively(this.Controls);
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            _searchForm.search(txtSerach.Text);
            this.Close();
        }
    }
}
