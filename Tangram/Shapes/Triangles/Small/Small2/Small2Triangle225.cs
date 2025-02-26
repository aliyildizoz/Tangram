﻿using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using Tangram.Shapes.Triangles.Big.Big1;

namespace Tangram.Shapes.Triangles.Small.Small2
{
    public class Small2Triangle225 : Shape
    {
        public Small2Triangle225()
        {
            BackColor = Color.Lime;

            Name = Constants.Small2Triangle225;
            Type = ShapeTypes.SmallTriangle2;
            Size = new Size(Constants.SquareLength / 2, Constants.SquareLength / 2);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            using (var grp = new GraphicsPath())
            {
                grp.AddPolygon(ShapeManager.GetTrianglePoints225(Size.Height));

                this.Region = new Region(grp);
            }
            base.OnPaint(e);
        }

        protected override void OnClick(EventArgs e)
        {
            ShapeManager.SetNextShape(this, new Small2Triangle270());
            base.OnClick(e);
        }
    }
}
