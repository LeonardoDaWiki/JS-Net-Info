namespace JSNetInfo
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.lbl_CopyRight = new System.Windows.Forms.Label();
            this.lbl_German = new System.Windows.Forms.Label();
            this.lbl_English = new System.Windows.Forms.Label();
            this.btn_OK = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_CopyRight
            // 
            this.lbl_CopyRight.AutoSize = true;
            this.lbl_CopyRight.BackColor = System.Drawing.Color.Transparent;
            this.lbl_CopyRight.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_CopyRight.Location = new System.Drawing.Point(13, 96);
            this.lbl_CopyRight.Name = "lbl_CopyRight";
            this.lbl_CopyRight.Size = new System.Drawing.Size(195, 13);
            this.lbl_CopyRight.TabIndex = 0;
            this.lbl_CopyRight.Text = "© Copyright 2017 by Jonathan Switinski";
            // 
            // lbl_German
            // 
            this.lbl_German.AutoSize = true;
            this.lbl_German.BackColor = System.Drawing.Color.Transparent;
            this.lbl_German.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_German.Location = new System.Drawing.Point(13, 13);
            this.lbl_German.Name = "lbl_German";
            this.lbl_German.Size = new System.Drawing.Size(315, 13);
            this.lbl_German.TabIndex = 1;
            this.lbl_German.Text = "Dieses Programm ist für den freien Gebrauch bestimmt. Viel Spaß.";
            // 
            // lbl_English
            // 
            this.lbl_English.AutoSize = true;
            this.lbl_English.BackColor = System.Drawing.Color.Transparent;
            this.lbl_English.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_English.Location = new System.Drawing.Point(13, 36);
            this.lbl_English.Name = "lbl_English";
            this.lbl_English.Size = new System.Drawing.Size(232, 13);
            this.lbl_English.TabIndex = 2;
            this.lbl_English.Text = "This programm was build for free use. Have fun.";
            // 
            // btn_OK
            // 
            this.btn_OK.BackColor = System.Drawing.SystemColors.MenuBar;
            this.btn_OK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_OK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_OK.Location = new System.Drawing.Point(397, 86);
            this.btn_OK.Margin = new System.Windows.Forms.Padding(2);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Size = new System.Drawing.Size(75, 23);
            this.btn_OK.TabIndex = 3;
            this.btn_OK.Text = "OK";
            this.btn_OK.UseVisualStyleBackColor = false;
            this.btn_OK.Click += new System.EventHandler(this.btn_OK_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::JSNetInfo.Properties.Resources.Ethernet_Cable_icon;
            this.pictureBox1.Location = new System.Drawing.Point(397, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(75, 75);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::JSNetInfo.Properties.Resources.background_blue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(484, 121);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_OK);
            this.Controls.Add(this.lbl_English);
            this.Controls.Add(this.lbl_German);
            this.Controls.Add(this.lbl_CopyRight);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Info";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_CopyRight;
        private System.Windows.Forms.Label lbl_German;
        private System.Windows.Forms.Label lbl_English;
        private System.Windows.Forms.Button btn_OK;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}