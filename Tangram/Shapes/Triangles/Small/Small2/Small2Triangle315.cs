using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Tangram.Shapes.Triangles.Small.Small2
{
    public class Small2Triangle315 : Shape
    {
        public Small2Triangle315()
        {
            BackColor = Color.Lime;

            Name = Constants.Small2Triangle315;
            Type = ShapeTypes.SmallTriangle2;
            Size = new Size(Constants.SquareLength / 2, Constants.SquareLength / 2);
            Location = new Point(Constants.ShapesFirstLocation.X + Constants.SquareLength / 4, Constants.ShapesFirstLocation.Y + Constants.SquareLength / 4);
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
            ShapeManager.SetNextShape(this, new Small2Triangle0());
            base.OnClick(e);
        }
    }
}
