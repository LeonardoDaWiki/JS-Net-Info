namespace JSNetInfo
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pbx_CopyAll = new System.Windows.Forms.PictureBox();
            this.ddl_Language = new System.Windows.Forms.ComboBox();
            this.pbx_DNSServer = new System.Windows.Forms.PictureBox();
            this.txb_DNSServer = new System.Windows.Forms.TextBox();
            this.lbl_DNSServer = new System.Windows.Forms.Label();
            this.pbx_Gateway = new System.Windows.Forms.PictureBox();
            this.pbx_IPAdresse = new System.Windows.Forms.PictureBox();
            this.txb_Gateway = new System.Windows.Forms.TextBox();
            this.lbl_IPAdresse = new System.Windows.Forms.Label();
            this.lbl_Gateway = new System.Windows.Forms.Label();
            this.txb_IPAdresse = new System.Windows.Forms.TextBox();
            this.btn_InfosAuslesen = new System.Windows.Forms.Button();
            this.ttp_ToolTips = new System.Windows.Forms.ToolTip(this.components);
            this.pxb_MACAdresse = new System.Windows.Forms.PictureBox();
            this.txb_MACAdresse = new System.Windows.Forms.TextBox();
            this.lbl_MACAdresse = new System.Windows.Forms.Label();
            this.pbx_Info = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_CopyAll)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_DNSServer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_Gateway)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_IPAdresse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pxb_MACAdresse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_Info)).BeginInit();
            this.SuspendLayout();
            // 
            // pbx_CopyAll
            // 
            this.pbx_CopyAll.BackColor = System.Drawing.Color.Transparent;
            this.pbx_CopyAll.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbx_CopyAll.Image = global::JSNetInfo.Properties.Resources.copy;
            this.pbx_CopyAll.Location = new System.Drawing.Point(429, 38);
            this.pbx_CopyAll.Name = "pbx_CopyAll";
            this.pbx_CopyAll.Size = new System.Drawing.Size(45, 45);
            this.pbx_CopyAll.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx_CopyAll.TabIndex = 39;
            this.pbx_CopyAll.TabStop = false;
            this.ttp_ToolTips.SetToolTip(this.pbx_CopyAll, "Copy all!");
            this.pbx_CopyAll.Click += new System.EventHandler(this.pbx_CopyAll_Click);
            // 
            // ddl_Language
            // 
            this.ddl_Language.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ddl_Language.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddl_Language.FormattingEnabled = true;
            this.ddl_Language.Items.AddRange(new object[] {
            "Deutsch",
            "English"});
            this.ddl_Language.Location = new System.Drawing.Point(12, 122);
            this.ddl_Language.Name = "ddl_Language";
            this.ddl_Language.Size = new System.Drawing.Size(121, 21);
            this.ddl_Language.TabIndex = 38;
            this.ttp_ToolTips.SetToolTip(this.ddl_Language, "Select Language!");
            this.ddl_Language.SelectedIndexChanged += new System.EventHandler(this.ddl_Language_Changed);
            this.ddl_Language.Click += new System.EventHandler(this.ddl_Language_Changed);
            // 
            // pbx_DNSServer
            // 
            this.pbx_DNSServer.BackColor = System.Drawing.Color.Transparent;
            this.pbx_DNSServer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbx_DNSServer.Image = global::JSNetInfo.Properties.Resources.copy;
            this.pbx_DNSServer.Location = new System.Drawing.Point(394, 63);
            this.pbx_DNSServer.Name = "pbx_DNSServer";
            this.pbx_DNSServer.Size = new System.Drawing.Size(20, 20);
            this.pbx_DNSServer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx_DNSServer.TabIndex = 37;
            this.pbx_DNSServer.TabStop = false;
            this.ttp_ToolTips.SetToolTip(this.pbx_DNSServer, "Copy DNS server!");
            this.pbx_DNSServer.Click += new System.EventHandler(this.pbx_DNSServer_Click);
            // 
            // txb_DNSServer
            // 
            this.txb_DNSServer.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txb_DNSServer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_DNSServer.Location = new System.Drawing.Point(144, 61);
            this.txb_DNSServer.Margin = new System.Windows.Forms.Padding(2);
            this.txb_DNSServer.Name = "txb_DNSServer";
            this.txb_DNSServer.Size = new System.Drawing.Size(245, 20);
            this.txb_DNSServer.TabIndex = 36;
            // 
            // lbl_DNSServer
            // 
            this.lbl_DNSServer.AutoSize = true;
            this.lbl_DNSServer.BackColor = System.Drawing.Color.Transparent;
            this.lbl_DNSServer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DNSServer.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_DNSServer.Location = new System.Drawing.Point(12, 65);
            this.lbl_DNSServer.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_DNSServer.Name = "lbl_DNSServer";
            this.lbl_DNSServer.Size = new System.Drawing.Size(78, 13);
            this.lbl_DNSServer.TabIndex = 35;
            this.lbl_DNSServer.Text = "DNS-Server:";
            // 
            // pbx_Gateway
            // 
            this.pbx_Gateway.BackColor = System.Drawing.Color.Transparent;
            this.pbx_Gateway.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbx_Gateway.Image = global::JSNetInfo.Properties.Resources.copy;
            this.pbx_Gateway.Location = new System.Drawing.Point(394, 38);
            this.pbx_Gateway.Name = "pbx_Gateway";
            this.pbx_Gateway.Size = new System.Drawing.Size(20, 20);
            this.pbx_Gateway.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx_Gateway.TabIndex = 34;
            this.pbx_Gateway.TabStop = false;
            this.ttp_ToolTips.SetToolTip(this.pbx_Gateway, "Copy Gateway!");
            this.pbx_Gateway.Click += new System.EventHandler(this.pxb_Gateway_Click);
            // 
            // pbx_IPAdresse
            // 
            this.pbx_IPAdresse.BackColor = System.Drawing.Color.Transparent;
            this.pbx_IPAdresse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbx_IPAdresse.Image = global::JSNetInfo.Properties.Resources.copy;
            this.pbx_IPAdresse.Location = new System.Drawing.Point(394, 13);
            this.pbx_IPAdresse.Name = "pbx_IPAdresse";
            this.pbx_IPAdresse.Size = new System.Drawing.Size(20, 20);
            this.pbx_IPAdresse.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx_IPAdresse.TabIndex = 33;
            this.pbx_IPAdresse.TabStop = false;
            this.ttp_ToolTips.SetToolTip(this.pbx_IPAdresse, "Copy IP address!");
            this.pbx_IPAdresse.Click += new System.EventHandler(this.pxb_IPAdresse_Click);
            // 
            // txb_Gateway
            // 
            this.txb_Gateway.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txb_Gateway.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_Gateway.Location = new System.Drawing.Point(144, 36);
            this.txb_Gateway.Margin = new System.Windows.Forms.Padding(2);
            this.txb_Gateway.Name = "txb_Gateway";
            this.txb_Gateway.Size = new System.Drawing.Size(245, 20);
            this.txb_Gateway.TabIndex = 32;
            // 
            // lbl_IPAdresse
            // 
            this.lbl_IPAdresse.AutoSize = true;
            this.lbl_IPAdresse.BackColor = System.Drawing.Color.Transparent;
            this.lbl_IPAdresse.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_IPAdresse.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_IPAdresse.Location = new System.Drawing.Point(11, 14);
            this.lbl_IPAdresse.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_IPAdresse.Name = "lbl_IPAdresse";
            this.lbl_IPAdresse.Size = new System.Drawing.Size(72, 13);
            this.lbl_IPAdresse.TabIndex = 31;
            this.lbl_IPAdresse.Text = "IP-Adresse:";
            // 
            // lbl_Gateway
            // 
            this.lbl_Gateway.AutoSize = true;
            this.lbl_Gateway.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Gateway.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Gateway.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_Gateway.Location = new System.Drawing.Point(12, 40);
            this.lbl_Gateway.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Gateway.Name = "lbl_Gateway";
            this.lbl_Gateway.Size = new System.Drawing.Size(56, 13);
            this.lbl_Gateway.TabIndex = 30;
            this.lbl_Gateway.Text = "Gateway";
            // 
            // txb_IPAdresse
            // 
            this.txb_IPAdresse.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txb_IPAdresse.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_IPAdresse.Location = new System.Drawing.Point(144, 11);
            this.txb_IPAdresse.Margin = new System.Windows.Forms.Padding(2);
            this.txb_IPAdresse.Name = "txb_IPAdresse";
            this.txb_IPAdresse.Size = new System.Drawing.Size(245, 20);
            this.txb_IPAdresse.TabIndex = 29;
            // 
            // btn_InfosAuslesen
            // 
            this.btn_InfosAuslesen.BackColor = System.Drawing.SystemColors.MenuBar;
            this.btn_InfosAuslesen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_InfosAuslesen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_InfosAuslesen.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_InfosAuslesen.Location = new System.Drawing.Point(393, 124);
            this.btn_InfosAuslesen.Margin = new System.Windows.Forms.Padding(2);
            this.btn_InfosAuslesen.Name = "btn_InfosAuslesen";
            this.btn_InfosAuslesen.Size = new System.Drawing.Size(75, 23);
            this.btn_InfosAuslesen.TabIndex = 28;
            this.btn_InfosAuslesen.Text = "erneuern...";
            this.ttp_ToolTips.SetToolTip(this.btn_InfosAuslesen, "Refresh Data!");
            this.btn_InfosAuslesen.UseVisualStyleBackColor = false;
            this.btn_InfosAuslesen.Click += new System.EventHandler(this.btn_InfosAuslesen_Click);
            // 
            // pxb_MACAdresse
            // 
            this.pxb_MACAdresse.BackColor = System.Drawing.Color.Transparent;
            this.pxb_MACAdresse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pxb_MACAdresse.Image = global::JSNetInfo.Properties.Resources.copy;
            this.pxb_MACAdresse.Location = new System.Drawing.Point(394, 89);
            this.pxb_MACAdresse.Name = "pxb_MACAdresse";
            this.pxb_MACAdresse.Size = new System.Drawing.Size(20, 20);
            this.pxb_MACAdresse.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pxb_MACAdresse.TabIndex = 42;
            this.pxb_MACAdresse.TabStop = false;
            this.ttp_ToolTips.SetToolTip(this.pxb_MACAdresse, "Copy MAC address!");
            this.pxb_MACAdresse.Click += new System.EventHandler(this.pbx_MACAdresse_Click);
            // 
            // txb_MACAdresse
            // 
            this.txb_MACAdresse.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txb_MACAdresse.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_MACAdresse.Location = new System.Drawing.Point(144, 87);
            this.txb_MACAdresse.Margin = new System.Windows.Forms.Padding(2);
            this.txb_MACAdresse.Name = "txb_MACAdresse";
            this.txb_MACAdresse.Size = new System.Drawing.Size(245, 20);
            this.txb_MACAdresse.TabIndex = 41;
            // 
            // lbl_MACAdresse
            // 
            this.lbl_MACAdresse.AutoSize = true;
            this.lbl_MACAdresse.BackColor = System.Drawing.Color.Transparent;
            this.lbl_MACAdresse.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_MACAdresse.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_MACAdresse.Location = new System.Drawing.Point(12, 91);
            this.lbl_MACAdresse.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_MACAdresse.Name = "lbl_MACAdresse";
            this.lbl_MACAdresse.Size = new System.Drawing.Size(86, 13);
            this.lbl_MACAdresse.TabIndex = 40;
            this.lbl_MACAdresse.Text = "MAC-Adresse:";
            // 
            // pbx_Info
            // 
            this.pbx_Info.BackColor = System.Drawing.Color.Transparent;
            this.pbx_Info.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbx_Info.Image = global::JSNetInfo.Properties.Resources.information_icon_white;
            this.pbx_Info.Location = new System.Drawing.Point(144, 122);
            this.pbx_Info.Name = "pbx_Info";
            this.pbx_Info.Size = new System.Drawing.Size(21, 21);
            this.pbx_Info.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx_Info.TabIndex = 43;
            this.pbx_Info.TabStop = false;
            this.pbx_Info.Click += new System.EventHandler(this.pbx_Info_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::JSNetInfo.Properties.Resources.background_blue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(484, 161);
            this.Controls.Add(this.pbx_Info);
            this.Controls.Add(this.pbx_CopyAll);
            this.Controls.Add(this.ddl_Language);
            this.Controls.Add(this.pbx_DNSServer);
            this.Controls.Add(this.txb_DNSServer);
            this.Controls.Add(this.lbl_DNSServer);
            this.Controls.Add(this.pbx_Gateway);
            this.Controls.Add(this.pbx_IPAdresse);
            this.Controls.Add(this.txb_Gateway);
            this.Controls.Add(this.lbl_IPAdresse);
            this.Controls.Add(this.lbl_Gateway);
            this.Controls.Add(this.txb_IPAdresse);
            this.Controls.Add(this.btn_InfosAuslesen);
            this.Controls.Add(this.pxb_MACAdresse);
            this.Controls.Add(this.txb_MACAdresse);
            this.Controls.Add(this.lbl_MACAdresse);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "JSNetInfo";
            ((System.ComponentModel.ISupportInitialize)(this.pbx_CopyAll)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_DNSServer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_Gateway)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_IPAdresse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pxb_MACAdresse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_Info)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbx_CopyAll;
        private System.Windows.Forms.ToolTip ttp_ToolTips;
        private System.Windows.Forms.ComboBox ddl_Language;
        private System.Windows.Forms.PictureBox pbx_DNSServer;
        private System.Windows.Forms.TextBox txb_DNSServer;
        private System.Windows.Forms.Label lbl_DNSServer;
        private System.Windows.Forms.PictureBox pbx_Gateway;
        private System.Windows.Forms.PictureBox pbx_IPAdresse;
        private System.Windows.Forms.TextBox txb_Gateway;
        private System.Windows.Forms.Label lbl_IPAdresse;
        private System.Windows.Forms.Label lbl_Gateway;
        private System.Windows.Forms.TextBox txb_IPAdresse;
        private System.Windows.Forms.Button btn_InfosAuslesen;
        private System.Windows.Forms.PictureBox pxb_MACAdresse;
        private System.Windows.Forms.TextBox txb_MACAdresse;
        private System.Windows.Forms.Label lbl_MACAdresse;
        private System.Windows.Forms.PictureBox pbx_Info;
    }
}

