using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Graphics1
{
    public partial class picture_created : Form
    {
        int a, b, c, d;

        public picture_created()
        {
            InitializeComponent();
        }

        public void read()
        {
            System.Drawing.Graphics graphicsobj;
            graphicsobj = this.CreateGraphics();
            var localPath = System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\data.txt";

            if (File.Exists(localPath))
            {
                // Read a text file line by line.  
                string[] lines = File.ReadAllLines(localPath);
                int prevX = 0;
                int prevY = 0;

                foreach (string line in lines)
                {
                    string[] words = line.Split(' ');
                    if (words[0] != "G1")
                        continue;

                    string[] lineX = words[1].Split('X');
                    double x = Convert.ToDouble(lineX[1]);


                    string[] lineY = words[2].Split('Y');
                    double y = Convert.ToDouble(lineY[1]);

                    Pen pen_black = new Pen(System.Drawing.Color.Black, 5);

                    int ix = Convert.ToInt32(x);
                    int iy = Convert.ToInt32(y);

                    graphicsobj.DrawLine(pen_black, ix, iy, prevX, prevY);

                    prevX = ix;
                    prevY = iy;

                }
            }
        }

        private void picture_created_Paint(object sender, PaintEventArgs e)
        {
            read();
        }
    }
}
