
namespace instructionForm
{
    partial class DemoForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DemoForm));
            this.gazeBox = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTitle2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lookBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gazeBox)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gazeBox
            // 
            this.gazeBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.gazeBox.Image = ((System.Drawing.Image)(resources.GetObject("gazeBox.Image")));
            this.gazeBox.Location = new System.Drawing.Point(717, 307);
            this.gazeBox.Name = "gazeBox";
            this.gazeBox.Size = new System.Drawing.Size(25, 25);
            this.gazeBox.TabIndex = 4;
            this.gazeBox.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblTitle2);
            this.panel1.Location = new System.Drawing.Point(123, 45);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1181, 110);
            this.panel1.TabIndex = 5;
            // 
            // lblTitle2
            // 
            this.lblTitle2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTitle2.AutoSize = true;
            this.lblTitle2.Font = new System.Drawing.Font("HelveticaNeueforSAS", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTitle2.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblTitle2.Location = new System.Drawing.Point(119, 31);
            this.lblTitle2.Name = "lblTitle2";
            this.lblTitle2.Size = new System.Drawing.Size(926, 47);
            this.lblTitle2.TabIndex = 6;
            this.lblTitle2.Text = "Place the 4 blocks next to each other in the right order.";
            this.lblTitle2.Click += new System.EventHandler(this.lblTitle2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::instructionForm.Properties.Resources._4_Lego_Bricks;
            this.pictureBox1.Location = new System.Drawing.Point(461, 241);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(555, 312);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // lookBtn
            // 
            this.lookBtn.Location = new System.Drawing.Point(1219, 282);
            this.lookBtn.Name = "lookBtn";
            this.lookBtn.Size = new System.Drawing.Size(161, 104);
            this.lookBtn.TabIndex = 7;
            this.lookBtn.Text = "NEXT";
            this.lookBtn.UseVisualStyleBackColor = true;
            this.lookBtn.Click += new System.EventHandler(this.lookBtn_Click);
            // 
            // DemoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1459, 639);
            this.Controls.Add(this.lookBtn);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gazeBox);
            this.Name = "DemoForm";
            this.Text = "DemoForm";
            this.Load += new System.EventHandler(this.DemoForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DemoForm_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.gazeBox)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox gazeBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTitle2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button lookBtn;
    }
}