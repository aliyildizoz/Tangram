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
    public class Big2Triangle180 : Shape
    {
        public Big2Triangle180()
        {
            BackColor = Color.HotPink;

            Name = Constants.Big2Triangle180;
            Type = ShapeTypes.BigTriangle2;
            Size = new Size(Constants.Coefficient, Constants.Coefficient);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            using (var grp = new GraphicsPath())
            {
                grp.AddPolygon(ShapeManager.GetTrianglePoints180(Size.Height));

                this.Region = new Region(grp);
            }
            base.OnPaint(e);
        }

        protected override void OnClick(EventArgs e)
        {
            ShapeManager.SetNextShape(this, new Big2Triangle225());
            base.OnClick(e);
        }
    }
}
