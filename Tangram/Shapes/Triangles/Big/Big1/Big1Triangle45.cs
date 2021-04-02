using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tangram.Shapes.Triangles.Big.Big1
{
    public class Big1Triangle45 : Shape
    {
        public Big1Triangle45()
        {
            BackColor = Color.Blue;
            Name = Constants.Big1Triangle45;
            Type = ShapeTypes.BigTriangle1;
            Size = new Size(Constants.Sqrt2Lenght, Constants.Sqrt2Lenght);
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            using (var grp = new GraphicsPath())
            {
                grp.AddPolygon(ShapeManager.GetTrianglePoints45(Size.Height));
                this.Region = new Region(grp);
            }
            base.OnPaint(e);
        }

        protected override void OnClick(EventArgs e)
        {
            ShapeManager.SetNextShape(this, Constants.Big1Triangle90);
            base.OnClick(e);
        }


    }
}
