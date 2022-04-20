
namespace EyetrackerButton
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
            this.btnConnect = new System.Windows.Forms.Button();
            this.btnDisconnect = new System.Windows.Forms.Button();
            this.btnRecord = new System.Windows.Forms.Button();
            this.lblX = new System.Windows.Forms.Label();
            this.lblY = new System.Windows.Forms.Label();
            this.lblX_Val = new System.Windows.Forms.Label();
            this.lblY_val = new System.Windows.Forms.Label();
            this.gazeBox = new System.Windows.Forms.PictureBox();
            this.btnCalibration = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gazeBox)).BeginInit();
            this.SuspendLayout();
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(12, 12);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(75, 23);
            this.btnConnect.TabIndex = 0;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.Location = new System.Drawing.Point(93, 12);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(75, 23);
            this.btnDisconnect.TabIndex = 1;
            this.btnDisconnect.Text = "Disconnect";
            this.btnDisconnect.UseVisualStyleBackColor = true;
            this.btnDisconnect.Click += new System.EventHandler(this.btnDisconnect_Click);
            // 
            // btnRecord
            // 
            this.btnRecord.Location = new System.Drawing.Point(395, 217);
            this.btnRecord.Name = "btnRecord";
            this.btnRecord.Size = new System.Drawing.Size(117, 23);
            this.btnRecord.TabIndex = 2;
            this.btnRecord.Text = "Start Recording";
            this.btnRecord.UseVisualStyleBackColor = true;
            this.btnRecord.Click += new System.EventHandler(this.btnRecord_Click);
            // 
            // lblX
            // 
            this.lblX.AutoSize = true;
            this.lblX.Location = new System.Drawing.Point(392, 255);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(68, 13);
            this.lblX.TabIndex = 3;
            this.lblX.Text = "X-Coordinaat";
            // 
            // lblY
            // 
            this.lblY.AutoSize = true;
            this.lblY.Location = new System.Drawing.Point(395, 272);
            this.lblY.Name = "lblY";
            this.lblY.Size = new System.Drawing.Size(68, 13);
            this.lblY.TabIndex = 4;
            this.lblY.Text = "Y-Coordinaat";
            // 
            // lblX_Val
            // 
            this.lblX_Val.AutoSize = true;
            this.lblX_Val.Location = new System.Drawing.Point(476, 255);
            this.lblX_Val.Name = "lblX_Val";
            this.lblX_Val.Size = new System.Drawing.Size(0, 13);
            this.lblX_Val.TabIndex = 5;
            // 
            // lblY_val
            // 
            this.lblY_val.AutoSize = true;
            this.lblY_val.Location = new System.Drawing.Point(476, 271);
            this.lblY_val.Name = "lblY_val";
            this.lblY_val.Size = new System.Drawing.Size(0, 13);
            this.lblY_val.TabIndex = 6;
            // 
            // gazeBox
            // 
            this.gazeBox.BackColor = System.Drawing.Color.Red;
            this.gazeBox.Location = new System.Drawing.Point(1300, 21);
            this.gazeBox.Name = "gazeBox";
            this.gazeBox.Size = new System.Drawing.Size(25, 25);
            this.gazeBox.TabIndex = 7;
            this.gazeBox.TabStop = false;
            // 
            // btnCalibration
            // 
            this.btnCalibration.Location = new System.Drawing.Point(12, 41);
            this.btnCalibration.Name = "btnCalibration";
            this.btnCalibration.Size = new System.Drawing.Size(156, 23);
            this.btnCalibration.TabIndex = 8;
            this.btnCalibration.Text = "Personal Calibration";
            this.btnCalibration.UseVisualStyleBackColor = true;
            this.btnCalibration.Click += new System.EventHandler(this.btnCalibration_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(1367, 547);
            this.Controls.Add(this.btnCalibration);
            this.Controls.Add(this.gazeBox);
            this.Controls.Add(this.lblY_val);
            this.Controls.Add(this.lblX_Val);
            this.Controls.Add(this.lblY);
            this.Controls.Add(this.lblX);
            this.Controls.Add(this.btnRecord);
            this.Controls.Add(this.btnDisconnect);
            this.Controls.Add(this.btnConnect);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.gazeBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Button btnDisconnect;
        private System.Windows.Forms.Button btnRecord;
        private System.Windows.Forms.Label lblX;
        private System.Windows.Forms.Label lblY;
        private System.Windows.Forms.Label lblX_Val;
        private System.Windows.Forms.Label lblY_val;
        private System.Windows.Forms.PictureBox gazeBox;
        private System.Windows.Forms.Button btnCalibration;
    }
}

