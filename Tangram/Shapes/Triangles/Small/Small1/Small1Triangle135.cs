﻿using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using Tangram.Shapes.Triangles.Big.Big1;

namespace Tangram.Shapes.Triangles.Small.Small1
{
    public class Small1Triangle135 : Shape
    {
        public Small1Triangle135()
        {
            BackColor = Color.Yellow;

            Name = Constants.Small1Triangle135;
            Type = ShapeTypes.SmallTriangle1;
            Size = new Size(Constants.SquareLength/2, Constants.SquareLength/2);
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
            ShapeManager.SetNextShape(this, new Small1Triangle180());
            base.OnClick(e);
        }
    }
}
