using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tangram.Shapes.Triangles.Big.Big1;

namespace Tangram.Shapes.Square
{
    public class Square45 : Shape
    {
        public Square45()
        {
            BackColor = Color.Red;

            Name = Constants.Square45;
            Type = ShapeTypes.Square;
            Size = new Size(Constants.SquareLength / 2, Constants.SquareLength / 2);
            Location = new Point(Constants.FirstLocation.X + Constants.SquareLength / 4, Constants.FirstLocation.Y + Constants.SquareLength / 2);

        }

        protected override void OnPaint(PaintEventArgs e)
        {
            using (var grp = new GraphicsPath())
            {
                grp.AddPolygon(new PointF[]
                {
                    new PointF(Constants.SquareLength / 4,0),
                    new PointF(0, Constants.SquareLength / 4),
                    new PointF(Constants.SquareLength / 4, Constants.SquareLength / 2),
                    new PointF(Constants.SquareLength / 2, Constants.SquareLength / 4) 
                   
                });
                this.Region = new Region(grp);
            }
            base.OnPaint(e);
        }

        protected override void OnClick(EventArgs e)
        {
            ShapeManager.SetNextShape(this, new Square0());
            base.OnClick(e);
        }
    }
}
