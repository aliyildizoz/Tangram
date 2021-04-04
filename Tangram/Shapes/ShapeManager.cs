using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tangram.Shapes
{
    public class ShapeManager
    {
        public static void SetNextShape(Shape currentSahape, Shape nextShapeName)
        {
            if (!currentSahape.ignoreClick)
            {
                Form mainForm = Application.OpenForms[0];
                nextShapeName.Location = currentSahape.Location;
                mainForm.Controls.Remove(currentSahape);
                mainForm.Controls.Add(nextShapeName);
                ControlExtension.Draggable(nextShapeName, true);
            }

        }

        public static PointF[] GetTrianglePoints0(int size)
        {
            return new PointF[] { new PointF(0, 0), new PointF(size, size), new PointF(0, size) };
        }
        public static PointF[] GetTrianglePoints45(int size)
        {
            return new PointF[] { new PointF(size / 2, size / 2), new PointF(size, 0), new PointF(0, 0) };
        }
        public static PointF[] GetTrianglePoints90(int size)
        {
            return new PointF[] { new PointF(size, 0), new PointF(size, size), new PointF(0, size) };
        }
        public static PointF[] GetTrianglePoints135(int size)
        {
            return new PointF[] { new PointF(0, 0), new PointF(0, size), new PointF(size / 2, size / 2) };
        }
        public static PointF[] GetTrianglePoints180(int size)
        {
            return new PointF[] { new PointF(0, 0), new PointF(size, 0), new PointF(size, size) };
        }
        public static PointF[] GetTrianglePoints225(int size)
        {
            return new PointF[] { new PointF(size / 2, 0), new PointF(size, size / 2), new PointF(0, size / 2) };
        }
        public static PointF[] GetTrianglePoints270(int size)
        {
            return new PointF[] { new PointF(0, 0), new PointF(0, size), new PointF(size, 0) };
        }
        public static PointF[] GetTrianglePoints315(int size)
        {
            return new PointF[] { new PointF(size, 0), new PointF(size, size), new PointF(size / 2, size / 2) };
        }
    }
}
