
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblYCoData = new System.Windows.Forms.Label();
            this.lblXCoData = new System.Windows.Forms.Label();
            this.lblYCo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDiscon = new System.Windows.Forms.Button();
            this.btnRecord = new System.Windows.Forms.Button();
            this.btnCalibr = new System.Windows.Forms.Button();
            this.btnConnect = new System.Windows.Forms.Button();
            this.panelGazeDir = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.lblYCoData);
            this.panel1.Controls.Add(this.lblXCoData);
            this.panel1.Controls.Add(this.lblYCo);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnDiscon);
            this.panel1.Controls.Add(this.btnRecord);
            this.panel1.Controls.Add(this.btnCalibr);
            this.panel1.Controls.Add(this.btnConnect);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 605);
            this.panel1.TabIndex = 1;
            // 
            // lblYCoData
            // 
            this.lblYCoData.AutoSize = true;
            this.lblYCoData.Location = new System.Drawing.Point(12, 301);
            this.lblYCoData.Name = "lblYCoData";
            this.lblYCoData.Size = new System.Drawing.Size(38, 15);
            this.lblYCoData.TabIndex = 7;
            this.lblYCoData.Text = "label2";
            // 
            // lblXCoData
            // 
            this.lblXCoData.AutoSize = true;
            this.lblXCoData.Location = new System.Drawing.Point(12, 250);
            this.lblXCoData.Name = "lblXCoData";
            this.lblXCoData.Size = new System.Drawing.Size(38, 15);
            this.lblXCoData.TabIndex = 6;
            this.lblXCoData.Text = "label2";
            // 
            // lblYCo
            // 
            this.lblYCo.AutoSize = true;
            this.lblYCo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblYCo.ForeColor = System.Drawing.Color.White;
            this.lblYCo.Location = new System.Drawing.Point(12, 280);
            this.lblYCo.Name = "lblYCo";
            this.lblYCo.Size = new System.Drawing.Size(111, 21);
            this.lblYCo.TabIndex = 5;
            this.lblYCo.Text = "Y-Coordinate";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 229);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 21);
            this.label1.TabIndex = 4;
            this.label1.Text = "X-Coordinate";
            // 
            // btnDiscon
            // 
            this.btnDiscon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDiscon.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnDiscon.FlatAppearance.BorderSize = 3;
            this.btnDiscon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDiscon.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDiscon.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDiscon.Location = new System.Drawing.Point(0, 545);
            this.btnDiscon.Name = "btnDiscon";
            this.btnDiscon.Size = new System.Drawing.Size(200, 60);
            this.btnDiscon.TabIndex = 3;
            this.btnDiscon.Text = "DISCONNECT";
            this.btnDiscon.UseVisualStyleBackColor = true;
            // 
            // btnRecord
            // 
            this.btnRecord.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRecord.FlatAppearance.BorderSize = 3;
            this.btnRecord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRecord.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRecord.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRecord.Location = new System.Drawing.Point(0, 146);
            this.btnRecord.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.btnRecord.Name = "btnRecord";
            this.btnRecord.Size = new System.Drawing.Size(200, 60);
            this.btnRecord.TabIndex = 2;
            this.btnRecord.Text = "START RECORDING";
            this.btnRecord.UseVisualStyleBackColor = true;
            // 
            // btnCalibr
            // 
            this.btnCalibr.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCalibr.FlatAppearance.BorderSize = 3;
            this.btnCalibr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalibr.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCalibr.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCalibr.Location = new System.Drawing.Point(0, 73);
            this.btnCalibr.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.btnCalibr.Name = "btnCalibr";
            this.btnCalibr.Size = new System.Drawing.Size(200, 60);
            this.btnCalibr.TabIndex = 1;
            this.btnCalibr.Text = "CALIBRATION";
            this.btnCalibr.UseVisualStyleBackColor = true;
            this.btnCalibr.Click += new System.EventHandler(this.btnCalibr_Click);
            // 
            // btnConnect
            // 
            this.btnConnect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConnect.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnConnect.FlatAppearance.BorderSize = 3;
            this.btnConnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConnect.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnConnect.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnConnect.Location = new System.Drawing.Point(0, 0);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(200, 60);
            this.btnConnect.TabIndex = 0;
            this.btnConnect.Text = "CONNECT";
            this.btnConnect.UseVisualStyleBackColor = true;
            // 
            // panelGazeDir
            // 
            this.panelGazeDir.BackColor = System.Drawing.Color.Transparent;
            this.panelGazeDir.Location = new System.Drawing.Point(475, 201);
            this.panelGazeDir.Name = "panelGazeDir";
            this.panelGazeDir.Size = new System.Drawing.Size(20, 20);
            this.panelGazeDir.TabIndex = 2;
            this.panelGazeDir.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // startForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(1061, 605);
            this.Controls.Add(this.panelGazeDir);
            this.Controls.Add(this.panel1);
            this.Name = "startForm";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.startForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.startForm_MouseMove);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblYCoData;
        private System.Windows.Forms.Label lblXCoData;
        private System.Windows.Forms.Label lblYCo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDiscon;
        private System.Windows.Forms.Button btnRecord;
        private System.Windows.Forms.Button btnCalibr;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Panel panelGazeDir;
    }
}

