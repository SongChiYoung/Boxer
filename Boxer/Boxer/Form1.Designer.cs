namespace Boxer
{
    partial class Boxer
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Boxer));
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.fileFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.terminateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configureCToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.windowWToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpHToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.boxerBToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.server_panel = new System.Windows.Forms.Panel();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.ip_address_label = new System.Windows.Forms.Label();
            this.client_panel = new System.Windows.Forms.Panel();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.run_server = new System.Windows.Forms.Button();
            this.close_server = new System.Windows.Forms.Button();
            this.close_client = new System.Windows.Forms.Button();
            this.run_clinet = new System.Windows.Forms.Button();
            this.menuStrip2.SuspendLayout();
            this.server_panel.SuspendLayout();
            this.client_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileFToolStripMenuItem,
            this.editEToolStripMenuItem,
            this.windowWToolStripMenuItem,
            this.helpHToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(588, 24);
            this.menuStrip2.TabIndex = 1;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // fileFToolStripMenuItem
            // 
            this.fileFToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startSToolStripMenuItem,
            this.terminateToolStripMenuItem});
            this.fileFToolStripMenuItem.Name = "fileFToolStripMenuItem";
            this.fileFToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.fileFToolStripMenuItem.Text = "File (&F)";
            // 
            // startSToolStripMenuItem
            // 
            this.startSToolStripMenuItem.Name = "startSToolStripMenuItem";
            this.startSToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.startSToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.startSToolStripMenuItem.Text = "Start (&S)";
            // 
            // terminateToolStripMenuItem
            // 
            this.terminateToolStripMenuItem.Name = "terminateToolStripMenuItem";
            this.terminateToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.T)));
            this.terminateToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.terminateToolStripMenuItem.Text = "Terminate (&T)";
            // 
            // editEToolStripMenuItem
            // 
            this.editEToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.configureCToolStripMenuItem});
            this.editEToolStripMenuItem.Name = "editEToolStripMenuItem";
            this.editEToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.editEToolStripMenuItem.Text = "Edit (&E)";
            // 
            // configureCToolStripMenuItem
            // 
            this.configureCToolStripMenuItem.Name = "configureCToolStripMenuItem";
            this.configureCToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.configureCToolStripMenuItem.Text = "Configure (&C)";
            this.configureCToolStripMenuItem.Click += new System.EventHandler(this.configureCToolStripMenuItem_Click);
            // 
            // windowWToolStripMenuItem
            // 
            this.windowWToolStripMenuItem.Name = "windowWToolStripMenuItem";
            this.windowWToolStripMenuItem.Size = new System.Drawing.Size(86, 20);
            this.windowWToolStripMenuItem.Text = "Window (&W)";
            // 
            // helpHToolStripMenuItem
            // 
            this.helpHToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.boxerBToolStripMenuItem});
            this.helpHToolStripMenuItem.Name = "helpHToolStripMenuItem";
            this.helpHToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.helpHToolStripMenuItem.Text = "Help (&H)";
            // 
            // boxerBToolStripMenuItem
            // 
            this.boxerBToolStripMenuItem.Name = "boxerBToolStripMenuItem";
            this.boxerBToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.boxerBToolStripMenuItem.Text = "Boxer? (&B)";
            this.boxerBToolStripMenuItem.Click += new System.EventHandler(this.boxerBToolStripMenuItem_Click);
            // 
            // server_panel
            // 
            this.server_panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.server_panel.Controls.Add(this.close_server);
            this.server_panel.Controls.Add(this.run_server);
            this.server_panel.Controls.Add(this.ip_address_label);
            this.server_panel.Controls.Add(this.label1);
            this.server_panel.Location = new System.Drawing.Point(12, 41);
            this.server_panel.Name = "server_panel";
            this.server_panel.Size = new System.Drawing.Size(564, 81);
            this.server_panel.TabIndex = 2;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(23, 33);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(59, 16);
            this.radioButton1.TabIndex = 3;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "&Server";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "IP Address";
            // 
            // ip_address_label
            // 
            this.ip_address_label.AutoSize = true;
            this.ip_address_label.Location = new System.Drawing.Point(94, 10);
            this.ip_address_label.Name = "ip_address_label";
            this.ip_address_label.Size = new System.Drawing.Size(17, 12);
            this.ip_address_label.TabIndex = 1;
            this.ip_address_label.Text = "...";
            // 
            // client_panel
            // 
            this.client_panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.client_panel.Controls.Add(this.close_client);
            this.client_panel.Controls.Add(this.run_clinet);
            this.client_panel.Controls.Add(this.textBox1);
            this.client_panel.Controls.Add(this.label2);
            this.client_panel.Location = new System.Drawing.Point(12, 128);
            this.client_panel.Name = "client_panel";
            this.client_panel.Size = new System.Drawing.Size(564, 81);
            this.client_panel.TabIndex = 3;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(23, 123);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(55, 16);
            this.radioButton2.TabIndex = 4;
            this.radioButton2.Text = "&Client";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "IP Address";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(94, 9);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(449, 21);
            this.textBox1.TabIndex = 2;
            // 
            // run_server
            // 
            this.run_server.Location = new System.Drawing.Point(22, 45);
            this.run_server.Name = "run_server";
            this.run_server.Size = new System.Drawing.Size(257, 23);
            this.run_server.TabIndex = 2;
            this.run_server.Text = "&Run Server";
            this.run_server.UseVisualStyleBackColor = true;
            this.run_server.Click += new System.EventHandler(this.run_server_Click);
            // 
            // close_server
            // 
            this.close_server.Location = new System.Drawing.Point(286, 45);
            this.close_server.Name = "close_server";
            this.close_server.Size = new System.Drawing.Size(257, 23);
            this.close_server.TabIndex = 3;
            this.close_server.Text = "&Close Server";
            this.close_server.UseVisualStyleBackColor = true;
            // 
            // close_client
            // 
            this.close_client.Location = new System.Drawing.Point(286, 44);
            this.close_client.Name = "close_client";
            this.close_client.Size = new System.Drawing.Size(257, 23);
            this.close_client.TabIndex = 5;
            this.close_client.Text = "&Close Client";
            this.close_client.UseVisualStyleBackColor = true;
            // 
            // run_clinet
            // 
            this.run_clinet.Location = new System.Drawing.Point(22, 44);
            this.run_clinet.Name = "run_clinet";
            this.run_clinet.Size = new System.Drawing.Size(257, 23);
            this.run_clinet.TabIndex = 4;
            this.run_clinet.Text = "&Run Client";
            this.run_clinet.UseVisualStyleBackColor = true;
            // 
            // Boxer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 226);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.client_panel);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.server_panel);
            this.Controls.Add(this.menuStrip2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Boxer";
            this.Text = "Boxer";
            this.Load += new System.EventHandler(this.Boxer_Load);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.server_panel.ResumeLayout(false);
            this.server_panel.PerformLayout();
            this.client_panel.ResumeLayout(false);
            this.client_panel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem fileFToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem startSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem windowWToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpHToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem terminateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configureCToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem boxerBToolStripMenuItem;
        private System.Windows.Forms.Panel server_panel;
        private System.Windows.Forms.Label ip_address_label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Button close_server;
        private System.Windows.Forms.Button run_server;
        private System.Windows.Forms.Panel client_panel;
        private System.Windows.Forms.Button close_client;
        private System.Windows.Forms.Button run_clinet;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton radioButton2;
    }
}

