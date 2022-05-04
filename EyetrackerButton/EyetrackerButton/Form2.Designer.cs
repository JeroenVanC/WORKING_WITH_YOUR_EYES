
namespace EyetrackerButton
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
            this.pictBoxCal1 = new System.Windows.Forms.PictureBox();
            this.btnStartCal = new System.Windows.Forms.Button();
            this.btnStopCal = new System.Windows.Forms.Button();
            this.pictBoxCal2 = new System.Windows.Forms.PictureBox();
            this.pictBoxCal3 = new System.Windows.Forms.PictureBox();
            this.pictBoxCal4 = new System.Windows.Forms.PictureBox();
            this.pictBoxCal5 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictBoxCal1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictBoxCal2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictBoxCal3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictBoxCal4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictBoxCal5)).BeginInit();
            this.SuspendLayout();
            // 
            // pictBoxCal1
            // 
            this.pictBoxCal1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictBoxCal1.BackColor = System.Drawing.Color.Transparent;
            this.pictBoxCal1.Location = new System.Drawing.Point(479, 30);
            this.pictBoxCal1.Margin = new System.Windows.Forms.Padding(2);
            this.pictBoxCal1.Name = "pictBoxCal1";
            this.pictBoxCal1.Size = new System.Drawing.Size(150, 150);
            this.pictBoxCal1.TabIndex = 0;
            this.pictBoxCal1.TabStop = false;
            this.pictBoxCal1.Click += new System.EventHandler(this.pictBoxCalibration_Click);
            // 
            // btnStartCal
            // 
            this.btnStartCal.Location = new System.Drawing.Point(14, 14);
            this.btnStartCal.Name = "btnStartCal";
            this.btnStartCal.Size = new System.Drawing.Size(100, 23);
            this.btnStartCal.TabIndex = 1;
            this.btnStartCal.Text = "Start Calibration";
            this.btnStartCal.UseVisualStyleBackColor = true;
            this.btnStartCal.Click += new System.EventHandler(this.btnStartCal_Click);
            // 
            // btnStopCal
            // 
            this.btnStopCal.Location = new System.Drawing.Point(14, 44);
            this.btnStopCal.Name = "btnStopCal";
            this.btnStopCal.Size = new System.Drawing.Size(101, 23);
            this.btnStopCal.TabIndex = 2;
            this.btnStopCal.Text = "Stop Calibration";
            this.btnStopCal.UseVisualStyleBackColor = true;
            this.btnStopCal.Click += new System.EventHandler(this.btnStopCal_Click);
            // 
            // pictBoxCal2
            // 
            this.pictBoxCal2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictBoxCal2.Location = new System.Drawing.Point(479, 30);
            this.pictBoxCal2.Name = "pictBoxCal2";
            this.pictBoxCal2.Size = new System.Drawing.Size(150, 150);
            this.pictBoxCal2.TabIndex = 3;
            this.pictBoxCal2.TabStop = false;
            this.pictBoxCal2.Click += new System.EventHandler(this.pictBoxCal2_Click);
            // 
            // pictBoxCal3
            // 
            this.pictBoxCal3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictBoxCal3.Location = new System.Drawing.Point(479, 30);
            this.pictBoxCal3.Name = "pictBoxCal3";
            this.pictBoxCal3.Size = new System.Drawing.Size(150, 150);
            this.pictBoxCal3.TabIndex = 4;
            this.pictBoxCal3.TabStop = false;
            this.pictBoxCal3.Click += new System.EventHandler(this.pictBoxCal3_Click);
            // 
            // pictBoxCal4
            // 
            this.pictBoxCal4.Location = new System.Drawing.Point(479, 30);
            this.pictBoxCal4.Name = "pictBoxCal4";
            this.pictBoxCal4.Size = new System.Drawing.Size(150, 150);
            this.pictBoxCal4.TabIndex = 5;
            this.pictBoxCal4.TabStop = false;
            this.pictBoxCal4.Click += new System.EventHandler(this.pictBoxCal4_Click);
            // 
            // pictBoxCal5
            // 
            this.pictBoxCal5.Location = new System.Drawing.Point(479, 30);
            this.pictBoxCal5.Name = "pictBoxCal5";
            this.pictBoxCal5.Size = new System.Drawing.Size(150, 150);
            this.pictBoxCal5.TabIndex = 6;
            this.pictBoxCal5.TabStop = false;
            this.pictBoxCal5.Click += new System.EventHandler(this.pictBoxCal5_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1824, 679);
            this.Controls.Add(this.pictBoxCal5);
            this.Controls.Add(this.pictBoxCal4);
            this.Controls.Add(this.pictBoxCal3);
            this.Controls.Add(this.pictBoxCal2);
            this.Controls.Add(this.btnStopCal);
            this.Controls.Add(this.btnStartCal);
            this.Controls.Add(this.pictBoxCal1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.pictBoxCal1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictBoxCal2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictBoxCal3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictBoxCal4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictBoxCal5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictBoxCal1;
        private System.Windows.Forms.Button btnStartCal;
        private System.Windows.Forms.Button btnStopCal;
        private System.Windows.Forms.PictureBox pictBoxCal2;
        private System.Windows.Forms.PictureBox pictBoxCal3;
        private System.Windows.Forms.PictureBox pictBoxCal4;
        private System.Windows.Forms.PictureBox pictBoxCal5;
    }
}