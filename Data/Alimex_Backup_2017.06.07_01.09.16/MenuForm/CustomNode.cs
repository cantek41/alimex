using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telerik.WinControls.UI;

namespace Alimex.MenuForm
{
    public class CustomNode:RadTreeNode
    {
        public int Id { get; set; }
        public int ParentId { get; set; }
        public string Title { get; set; }
        public string Icon { get; set; }
        public string UrlType { get; set; }
        public string Namesapace { get; set; }
        public string Url { get; set; }
    }
}
