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
    public class Big2Triangle135 : Shape
    {
        public Big2Triangle135()
        {
            BackColor = Color.HotPink;

            Name = Constants.Big2Triangle135;
            Type = ShapeTypes.BigTriangle2;
            Size = new Size(Constants.Coefficient * 2, Constants.Coefficient * 2);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            using (var grp = new GraphicsPath())
            {
                grp.AddPolygon(ShapeManager.GetTrianglePoints135(Size.Height));

                this.Region = new Region(grp);
            }
            base.OnPaint(e);
        }

        protected override void OnClick(EventArgs e)
        {
            ShapeManager.SetNextShape(this, Constants.Big2Triangle180);
            base.OnClick(e);
        }
    }
}
