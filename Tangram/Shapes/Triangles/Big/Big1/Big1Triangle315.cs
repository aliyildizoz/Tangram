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
    public class Big1Triangle315 : Shape
    {
        public Big1Triangle315()
        {
            BackColor = Color.Blue;

            Name = Constants.Big1Triangle315;
            Type = ShapeTypes.BigTriangle1;
            Size = new Size(Constants.Sqrt2Lenght, Constants.Sqrt2Lenght);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            using (var grp = new GraphicsPath())
            {
                grp.AddPolygon(ShapeManager.GetTrianglePoints315(Size.Height));

                this.Region = new Region(grp);
            }
            base.OnPaint(e);
        }


        protected override void OnClick(EventArgs e)
        {
            ShapeManager.SetNextShape(this, Constants.Big1Triangle0);
            base.OnClick(e);
        }
    }
}
