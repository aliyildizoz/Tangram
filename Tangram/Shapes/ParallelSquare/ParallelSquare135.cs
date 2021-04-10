using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tangram.Shapes.ParallelSquare
{
    public class ParallelSquare135 : Shape
    {
        public ParallelSquare135()
        {
            BackColor = Color.Aqua;

            Name = Constants.ParallelSquare135;
            Type = ShapeTypes.ParallelSquare;
            Size = new Size( Constants.CoefficientUnit * 2, Constants.CoefficientUnit);

        }
        protected override void OnPaint(PaintEventArgs e)
        {
            using (var grp = new GraphicsPath())
            {
                grp.AddPolygon(new PointF[]
                {
                    new PointF(Height,0 ),
                    new PointF(Width,0),
                    new PointF(Height,Height),
                    new PointF( 0,Height),
                   

                });
                this.Region = new Region(grp);
            }
            base.OnPaint(e);
        }


        protected override void OnClick(EventArgs e)
        {
            ShapeManager.SetNextShape(this, new ParallelSquareM135());
            base.OnClick(e);
        }
    }
}
