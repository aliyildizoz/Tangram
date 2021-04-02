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
using Tangram.Shapes.Triangles.Big.Big1;

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
            Big1Triangle0 big1Triangle0 = new Big1Triangle0(){Visible = false};
            Big1Triangle45 big1Triangle45 = new Big1Triangle45(){Visible = false};
            Big1Triangle90 big1Triangle90 = new Big1Triangle90(){Visible = false};
            Big1Triangle135 big1Triangle135 = new Big1Triangle135(){Visible = true};
            Big1Triangle180 big1Triangle180 = new Big1Triangle180(){Visible = false};
            Big1Triangle225 big1Triangle225 = new Big1Triangle225(){Visible = false};
            Big1Triangle270 big1Triangle270 = new Big1Triangle270(){Visible = false};
            Big1Triangle315 big1Triangle315 = new Big1Triangle315(){Visible = false};
            Big2Triangle45 big2Triangle45 = new Big2Triangle45(){Visible = true};


            this.Controls.Add(big1Triangle0);
            this.Controls.Add(big1Triangle45);
            this.Controls.Add(big1Triangle90);
            this.Controls.Add(big1Triangle135);
            this.Controls.Add(big1Triangle180);
            this.Controls.Add(big1Triangle225);
            this.Controls.Add(big1Triangle270);
            this.Controls.Add(big1Triangle315);
            this.Controls.Add(big2Triangle45);
            
            ControlExtension.Draggable(big1Triangle0, true);
            ControlExtension.Draggable(big1Triangle45, true);
            ControlExtension.Draggable(big1Triangle90, true);
            ControlExtension.Draggable(big1Triangle135, true);
            ControlExtension.Draggable(big1Triangle180, true);
            ControlExtension.Draggable(big1Triangle225, true);
            ControlExtension.Draggable(big1Triangle270, true);
            ControlExtension.Draggable(big1Triangle315, true);
            ControlExtension.Draggable(big2Triangle45, true);


        }



        
    }
}

