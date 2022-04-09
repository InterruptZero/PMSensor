
namespace PMStenthree
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pm10lb = new System.Windows.Forms.Label();
            this.pm10bg = new System.Windows.Forms.PictureBox();
            this.pm25lb = new System.Windows.Forms.Label();
            this.pm25bg = new System.Windows.Forms.PictureBox();
            this.pmtenlb = new System.Windows.Forms.Label();
            this.pmtenbg = new System.Windows.Forms.PictureBox();
            this.cntckb = new System.Windows.Forms.CheckBox();
            this.portcb = new System.Windows.Forms.ComboBox();
            this.Connectbtn = new System.Windows.Forms.Button();
            this.Debuglb = new System.Windows.Forms.Label();
            this.pm10aqi = new System.Windows.Forms.Label();
            this.pm25aqi = new System.Windows.Forms.Label();
            this.pmtenaqi = new System.Windows.Forms.Label();
            this.waycb = new System.Windows.Forms.ComboBox();
            this.lbsp = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pm10bg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pm25bg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pmtenbg)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(260, 124);
            this.label1.TabIndex = 0;
            this.label1.Text = "PMS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(253, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "1003";
            // 
            // pm10lb
            // 
            this.pm10lb.AutoSize = true;
            this.pm10lb.BackColor = System.Drawing.Color.AntiqueWhite;
            this.pm10lb.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.pm10lb.Location = new System.Drawing.Point(306, 164);
            this.pm10lb.Name = "pm10lb";
            this.pm10lb.Size = new System.Drawing.Size(138, 22);
            this.pm10lb.TabIndex = 2;
            this.pm10lb.Text = "PM1.0    --------";
            // 
            // pm10bg
            // 
            this.pm10bg.Image = global::PMStenthree.Properties.Resources.what;
            this.pm10bg.Location = new System.Drawing.Point(-2, 151);
            this.pm10bg.Name = "pm10bg";
            this.pm10bg.Size = new System.Drawing.Size(800, 50);
            this.pm10bg.TabIndex = 3;
            this.pm10bg.TabStop = false;
            // 
            // pm25lb
            // 
            this.pm25lb.AutoSize = true;
            this.pm25lb.BackColor = System.Drawing.Color.AntiqueWhite;
            this.pm25lb.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.pm25lb.Location = new System.Drawing.Point(306, 218);
            this.pm25lb.Name = "pm25lb";
            this.pm25lb.Size = new System.Drawing.Size(138, 22);
            this.pm25lb.TabIndex = 4;
            this.pm25lb.Text = "PM2.5    --------";
            // 
            // pm25bg
            // 
            this.pm25bg.Image = global::PMStenthree.Properties.Resources.what;
            this.pm25bg.Location = new System.Drawing.Point(-12, 207);
            this.pm25bg.Name = "pm25bg";
            this.pm25bg.Size = new System.Drawing.Size(800, 50);
            this.pm25bg.TabIndex = 5;
            this.pm25bg.TabStop = false;
            // 
            // pmtenlb
            // 
            this.pmtenlb.AutoSize = true;
            this.pmtenlb.BackColor = System.Drawing.Color.AntiqueWhite;
            this.pmtenlb.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.pmtenlb.Location = new System.Drawing.Point(306, 276);
            this.pmtenlb.Name = "pmtenlb";
            this.pmtenlb.Size = new System.Drawing.Size(138, 22);
            this.pmtenlb.TabIndex = 6;
            this.pmtenlb.Text = "PM1 0    --------";
            // 
            // pmtenbg
            // 
            this.pmtenbg.Image = global::PMStenthree.Properties.Resources.what;
            this.pmtenbg.Location = new System.Drawing.Point(-2, 263);
            this.pmtenbg.Name = "pmtenbg";
            this.pmtenbg.Size = new System.Drawing.Size(800, 50);
            this.pmtenbg.TabIndex = 7;
            this.pmtenbg.TabStop = false;
            // 
            // cntckb
            // 
            this.cntckb.AutoSize = true;
            this.cntckb.Enabled = false;
            this.cntckb.Location = new System.Drawing.Point(12, 320);
            this.cntckb.Name = "cntckb";
            this.cntckb.Size = new System.Drawing.Size(89, 21);
            this.cntckb.TabIndex = 8;
            this.cntckb.Text = "Connected";
            this.cntckb.UseVisualStyleBackColor = true;
            // 
            // portcb
            // 
            this.portcb.FormattingEnabled = true;
            this.portcb.Location = new System.Drawing.Point(12, 338);
            this.portcb.Name = "portcb";
            this.portcb.Size = new System.Drawing.Size(121, 25);
            this.portcb.TabIndex = 9;
            // 
            // Connectbtn
            // 
            this.Connectbtn.Location = new System.Drawing.Point(12, 369);
            this.Connectbtn.Name = "Connectbtn";
            this.Connectbtn.Size = new System.Drawing.Size(75, 23);
            this.Connectbtn.TabIndex = 10;
            this.Connectbtn.Text = "Connect";
            this.Connectbtn.UseVisualStyleBackColor = true;
            this.Connectbtn.Click += new System.EventHandler(this.Connectbtn_Click);
            // 
            // Debuglb
            // 
            this.Debuglb.AutoSize = true;
            this.Debuglb.Location = new System.Drawing.Point(12, 435);
            this.Debuglb.Name = "Debuglb";
            this.Debuglb.Size = new System.Drawing.Size(44, 17);
            this.Debuglb.TabIndex = 11;
            this.Debuglb.Text = "Ready";
            // 
            // pm10aqi
            // 
            this.pm10aqi.AutoSize = true;
            this.pm10aqi.BackColor = System.Drawing.Color.AntiqueWhite;
            this.pm10aqi.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.pm10aqi.Location = new System.Drawing.Point(543, 164);
            this.pm10aqi.Name = "pm10aqi";
            this.pm10aqi.Size = new System.Drawing.Size(116, 22);
            this.pm10aqi.TabIndex = 12;
            this.pm10aqi.Text = "AQI    --------";
            // 
            // pm25aqi
            // 
            this.pm25aqi.AutoSize = true;
            this.pm25aqi.BackColor = System.Drawing.Color.AntiqueWhite;
            this.pm25aqi.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.pm25aqi.Location = new System.Drawing.Point(543, 218);
            this.pm25aqi.Name = "pm25aqi";
            this.pm25aqi.Size = new System.Drawing.Size(116, 22);
            this.pm25aqi.TabIndex = 13;
            this.pm25aqi.Text = "AQI    --------";
            // 
            // pmtenaqi
            // 
            this.pmtenaqi.AutoSize = true;
            this.pmtenaqi.BackColor = System.Drawing.Color.AntiqueWhite;
            this.pmtenaqi.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.pmtenaqi.Location = new System.Drawing.Point(543, 276);
            this.pmtenaqi.Name = "pmtenaqi";
            this.pmtenaqi.Size = new System.Drawing.Size(116, 22);
            this.pmtenaqi.TabIndex = 14;
            this.pmtenaqi.Text = "AQI    --------";
            // 
            // waycb
            // 
            this.waycb.FormattingEnabled = true;
            this.waycb.Location = new System.Drawing.Point(12, 399);
            this.waycb.Name = "waycb";
            this.waycb.Size = new System.Drawing.Size(75, 25);
            this.waycb.TabIndex = 15;
            // 
            // lbsp
            // 
            this.lbsp.AutoSize = true;
            this.lbsp.Location = new System.Drawing.Point(140, 345);
            this.lbsp.Name = "lbsp";
            this.lbsp.Size = new System.Drawing.Size(69, 17);
            this.lbsp.TabIndex = 16;
            this.lbsp.Text = "Serial port";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(94, 406);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 17);
            this.label3.TabIndex = 17;
            this.label3.Text = "Detect Ways";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbsp);
            this.Controls.Add(this.waycb);
            this.Controls.Add(this.pmtenaqi);
            this.Controls.Add(this.pm25aqi);
            this.Controls.Add(this.pm10aqi);
            this.Controls.Add(this.Debuglb);
            this.Controls.Add(this.Connectbtn);
            this.Controls.Add(this.portcb);
            this.Controls.Add(this.cntckb);
            this.Controls.Add(this.pmtenlb);
            this.Controls.Add(this.pmtenbg);
            this.Controls.Add(this.pm25lb);
            this.Controls.Add(this.pm25bg);
            this.Controls.Add(this.pm10lb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pm10bg);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pm10bg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pm25bg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pmtenbg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label pm10lb;
        private System.Windows.Forms.PictureBox pm10bg;
        private System.Windows.Forms.Label pm25lb;
        private System.Windows.Forms.PictureBox pm25bg;
        private System.Windows.Forms.Label pmtenlb;
        private System.Windows.Forms.PictureBox pmtenbg;
        private System.Windows.Forms.CheckBox cntckb;
        private System.Windows.Forms.ComboBox portcb;
        private System.Windows.Forms.Button Connectbtn;
        private System.Windows.Forms.Label Debuglb;
        private System.Windows.Forms.Label pm10aqi;
        private System.Windows.Forms.Label pm25aqi;
        private System.Windows.Forms.Label pmtenaqi;
        private System.Windows.Forms.ComboBox waycb;
        private System.Windows.Forms.Label lbsp;
        private System.Windows.Forms.Label label3;
    }
}

