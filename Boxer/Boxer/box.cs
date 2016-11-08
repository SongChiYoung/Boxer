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

            ToDo dlg = new ToDo(sender.ToString());
            dlg.Show();
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
                if(this.Opacity < .05)
                {
                    this.Opacity = .05;
                }
            }
        }
        ImageList imageList1;
        private void box_DragDrop(object sender, DragEventArgs e)
        {
            listView1.BeginUpdate();
            string[] s = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            int i;
            for (i = 0; i < s.Length; i++)
            {
                System.IO.FileInfo file = new System.IO.FileInfo(s[i]);
                Icon iconForFile = SystemIcons.WinLogo;
                iconForFile = Icon.ExtractAssociatedIcon(file.FullName);
                ListViewItem item = new ListViewItem(file.Name, 1);
                if (!imageList1.Images.ContainsKey(file.Extension))
                {
                    // If not, add the image to the image list.
                    iconForFile = System.Drawing.Icon.ExtractAssociatedIcon(file.FullName);
                    imageList1.Images.Add(file.Extension, iconForFile);
                }
                item.ImageKey = file.Extension;
                listView1.Items.Add(item);

                //listView1.Items.Add(s[i]);
            }
            listView1.EndUpdate();
        }

        private void box_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.All;
            else
                e.Effect = DragDropEffects.None;
        }
        

        /**
         * ToDO : They are working Only double click...
         * if single click, "mouseOn event" polling...? WHY???????
         */
        private void listView1_MouseDown(object sender, MouseEventArgs e)
        {
            firstPoint = e.Location;
            if (e.Button == MouseButtons.Left) mouseIsDown = true;
            else if (e.Button == MouseButtons.Right) opticalDown = true;

            //ToDo dlg = new ToDo(sender.ToString());
            //dlg.Show();
        }

        private void listView1_MouseMove(object sender, MouseEventArgs e)
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
            else if (opticalDown)
            {
                float xDiff = firstPoint.X - e.Location.X;

                // Set the new point
                //float x = this.Location.X - xDiff;
                this.Opacity += xDiff / 10000;
                if (this.Opacity < .05)
                {
                    this.Opacity = .05;
                }
            }
        }

        private void listView1_MouseUp(object sender, MouseEventArgs e)
        {


            opticalDown = false;
            mouseIsDown = false;
            
        }

        private void box_Load(object sender, EventArgs e)
        {
            imageList1 = new ImageList();
            listView1.LargeImageList = imageList1;
            listView1.View = View.LargeIcon;
        }
    }
}
