using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tangram.Shapes.ParallelSquare;
using Tangram.Shapes.Square;
using Tangram.Shapes.Triangles.Big.Big1;
using Tangram.Shapes.Triangles.Big.Big2;
using Tangram.Shapes.Triangles.Middle;
using Tangram.Shapes.Triangles.Small.Small1;
using Tangram.Shapes.Triangles.Small.Small2;
using Point = AForge.Point;

namespace Tangram.Shapes
{
    public class Game
    {
        public static Dictionary<int, PointF[]> Levels = new Dictionary<int, PointF[]>
        {
            {1,new PointF[]
            {
                new PointF(2*Constants.Unit,0),
                new PointF(0,2*Constants.Unit),
                new PointF(Constants.Unit*6/2,5*Constants.Unit),
                new PointF(Constants.Unit*6,2*Constants.Unit),
                new PointF(Constants.Unit*4,0),
                new PointF(Constants.Unit*3,Constants.Unit)
            } },
            {2,new PointF[]
            {

            } },
            {3,new PointF[]{} },
            {4,new PointF[]{} },
            {5,new PointF[]{} },
            {6,new PointF[]{} },
            {7,new PointF[]{} },
            {8,new PointF[]{} },
            {9,new PointF[]{} }
        };

        public static PointF[] CurrentLevel
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
            Level level = new Level();
            
          
            mainForm.Controls.Add(big1Triangle135);
            mainForm.Controls.Add(big2Triangle45);
            mainForm.Controls.Add(small1Triangle225);
            mainForm.Controls.Add(small1Triangle315);
            mainForm.Controls.Add(square45);
            mainForm.Controls.Add(middleTriangle90);
            mainForm.Controls.Add(parallelSquare45);
            mainForm.Controls.Add(level);
            level.SendToBack();

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
