namespace Hawk_Client {
    partial class ConfigWindow {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConfigWindow));
            this.mainBrowser = new System.Windows.Forms.WebBrowser();
            this.title = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.prevButton = new System.Windows.Forms.Button();
            this.nextButton = new System.Windows.Forms.Button();
            this.setConfigButton = new System.Windows.Forms.Button();
            this.addPtButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.DoneButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // mainBrowser
            // 
            this.mainBrowser.Location = new System.Drawing.Point(640, 29);
            this.mainBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.mainBrowser.Name = "mainBrowser";
            this.mainBrowser.ScrollBarsEnabled = false;
            this.mainBrowser.Size = new System.Drawing.Size(613, 495);
            this.mainBrowser.TabIndex = 4;
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.title.ForeColor = System.Drawing.Color.White;
            this.title.Location = new System.Drawing.Point(29, 55);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(191, 52);
            this.title.TabIndex = 5;
            this.title.Text = "What Should I do?\r\n\r\n";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(34, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(409, 140);
            this.label1.TabIndex = 6;
            this.label1.Text = "1. choose the most accurate target\r\n(Use the buttons to navigate)\r\n\r\n2. press set" +
    " Config\r\n\r\n3. travel accrost the field, \r\neach time you see that target acquired" +
    ", press \"add point\"";
            // 
            // prevButton
            // 
            this.prevButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(115)))), ((int)(((byte)(112)))));
            this.prevButton.FlatAppearance.BorderSize = 0;
            this.prevButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.prevButton.Location = new System.Drawing.Point(117, 295);
            this.prevButton.Name = "prevButton";
            this.prevButton.Size = new System.Drawing.Size(75, 23);
            this.prevButton.TabIndex = 8;
            this.prevButton.Text = "Previous";
            this.prevButton.UseVisualStyleBackColor = false;
            this.prevButton.Click += new System.EventHandler(this.prev_click);
            // 
            // nextButton
            // 
            this.nextButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(115)))), ((int)(((byte)(112)))));
            this.nextButton.FlatAppearance.BorderSize = 0;
            this.nextButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nextButton.Location = new System.Drawing.Point(207, 295);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(75, 23);
            this.nextButton.TabIndex = 8;
            this.nextButton.Text = "Next";
            this.nextButton.UseVisualStyleBackColor = false;
            this.nextButton.Click += new System.EventHandler(this.next_click);
            // 
            // setConfigButton
            // 
            this.setConfigButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(115)))), ((int)(((byte)(112)))));
            this.setConfigButton.FlatAppearance.BorderSize = 0;
            this.setConfigButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.setConfigButton.Location = new System.Drawing.Point(292, 295);
            this.setConfigButton.Name = "setConfigButton";
            this.setConfigButton.Size = new System.Drawing.Size(75, 23);
            this.setConfigButton.TabIndex = 8;
            this.setConfigButton.Text = "Set Config";
            this.setConfigButton.UseVisualStyleBackColor = false;
            this.setConfigButton.Click += new System.EventHandler(this.setConf_click);
            // 
            // addPtButton
            // 
            this.addPtButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(115)))), ((int)(((byte)(112)))));
            this.addPtButton.FlatAppearance.BorderSize = 0;
            this.addPtButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addPtButton.Location = new System.Drawing.Point(377, 295);
            this.addPtButton.Name = "addPtButton";
            this.addPtButton.Size = new System.Drawing.Size(75, 23);
            this.addPtButton.TabIndex = 8;
            this.addPtButton.Text = "Add Point";
            this.addPtButton.UseVisualStyleBackColor = false;
            this.addPtButton.Click += new System.EventHandler(this.addPt_click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = global::Hawk_Client.Properties.Resources.HawkEye1;
            this.pictureBox1.InitialImage = global::Hawk_Client.Properties.Resources.HawkEye1;
            this.pictureBox1.Location = new System.Drawing.Point(432, 44);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(155, 148);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // DoneButton
            // 
            this.DoneButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(115)))), ((int)(((byte)(112)))));
            this.DoneButton.FlatAppearance.BorderSize = 0;
            this.DoneButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DoneButton.Location = new System.Drawing.Point(1156, 544);
            this.DoneButton.Name = "DoneButton";
            this.DoneButton.Size = new System.Drawing.Size(75, 23);
            this.DoneButton.TabIndex = 8;
            this.DoneButton.Text = "Done!";
            this.DoneButton.UseVisualStyleBackColor = false;
            this.DoneButton.Click += new System.EventHandler(this.button_done_clicked);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(31, 343);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "console";
            // 
            // ConfigWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.ClientSize = new System.Drawing.Size(1284, 579);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.DoneButton);
            this.Controls.Add(this.addPtButton);
            this.Controls.Add(this.setConfigButton);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.prevButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.title);
            this.Controls.Add(this.mainBrowser);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ConfigWindow";
            this.Text = "Configuration";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.WebBrowser mainBrowser;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button prevButton;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.Button setConfigButton;
        private System.Windows.Forms.Button addPtButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button DoneButton;
        private System.Windows.Forms.Label label2;
    }
}