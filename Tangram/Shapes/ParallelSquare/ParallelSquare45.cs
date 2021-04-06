using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tangram.Shapes.Square;

namespace Tangram.Shapes.ParallelSquare
{
    public class ParallelSquare45 : Shape
    {
        public ParallelSquare45()
        {
            BackColor = Color.Aqua;

            Name = Constants.ParallelSquare45;
            Type = ShapeTypes.ParallelSquare;
            Size = new Size(Constants.SquareLength / 4, (Constants.SquareLength / 4) * 3);
            Location = new Point(Constants.ShapesFirstLocation.X + Height, Constants.ShapesFirstLocation.Y);

        }
        protected override void OnPaint(PaintEventArgs e)
        {
            using (var grp = new GraphicsPath())
            {
                grp.AddPolygon(new PointF[]
                {
                    new PointF(Width,0 ),
                    new PointF(0,Width),
                    new PointF( 0,Height),
                    new PointF(Width, Constants.SquareLength / 2)

                });
                this.Region = new Region(grp);
            }
            base.OnPaint(e);
        }


        protected override void OnClick(EventArgs e)
        {
            //ShapeManager.SetNextShape(this, new Square45());
            base.OnClick(e);
        }
    }
}
