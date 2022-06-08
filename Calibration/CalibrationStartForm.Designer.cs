namespace Calibration
{
    partial class CalibrationStartForm
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
            this.btnDiscon = new System.Windows.Forms.Button();
            this.btnCalibr = new System.Windows.Forms.Button();
            this.btnRecord = new System.Windows.Forms.Button();
            this.gazeBox = new System.Windows.Forms.PictureBox();
            this.btnTestCal = new System.Windows.Forms.Button();
            this.lbl_coor_head_x = new System.Windows.Forms.Label();
            this.lbl_coor_head_y = new System.Windows.Forms.Label();
            this.lbl_coor_head_z = new System.Windows.Forms.Label();
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
            // btnDiscon
            // 
            this.btnDiscon.Location = new System.Drawing.Point(93, 12);
            this.btnDiscon.Name = "btnDiscon";
            this.btnDiscon.Size = new System.Drawing.Size(75, 23);
            this.btnDiscon.TabIndex = 1;
            this.btnDiscon.Text = "Disconnect";
            this.btnDiscon.UseVisualStyleBackColor = true;
            this.btnDiscon.Click += new System.EventHandler(this.btnDiscon_Click);
            // 
            // btnCalibr
            // 
            this.btnCalibr.Location = new System.Drawing.Point(12, 41);
            this.btnCalibr.Name = "btnCalibr";
            this.btnCalibr.Size = new System.Drawing.Size(75, 23);
            this.btnCalibr.TabIndex = 2;
            this.btnCalibr.Text = "Calibrate";
            this.btnCalibr.UseVisualStyleBackColor = true;
            this.btnCalibr.Click += new System.EventHandler(this.btnCalibr_Click);
            // 
            // btnRecord
            // 
            this.btnRecord.Location = new System.Drawing.Point(93, 41);
            this.btnRecord.Name = "btnRecord";
            this.btnRecord.Size = new System.Drawing.Size(75, 23);
            this.btnRecord.TabIndex = 3;
            this.btnRecord.Text = "Recording";
            this.btnRecord.UseVisualStyleBackColor = true;
            this.btnRecord.Click += new System.EventHandler(this.btnRecord_Click);
            // 
            // gazeBox
            // 
            this.gazeBox.BackColor = System.Drawing.Color.Red;
            this.gazeBox.Location = new System.Drawing.Point(331, 181);
            this.gazeBox.Name = "gazeBox";
            this.gazeBox.Size = new System.Drawing.Size(25, 25);
            this.gazeBox.TabIndex = 4;
            this.gazeBox.TabStop = false;
            // 
            // btnTestCal
            // 
            this.btnTestCal.Location = new System.Drawing.Point(12, 70);
            this.btnTestCal.Name = "btnTestCal";
            this.btnTestCal.Size = new System.Drawing.Size(156, 23);
            this.btnTestCal.TabIndex = 5;
            this.btnTestCal.Text = "Test Calibration";
            this.btnTestCal.UseVisualStyleBackColor = true;
            this.btnTestCal.Click += new System.EventHandler(this.btnTestCal_Click);
            // 
            // lbl_coor_head_x
            // 
            this.lbl_coor_head_x.AutoSize = true;
            this.lbl_coor_head_x.Location = new System.Drawing.Point(327, 35);
            this.lbl_coor_head_x.Name = "lbl_coor_head_x";
            this.lbl_coor_head_x.Size = new System.Drawing.Size(0, 15);
            this.lbl_coor_head_x.TabIndex = 6;
            // 
            // lbl_coor_head_y
            // 
            this.lbl_coor_head_y.AutoSize = true;
            this.lbl_coor_head_y.Location = new System.Drawing.Point(327, 60);
            this.lbl_coor_head_y.Name = "lbl_coor_head_y";
            this.lbl_coor_head_y.Size = new System.Drawing.Size(0, 15);
            this.lbl_coor_head_y.TabIndex = 7;
            // 
            // lbl_coor_head_z
            // 
            this.lbl_coor_head_z.AutoSize = true;
            this.lbl_coor_head_z.Location = new System.Drawing.Point(327, 87);
            this.lbl_coor_head_z.Name = "lbl_coor_head_z";
            this.lbl_coor_head_z.Size = new System.Drawing.Size(0, 15);
            this.lbl_coor_head_z.TabIndex = 8;
            // 
            // CalibrationStartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_coor_head_z);
            this.Controls.Add(this.lbl_coor_head_y);
            this.Controls.Add(this.lbl_coor_head_x);
            this.Controls.Add(this.btnTestCal);
            this.Controls.Add(this.gazeBox);
            this.Controls.Add(this.btnRecord);
            this.Controls.Add(this.btnCalibr);
            this.Controls.Add(this.btnDiscon);
            this.Controls.Add(this.btnConnect);
            this.Name = "CalibrationStartForm";
            this.Text = "CalibrationStartForm";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CalibrationStartForm_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.gazeBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnConnect;
        private Button btnDiscon;
        private Button btnCalibr;
        private Button btnRecord;
        private PictureBox gazeBox;
        private Button btnTestCal;
        private Label lbl_coor_head_x;
        private Label lbl_coor_head_y;
        private Label lbl_coor_head_z;
    }
}