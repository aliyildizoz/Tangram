using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Tangram.Shapes.Triangles.Small.Small1
{
    public class Small1Triangle315 : Shape
    {
        public Small1Triangle315()
        {
            BackColor = Color.Yellow;

            Name = Constants.Small1Triangle315;
            Type = ShapeTypes.SmallTriangle1;
            Size = new Size(Constants.SquareLength/2, Constants.SquareLength/2);
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
            ShapeManager.SetNextShape(this, new Small1Triangle0());
            base.OnClick(e);
        }
    }
}
