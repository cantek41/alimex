using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;
using Telerik.WinControls.UI;
using Alimex.Properties;
using Telerik.WinControls;

namespace Alimex.MenuForm
{
    public partial class WideMenu : UserControl
    {
        ImageList imageList;
        private RadTreeNode dragNode = null;
        List<Data> dt;
        List<Data> temp;
        string filePath = @"../../MenuForm/menuJson.json";
        public WideMenu()
        {
            InitializeComponent();
            Init();
            WireEvents();
            radTreeView.ThemeName = "TelerikMetro";
            radTreeView.TreeViewElement.BackColor = Color.Transparent;
            radWideFormPanel.BackColor = Color.Transparent;
            radTextBox.BackColor = Color.FromArgb(234, 235, 236);
            btnClose.BackColor = Color.FromArgb(234, 235, 236); 
            radTreeView.TreeViewElement.BackColor = Color.Transparent;
            TreeViewDragDropService dragDropService1 = this.radTreeView.TreeViewElement.DragDropService;
            dragDropService1.PreviewDragOver += new EventHandler<RadDragOverEventArgs>(DragDropService_PreviewDragOver);
            this.radTreeView.SelectedNodeChanged += radTreeView1_Selected; 
        }

        private void radTreeView1_Selected(object sender, RadTreeViewEventArgs e)
        {
            ((MainForm)this.Parent.Parent.Parent).showForm(((CustomNode)e.Node).Namesapace, ((CustomNode)e.Node).Url);            
        }
        private void Init()
        {
            this.components = new System.ComponentModel.Container();

            radTreeView.DisplayMember = "Title";
            radTreeView.ParentMember = "ParentId";
            radTreeView.ChildMember = "Id";

            readNavigation();

            this.imageList = new System.Windows.Forms.ImageList(this.components);

            foreach (var item in dt.Where(x=>x.ParentId==0))
            {
                CustomNode radTreeNode2 = new CustomNode();
                radTreeNode2.Image = ((System.Drawing.Image)(Resources.ResourceManager.GetObject("radTreeNode2.Image")));
                radTreeNode2.ImageIndex = 1;
                radTreeNode2.Text = item.Title;
                radTreeNode2.Id = item.Id;
                radTreeNode2.Icon = item.Icon;
                radTreeNode2.ParentId = item.ParentId;
                radTreeNode2.UrlType = item.UrlType;
                radTreeNode2.Namesapace = item.Namesapace;
                radTreeNode2.Url = item.Url;

                this.radTreeView.Nodes.Add(prepareData(item, radTreeNode2));
            }
            this.radTreeView.ItemHeight = 27;
            this.radTreeView.ExpandAnimation = ExpandAnimation.None;
            this.radTreeView.FullRowSelect = false;
            this.radTreeView.MultiSelect = true;
            this.radTreeView.AllowDragDrop = true;
            this.radTreeView.AllowDrop = true;
            this.radTreeView.ImageList = this.imageList;
        }

        private void readNavigation()
        {
            string son = File.ReadAllText(filePath);
            dt = (List<Data>)JsonConvert.DeserializeObject(son, (typeof(List<Data>)));
        }

        private CustomNode prepareData(Data data,CustomNode parent)
        {
            if (parent == null)
                parent = new CustomNode();

            foreach (var item in dt.Where(x=>x.ParentId==data.Id).ToList())
            {
                CustomNode radTreeNode2 = new CustomNode();
                radTreeNode2.Image = ((System.Drawing.Image)(Resources.ResourceManager.GetObject("radTreeNode2.Image")));
                radTreeNode2.ImageIndex = 1;
                radTreeNode2.Text = item.Title;
                radTreeNode2.Id = item.Id;
                radTreeNode2.Icon = item.Icon;
                radTreeNode2.ParentId = item.ParentId;
                radTreeNode2.UrlType = item.UrlType;
                radTreeNode2.Namesapace = item.Namesapace;
                radTreeNode2.Url = item.Url;
                parent.Nodes.Add(radTreeNode2);
                if (dt.Where(x => x.ParentId == item.Id).Count() > 0)
                prepareData(item, radTreeNode2);
            }
            return parent;
        }

        private void DragDropService_PreviewDragOver(object sender, RadDragOverEventArgs e)
        {

        }
        private void radTreeView_DragEnded(object sender, RadTreeViewDragEventArgs e)
        {
            var node = radTreeView.Nodes.ToList();
            temp = new List<Data>();
            foreach (var item in node)
            {
                changeParent((CustomNode)item, 0); 
            }
            String json = JsonConvert.SerializeObject(temp);
            StreamWriter wr = new StreamWriter(filePath, false);
            wr.Write(json);
            wr.Close();
            readNavigation();
        }

        private void changeParent(CustomNode node, int parentId)
        {
            temp.Add(new Data() { Id = node.Id, Title = node.Text, ParentId = parentId,Namesapace=node.Namesapace,Url=node.Url,UrlType=node.UrlType });
            foreach (var item in node.Nodes)
            {
                changeParent((CustomNode)item, node.Id);
            }
        }

        private void radTreeView_ItemDrag(object sender, RadTreeViewEventArgs e)
        {
            this.dragNode = e.Node;
        }
        protected void WireEvents()
        {
            this.radTreeView.ItemDrag += new Telerik.WinControls.UI.RadTreeView.ItemDragHandler(radTreeView_ItemDrag);
            this.radTreeView.DragEnded += new RadTreeView.DragEndedHandler(radTreeView_DragEnded);
        }

    }
}
