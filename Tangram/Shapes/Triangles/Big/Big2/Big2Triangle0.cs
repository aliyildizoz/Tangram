using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Tangram.Shapes.Triangles.Big.Big1
{
    public class Big2Triangle0 : Shape
    {
        public Big2Triangle0()
        {
            BackColor = Color.Blue;

            Name = Constants.Big2Triangle0;
            Type = ShapeTypes.BigTriangle2;
            Size = new Size(Constants.SquareLength, Constants.SquareLength);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            using (var grp = new GraphicsPath())
            {
                grp.AddPolygon(ShapeManager.GetTrianglePoints0(Size.Height));

                this.Region = new Region(grp);
            }
            base.OnPaint(e);
        }

        protected override void OnClick(EventArgs e)
        {
            ShapeManager.SetNextShape(this, new Big2Triangle45());
            base.OnClick(e);
        }
    }
}
