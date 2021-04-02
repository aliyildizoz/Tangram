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
    public class Big1Triangle90 : Shape
    {
        public Big1Triangle90()
        {
            BackColor = Color.Blue;

            Name = Constants.Big1Triangle90;
            Type = ShapeTypes.BigTriangle1;
            Size = new Size(Constants.SquareLength, Constants.SquareLength);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            using (var grp = new GraphicsPath())
            {
                grp.AddPolygon(new Point[]
                {
                    new Point(Constants.SquareLength,0),
                    new Point(Constants.SquareLength,Constants.SquareLength),
                    new Point(0,Constants.SquareLength)

                });

                this.Region = new Region(grp);
            }
            base.OnPaint(e);
        }

        protected override void OnClick(EventArgs e)
        {
            ShapeManager.SetNextShape(this, Constants.Big1Triangle135);
            base.OnClick(e);
        }
    }
}
