
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
            this.pictBoxCalibration = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictBoxCalibration)).BeginInit();
            this.SuspendLayout();
            // 
            // pictBoxCalibration
            // 
            this.pictBoxCalibration.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictBoxCalibration.BackColor = System.Drawing.Color.Red;
            this.pictBoxCalibration.Location = new System.Drawing.Point(386, 211);
            this.pictBoxCalibration.Name = "pictBoxCalibration";
            this.pictBoxCalibration.Size = new System.Drawing.Size(28, 28);
            this.pictBoxCalibration.TabIndex = 0;
            this.pictBoxCalibration.TabStop = false;
            this.pictBoxCalibration.Click += new System.EventHandler(this.pictBoxCalibration_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictBoxCalibration);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.pictBoxCalibration)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictBoxCalibration;
    }
}