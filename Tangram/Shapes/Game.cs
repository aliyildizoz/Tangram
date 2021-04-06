using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge;
using Tangram.Shapes.ParallelSquare;
using Tangram.Shapes.Square;
using Tangram.Shapes.Triangles.Big.Big1;
using Tangram.Shapes.Triangles.Big.Big2;
using Tangram.Shapes.Triangles.Middle;
using Tangram.Shapes.Triangles.Small.Small1;
using Tangram.Shapes.Triangles.Small.Small2;

namespace Tangram.Shapes
{
    public class Game
    {
        public static Dictionary<int, Point[]> Levels = new Dictionary<int, Point[]>
        {
            {1,new Point[]
            {

            } },
            {2,new Point[]{} },
            {3,new Point[]{} },
            {4,new Point[]{} },
            {5,new Point[]{} },
            {6,new Point[]{} },
            {7,new Point[]{} },
            {8,new Point[]{} },
            {9,new Point[]{} }
        };

        public static Point[] CurrentLevel
        {
            get
            {
                return Levels[Level];
            }

            private set => Levels[Level] = value;
        }

        public static int Level = 1;

        public static void NextLevel()
        {
            Level++;
            CurrentLevel = Levels[Level];
        }

        public static void Start()
        {
            
            Form mainForm = Application.OpenForms[0];
            Big1Triangle135 big1Triangle135 = new Big1Triangle135();
            Big2Triangle45 big2Triangle45 = new Big2Triangle45();
            Small1Triangle225 small1Triangle225 = new Small1Triangle225();
            Small2Triangle315 small1Triangle315 = new Small2Triangle315();
            Square45 square45 = new Square45();
            MiddleTriangle90 middleTriangle90 = new MiddleTriangle90();
            ParallelSquare45 parallelSquare45 = new ParallelSquare45();
           
            mainForm.Controls.Add(big1Triangle135);
            mainForm.Controls.Add(big2Triangle45);
            mainForm.Controls.Add(small1Triangle225);
            mainForm.Controls.Add(small1Triangle315);
            mainForm.Controls.Add(square45);
            mainForm.Controls.Add(middleTriangle90);
            mainForm.Controls.Add(parallelSquare45);

            ControlExtension.Draggable(big1Triangle135, true);
            ControlExtension.Draggable(big2Triangle45, true);
            ControlExtension.Draggable(small1Triangle315, true);
            ControlExtension.Draggable(small1Triangle225, true);
            ControlExtension.Draggable(square45, true);
            ControlExtension.Draggable(middleTriangle90, true);
            ControlExtension.Draggable(parallelSquare45, true);
        }
    }
}
