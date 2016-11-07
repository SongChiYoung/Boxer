using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Boxer
{
    public partial class box : Form
    {
        public box()
        {
            InitializeComponent();
        }

        private bool mouseIsDown = false;
        private bool opticalDown = false;
        private Point firstPoint;
        private void box_MouseDown(object sender, MouseEventArgs e)
        {
            firstPoint = e.Location;
            if (e.Button == MouseButtons.Left) mouseIsDown = true;
            else if (e.Button == MouseButtons.Right) opticalDown = true;
        }

        private void box_MouseUp(object sender, MouseEventArgs e)
        {
            mouseIsDown = false;
            opticalDown = false;
        }

        private void box_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseIsDown)
            {
                // Get the difference between the two points
                int xDiff = firstPoint.X - e.Location.X;
                int yDiff = firstPoint.Y - e.Location.Y;

                // Set the new point
                int x = this.Location.X - xDiff;
                int y = this.Location.Y - yDiff;
                this.Location = new Point(x, y);
            }
            else if(opticalDown)
            {
                float xDiff = firstPoint.X - e.Location.X;

                // Set the new point
                //float x = this.Location.X - xDiff;
                this.Opacity += xDiff/10000;
            }
        }

        private void box_DragDrop(object sender, DragEventArgs e)
        {
            string[] s = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            ToDo dlg = new ToDo(s[0]);
            dlg.Show();
        }

        private void box_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.All;
            else
                e.Effect = DragDropEffects.None;
        }
    }
}
