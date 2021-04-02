using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tangram.Shapes;
using Tangram.Shapes.Square;
using Tangram.Shapes.Triangles.Big.Big1;
using Tangram.Shapes.Triangles.Big.Big2;
using Tangram.Shapes.Triangles.Small.Small1;
using Tangram.Shapes.Triangles.Small.Small2;

namespace Tangram
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Big1Triangle135 big1Triangle135 = new Big1Triangle135();
            Big2Triangle45 big2Triangle45 = new Big2Triangle45();
            Small1Triangle225 small1Triangle225 = new Small1Triangle225();
            Small2Triangle315 small1Triangle315 = new Small2Triangle315();
            Square45 square45 = new Square45();
            this.Controls.Add(big1Triangle135);
            this.Controls.Add(big2Triangle45);
            this.Controls.Add(small1Triangle225);
            this.Controls.Add(small1Triangle315);
            this.Controls.Add(square45);
            
            ControlExtension.Draggable(big1Triangle135, true);
            ControlExtension.Draggable(big2Triangle45, true);
            ControlExtension.Draggable(small1Triangle315, true);
            ControlExtension.Draggable(small1Triangle225, true);
            ControlExtension.Draggable(square45, true);


        }



        
    }
}

