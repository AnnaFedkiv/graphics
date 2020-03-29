using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Graphics1
{
    public partial class picture_created : Form
    {

        public picture_created()
        {
            InitializeComponent();
        }

        private void picture_created_Paint(object sender, PaintEventArgs e)
        {
            System.Drawing.Graphics graphicsobj;
            graphicsobj = this.CreateGraphics();
            Pen pen_black = new Pen(System.Drawing.Color.Black, 5);
            graphicsobj.DrawLine(pen_black, 20, 20, 200, 10);
        }
    }
}
