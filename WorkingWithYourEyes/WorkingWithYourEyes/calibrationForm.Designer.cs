namespace WorkingWithYourEyes
{
    partial class calibrationForm
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
            this.btnStartCal = new System.Windows.Forms.Button();
            this.pictBoxCal1 = new System.Windows.Forms.PictureBox();
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
            // btnStartCal
            // 
            this.btnStartCal.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnStartCal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStartCal.FlatAppearance.BorderSize = 3;
            this.btnStartCal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStartCal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnStartCal.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnStartCal.Location = new System.Drawing.Point(513, 73);
            this.btnStartCal.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnStartCal.MaximumSize = new System.Drawing.Size(229, 107);
            this.btnStartCal.Name = "btnStartCal";
            this.btnStartCal.Size = new System.Drawing.Size(229, 107);
            this.btnStartCal.TabIndex = 2;
            this.btnStartCal.Text = "START CALIBRATION";
            this.btnStartCal.UseVisualStyleBackColor = true;
            this.btnStartCal.Click += new System.EventHandler(this.btnStartCal_Click);
            // 
            // pictBoxCal1
            // 
            this.pictBoxCal1.Location = new System.Drawing.Point(586, 324);
            this.pictBoxCal1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictBoxCal1.Name = "pictBoxCal1";
            this.pictBoxCal1.Size = new System.Drawing.Size(171, 200);
            this.pictBoxCal1.TabIndex = 3;
            this.pictBoxCal1.TabStop = false;
            // 
            // pictBoxCal2
            // 
            this.pictBoxCal2.Location = new System.Drawing.Point(594, 332);
            this.pictBoxCal2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictBoxCal2.Name = "pictBoxCal2";
            this.pictBoxCal2.Size = new System.Drawing.Size(171, 200);
            this.pictBoxCal2.TabIndex = 4;
            this.pictBoxCal2.TabStop = false;
            // 
            // pictBoxCal3
            // 
            this.pictBoxCal3.Location = new System.Drawing.Point(602, 340);
            this.pictBoxCal3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictBoxCal3.Name = "pictBoxCal3";
            this.pictBoxCal3.Size = new System.Drawing.Size(171, 200);
            this.pictBoxCal3.TabIndex = 5;
            this.pictBoxCal3.TabStop = false;
            // 
            // pictBoxCal4
            // 
            this.pictBoxCal4.Location = new System.Drawing.Point(610, 348);
            this.pictBoxCal4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictBoxCal4.Name = "pictBoxCal4";
            this.pictBoxCal4.Size = new System.Drawing.Size(171, 200);
            this.pictBoxCal4.TabIndex = 6;
            this.pictBoxCal4.TabStop = false;
            // 
            // pictBoxCal5
            // 
            this.pictBoxCal5.Location = new System.Drawing.Point(618, 356);
            this.pictBoxCal5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictBoxCal5.Name = "pictBoxCal5";
            this.pictBoxCal5.Size = new System.Drawing.Size(171, 200);
            this.pictBoxCal5.TabIndex = 7;
            this.pictBoxCal5.TabStop = false;
            // 
            // calibrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(1342, 848);
            this.Controls.Add(this.pictBoxCal5);
            this.Controls.Add(this.pictBoxCal4);
            this.Controls.Add(this.pictBoxCal3);
            this.Controls.Add(this.pictBoxCal2);
            this.Controls.Add(this.pictBoxCal1);
            this.Controls.Add(this.btnStartCal);
            this.Name = "calibrationForm";
            this.Text = "calibrationForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictBoxCal1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictBoxCal2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictBoxCal3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictBoxCal4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictBoxCal5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnStartCal;
        private PictureBox pictBoxCal1;
        private PictureBox pictBoxCal2;
        private PictureBox pictBoxCal3;
        private PictureBox pictBoxCal4;
        private PictureBox pictBoxCal5;
    }
}