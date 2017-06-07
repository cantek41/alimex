using BaseFormProject.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telerik.WinControls.UI;

namespace BaseFormProject
{
    public class ToolBarButton : RadButton
    {
        readonly int width = 40;

        public ToolBarButton(int index,string imageName)
        {
            this.Size = new System.Drawing.Size(width, width);
            this.Image = ((System.Drawing.Image)(Resources.ResourceManager.GetObject(imageName)));
            this.ImageAlignment = ContentAlignment.MiddleCenter;
            this.Location = new System.Drawing.Point(2, (5 + width) * index);
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.GetChildAt(0).GetChildAt(2))).Visibility = Telerik.WinControls.ElementVisibility.Hidden;
        }
    }
}
