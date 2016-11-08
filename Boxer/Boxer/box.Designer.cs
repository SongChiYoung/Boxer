namespace Boxer
{
    partial class box
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listView1 = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.SystemColors.Control;
            this.listView1.ForeColor = System.Drawing.SystemColors.MenuText;
            this.listView1.Location = new System.Drawing.Point(1, 36);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(289, 226);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseDown);
            this.listView1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseMove);
            this.listView1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseUp);
            // 
            // box
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.ClientSize = new System.Drawing.Size(289, 261);
            this.ControlBox = false;
            this.Controls.Add(this.listView1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.Name = "box";
            this.Opacity = 0.5D;
            this.Load += new System.EventHandler(this.box_Load);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.box_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.box_DragEnter);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.box_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.box_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.box_MouseUp);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
    }
}