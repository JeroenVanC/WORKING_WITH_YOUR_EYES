namespace Calibration
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
            this.btnStartCal1 = new System.Windows.Forms.Button();
            this.pictBoxCal1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictBoxCal1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStartCal1
            // 
            this.btnStartCal1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnStartCal1.AutoSize = true;
            this.btnStartCal1.Location = new System.Drawing.Point(347, 49);
            this.btnStartCal1.Name = "btnStartCal1";
            this.btnStartCal1.Size = new System.Drawing.Size(75, 25);
            this.btnStartCal1.TabIndex = 0;
            this.btnStartCal1.Text = "Start Cal 1";
            this.btnStartCal1.UseVisualStyleBackColor = true;
            this.btnStartCal1.Click += new System.EventHandler(this.btnStartCal1_Click);
            // 
            // pictBoxCal1
            // 
            this.pictBoxCal1.Location = new System.Drawing.Point(377, 215);
            this.pictBoxCal1.Name = "pictBoxCal1";
            this.pictBoxCal1.Size = new System.Drawing.Size(150, 150);
            this.pictBoxCal1.TabIndex = 1;
            this.pictBoxCal1.TabStop = false;
            // 
            // calibrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictBoxCal1);
            this.Controls.Add(this.btnStartCal1);
            this.Name = "calibrationForm";
            this.Text = "calibrationForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictBoxCal1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnStartCal1;
        private PictureBox pictBoxCal1;
    }
}