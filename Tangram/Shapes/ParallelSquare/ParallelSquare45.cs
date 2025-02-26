﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tangram.Shapes.ParallelSquare
{
    public class ParallelSquare45 : Shape
    {
        public ParallelSquare45()
        {
            BackColor = Color.Aqua;

            Name = Constants.ParallelSquare45;
            Type = ShapeTypes.ParallelSquare;
            Size = new Size(Constants.CoefficientUnit, Constants.CoefficientUnit*2);

        }
        protected override void OnPaint(PaintEventArgs e)
        {
            using (var grp = new GraphicsPath())
            {
                grp.AddPolygon(new PointF[]
                {
                    new PointF(0,0 ),
                    new PointF(Width,Width),
                    new PointF( Width,Height),
                    new PointF(0, Constants.CoefficientUnit)

                });
                this.Region = new Region(grp);
            }
            base.OnPaint(e);
        }


        protected override void OnClick(EventArgs e)
        {
            ShapeManager.SetNextShape(this, new ParallelSquareM45());
            base.OnClick(e);
        }
    }
}
