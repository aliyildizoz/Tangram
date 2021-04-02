using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge;

namespace Tangram.Shapes
{
    public class ShapeManager
    {
        public static void SetNextShape(Shape currentSahape, string nextShapeName)
        {

            foreach (Control control in Application.OpenForms[0].Controls)
            {
                if (control is Shape)
                {
                    var shape = (Shape)(control);
                    if (shape.Type == currentSahape.Type)
                    {
                        if (shape.Name == nextShapeName)
                        {
                            
                            currentSahape.Visible = false;
                            shape.Visible = true;
                            MessageBox.Show(nextShapeName);
                            shape.Location = currentSahape.Location;
                        }
                    }
                }
            }
        }
    }
}
