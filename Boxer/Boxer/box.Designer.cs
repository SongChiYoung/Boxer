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
            this.SuspendLayout();
            // 
            // box
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.ClientSize = new System.Drawing.Size(289, 261);
            this.ControlBox = false;
            this.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.Name = "box";
            this.Opacity = 0.5D;
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.box_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.box_DragEnter);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.box_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.box_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.box_MouseUp);
            this.ResumeLayout(false);

        }

        #endregion
    }
}