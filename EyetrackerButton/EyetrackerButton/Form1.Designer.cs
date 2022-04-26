
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
            this.testbox2 = new System.Windows.Forms.PictureBox();
            this.testbox1 = new System.Windows.Forms.PictureBox();
            this.testbox3 = new System.Windows.Forms.PictureBox();
            this.testbox4 = new System.Windows.Forms.PictureBox();
            this.testbox5 = new System.Windows.Forms.PictureBox();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblTime_val = new System.Windows.Forms.Label();
            this.btnGetTime = new System.Windows.Forms.Button();
            this.lblGetTime = new System.Windows.Forms.Label();
            this.lblXAvg = new System.Windows.Forms.Label();
            this.lblYAvg = new System.Windows.Forms.Label();
            this.gazeBoxAvg = new System.Windows.Forms.PictureBox();
            this.lookBtn = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.gazeBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testbox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testbox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testbox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testbox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testbox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gazeBoxAvg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(643, 100);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(75, 23);
            this.btnConnect.TabIndex = 0;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.Location = new System.Drawing.Point(724, 100);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(75, 23);
            this.btnDisconnect.TabIndex = 1;
            this.btnDisconnect.Text = "Disconnect";
            this.btnDisconnect.UseVisualStyleBackColor = true;
            this.btnDisconnect.Click += new System.EventHandler(this.btnDisconnect_Click);
            // 
            // btnRecord
            // 
            this.btnRecord.Location = new System.Drawing.Point(664, 163);
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
            this.lblX.Location = new System.Drawing.Point(661, 201);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(68, 13);
            this.lblX.TabIndex = 3;
            this.lblX.Text = "X-Coordinaat";
            // 
            // lblY
            // 
            this.lblY.AutoSize = true;
            this.lblY.Location = new System.Drawing.Point(664, 218);
            this.lblY.Name = "lblY";
            this.lblY.Size = new System.Drawing.Size(68, 13);
            this.lblY.TabIndex = 4;
            this.lblY.Text = "Y-Coordinaat";
            // 
            // lblX_Val
            // 
            this.lblX_Val.AutoSize = true;
            this.lblX_Val.Location = new System.Drawing.Point(745, 201);
            this.lblX_Val.Name = "lblX_Val";
            this.lblX_Val.Size = new System.Drawing.Size(0, 13);
            this.lblX_Val.TabIndex = 5;
            // 
            // lblY_val
            // 
            this.lblY_val.AutoSize = true;
            this.lblY_val.Location = new System.Drawing.Point(745, 217);
            this.lblY_val.Name = "lblY_val";
            this.lblY_val.Size = new System.Drawing.Size(0, 13);
            this.lblY_val.TabIndex = 6;
            // 
            // gazeBox
            // 
            this.gazeBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gazeBox.BackColor = System.Drawing.Color.Red;
            this.gazeBox.Location = new System.Drawing.Point(1300, 21);
            this.gazeBox.Name = "gazeBox";
            this.gazeBox.Size = new System.Drawing.Size(15, 15);
            this.gazeBox.TabIndex = 7;
            this.gazeBox.TabStop = false;
            // 
            // btnCalibration
            // 
            this.btnCalibration.Location = new System.Drawing.Point(643, 129);
            this.btnCalibration.Name = "btnCalibration";
            this.btnCalibration.Size = new System.Drawing.Size(156, 23);
            this.btnCalibration.TabIndex = 8;
            this.btnCalibration.Text = "Personal Calibration";
            this.btnCalibration.UseVisualStyleBackColor = true;
            this.btnCalibration.Click += new System.EventHandler(this.btnCalibration_Click);
            // 
            // testbox2
            // 
            this.testbox2.BackColor = System.Drawing.Color.Lime;
            this.testbox2.Location = new System.Drawing.Point(698, 281);
            this.testbox2.Name = "testbox2";
            this.testbox2.Size = new System.Drawing.Size(20, 20);
            this.testbox2.TabIndex = 9;
            this.testbox2.TabStop = false;
            // 
            // testbox1
            // 
            this.testbox1.BackColor = System.Drawing.Color.Lime;
            this.testbox1.Location = new System.Drawing.Point(708, 255);
            this.testbox1.Name = "testbox1";
            this.testbox1.Size = new System.Drawing.Size(20, 20);
            this.testbox1.TabIndex = 10;
            this.testbox1.TabStop = false;
            // 
            // testbox3
            // 
            this.testbox3.BackColor = System.Drawing.Color.Lime;
            this.testbox3.Location = new System.Drawing.Point(681, 255);
            this.testbox3.Name = "testbox3";
            this.testbox3.Size = new System.Drawing.Size(20, 20);
            this.testbox3.TabIndex = 11;
            this.testbox3.TabStop = false;
            // 
            // testbox4
            // 
            this.testbox4.BackColor = System.Drawing.Color.Lime;
            this.testbox4.Location = new System.Drawing.Point(734, 255);
            this.testbox4.Name = "testbox4";
            this.testbox4.Size = new System.Drawing.Size(20, 20);
            this.testbox4.TabIndex = 12;
            this.testbox4.TabStop = false;
            // 
            // testbox5
            // 
            this.testbox5.BackColor = System.Drawing.Color.Lime;
            this.testbox5.Location = new System.Drawing.Point(724, 281);
            this.testbox5.Name = "testbox5";
            this.testbox5.Size = new System.Drawing.Size(20, 20);
            this.testbox5.TabIndex = 13;
            this.testbox5.TabStop = false;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(667, 236);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(58, 13);
            this.lblTime.TabIndex = 14;
            this.lblTime.Text = "Timestamp";
            // 
            // lblTime_val
            // 
            this.lblTime_val.AutoSize = true;
            this.lblTime_val.Location = new System.Drawing.Point(732, 236);
            this.lblTime_val.Name = "lblTime_val";
            this.lblTime_val.Size = new System.Drawing.Size(0, 13);
            this.lblTime_val.TabIndex = 15;
            // 
            // btnGetTime
            // 
            this.btnGetTime.Location = new System.Drawing.Point(643, 343);
            this.btnGetTime.Name = "btnGetTime";
            this.btnGetTime.Size = new System.Drawing.Size(75, 23);
            this.btnGetTime.TabIndex = 16;
            this.btnGetTime.Text = "Get Time";
            this.btnGetTime.UseVisualStyleBackColor = true;
            this.btnGetTime.Click += new System.EventHandler(this.btnGetTime_Click);
            // 
            // lblGetTime
            // 
            this.lblGetTime.AutoSize = true;
            this.lblGetTime.Location = new System.Drawing.Point(734, 352);
            this.lblGetTime.Name = "lblGetTime";
            this.lblGetTime.Size = new System.Drawing.Size(0, 13);
            this.lblGetTime.TabIndex = 17;
            // 
            // lblXAvg
            // 
            this.lblXAvg.AutoSize = true;
            this.lblXAvg.Location = new System.Drawing.Point(819, 201);
            this.lblXAvg.Name = "lblXAvg";
            this.lblXAvg.Size = new System.Drawing.Size(0, 13);
            this.lblXAvg.TabIndex = 18;
            // 
            // lblYAvg
            // 
            this.lblYAvg.AutoSize = true;
            this.lblYAvg.Location = new System.Drawing.Point(819, 218);
            this.lblYAvg.Name = "lblYAvg";
            this.lblYAvg.Size = new System.Drawing.Size(0, 13);
            this.lblYAvg.TabIndex = 19;
            // 
            // gazeBoxAvg
            // 
            this.gazeBoxAvg.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gazeBoxAvg.BackColor = System.Drawing.Color.Blue;
            this.gazeBoxAvg.Location = new System.Drawing.Point(1125, 201);
            this.gazeBoxAvg.Name = "gazeBoxAvg";
            this.gazeBoxAvg.Size = new System.Drawing.Size(15, 15);
            this.gazeBoxAvg.TabIndex = 20;
            this.gazeBoxAvg.TabStop = false;
            // 
            // lookBtn
            // 
            this.lookBtn.BackColor = System.Drawing.Color.LightCoral;
            this.lookBtn.Location = new System.Drawing.Point(1030, 373);
            this.lookBtn.Name = "lookBtn";
            this.lookBtn.Size = new System.Drawing.Size(150, 150);
            this.lookBtn.TabIndex = 21;
            this.lookBtn.TabStop = false;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(1367, 547);
            this.Controls.Add(this.lookBtn);
            this.Controls.Add(this.gazeBoxAvg);
            this.Controls.Add(this.lblYAvg);
            this.Controls.Add(this.lblXAvg);
            this.Controls.Add(this.lblGetTime);
            this.Controls.Add(this.btnGetTime);
            this.Controls.Add(this.lblTime_val);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.testbox5);
            this.Controls.Add(this.testbox4);
            this.Controls.Add(this.testbox3);
            this.Controls.Add(this.testbox1);
            this.Controls.Add(this.testbox2);
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
            ((System.ComponentModel.ISupportInitialize)(this.testbox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testbox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testbox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testbox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testbox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gazeBoxAvg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookBtn)).EndInit();
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
        private System.Windows.Forms.PictureBox testbox2;
        private System.Windows.Forms.PictureBox testbox1;
        private System.Windows.Forms.PictureBox testbox3;
        private System.Windows.Forms.PictureBox testbox4;
        private System.Windows.Forms.PictureBox testbox5;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblTime_val;
        private System.Windows.Forms.Button btnGetTime;
        private System.Windows.Forms.Label lblGetTime;
        private System.Windows.Forms.Label lblXAvg;
        private System.Windows.Forms.Label lblYAvg;
        private System.Windows.Forms.PictureBox gazeBoxAvg;
        private System.Windows.Forms.PictureBox lookBtn;
    }
}

