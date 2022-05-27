
namespace instructionForm
{
    partial class startForm
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
            this.btnConnect = new System.Windows.Forms.Button();
            this.btnCalibr = new System.Windows.Forms.Button();
            this.btnRecord = new System.Windows.Forms.Button();
            this.btnDiscon = new System.Windows.Forms.Button();
            this.lblTitle1 = new System.Windows.Forms.Label();
            this.lblTitle2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnConnect
            // 
            this.btnConnect.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnConnect.AutoSize = true;
            this.btnConnect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConnect.Font = new System.Drawing.Font("HelveticaNeueforSAS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnConnect.ForeColor = System.Drawing.SystemColors.GrayText;
            this.btnConnect.Location = new System.Drawing.Point(616, 328);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(200, 60);
            this.btnConnect.TabIndex = 0;
            this.btnConnect.Text = "CONNECT";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // btnCalibr
            // 
            this.btnCalibr.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCalibr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalibr.Font = new System.Drawing.Font("HelveticaNeueforSAS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCalibr.ForeColor = System.Drawing.SystemColors.GrayText;
            this.btnCalibr.Location = new System.Drawing.Point(548, 435);
            this.btnCalibr.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.btnCalibr.Name = "btnCalibr";
            this.btnCalibr.Size = new System.Drawing.Size(200, 60);
            this.btnCalibr.TabIndex = 1;
            this.btnCalibr.Text = "CALIBRATION";
            this.btnCalibr.UseVisualStyleBackColor = true;
            this.btnCalibr.Click += new System.EventHandler(this.btnCalibr_Click);
            // 
            // btnRecord
            // 
            this.btnRecord.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRecord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRecord.Font = new System.Drawing.Font("HelveticaNeueforSAS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnRecord.ForeColor = System.Drawing.SystemColors.GrayText;
            this.btnRecord.Location = new System.Drawing.Point(338, 256);
            this.btnRecord.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.btnRecord.Name = "btnRecord";
            this.btnRecord.Size = new System.Drawing.Size(200, 60);
            this.btnRecord.TabIndex = 2;
            this.btnRecord.Text = "START RECORDING";
            this.btnRecord.UseVisualStyleBackColor = true;
            this.btnRecord.Click += new System.EventHandler(this.btnRecord_Click);
            // 
            // btnDiscon
            // 
            this.btnDiscon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDiscon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDiscon.Font = new System.Drawing.Font("HelveticaNeueforSAS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDiscon.ForeColor = System.Drawing.SystemColors.GrayText;
            this.btnDiscon.Location = new System.Drawing.Point(293, 424);
            this.btnDiscon.Name = "btnDiscon";
            this.btnDiscon.Size = new System.Drawing.Size(200, 60);
            this.btnDiscon.TabIndex = 3;
            this.btnDiscon.Text = "DISCONNECT";
            this.btnDiscon.UseVisualStyleBackColor = true;
            this.btnDiscon.Click += new System.EventHandler(this.btnDiscon_Click);
            // 
            // lblTitle1
            // 
            this.lblTitle1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTitle1.AutoSize = true;
            this.lblTitle1.Font = new System.Drawing.Font("HelveticaNeueforSAS", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTitle1.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblTitle1.Location = new System.Drawing.Point(233, 18);
            this.lblTitle1.Name = "lblTitle1";
            this.lblTitle1.Size = new System.Drawing.Size(617, 47);
            this.lblTitle1.TabIndex = 4;
            this.lblTitle1.Text = "Welcome to working with your eyes.";
            this.lblTitle1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblTitle2
            // 
            this.lblTitle2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTitle2.AutoSize = true;
            this.lblTitle2.Font = new System.Drawing.Font("HelveticaNeueforSAS", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTitle2.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblTitle2.Location = new System.Drawing.Point(46, 115);
            this.lblTitle2.Name = "lblTitle2";
            this.lblTitle2.Size = new System.Drawing.Size(970, 47);
            this.lblTitle2.TabIndex = 5;
            this.lblTitle2.Text = "Press the connect button to connect with the eye tracker.";
            // 
            // startForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1061, 605);
            this.Controls.Add(this.lblTitle2);
            this.Controls.Add(this.lblTitle1);
            this.Controls.Add(this.btnDiscon);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.btnCalibr);
            this.Controls.Add(this.btnRecord);
            this.Name = "startForm";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.startForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.startForm_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Button btnCalibr;
        private System.Windows.Forms.Button btnRecord;
        private System.Windows.Forms.Button btnDiscon;
        private System.Windows.Forms.Label lblTitle1;
        private System.Windows.Forms.Label lblTitle2;
    }
}

