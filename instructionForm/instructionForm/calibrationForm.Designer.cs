
namespace instructionForm
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
            this.btnStartCal.Location = new System.Drawing.Point(457, 35);
            this.btnStartCal.MaximumSize = new System.Drawing.Size(200, 80);
            this.btnStartCal.Name = "btnStartCal";
            this.btnStartCal.Size = new System.Drawing.Size(200, 80);
            this.btnStartCal.TabIndex = 1;
            this.btnStartCal.Text = "START CALIBRATION";
            this.btnStartCal.UseVisualStyleBackColor = true;
            this.btnStartCal.Click += new System.EventHandler(this.btnStartCal_Click);
            // 
            // calibrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(1171, 637);
            this.Controls.Add(this.btnStartCal);
            this.Name = "calibrationForm";
            this.Text = "calibrationForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnStartCal;
    }
}