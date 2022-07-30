namespace Webcam_Scanner
{
    partial class formScanner
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
            this.components = new System.ComponentModel.Container();
            this.picbxQR = new System.Windows.Forms.PictureBox();
            this.rchtxbxOutput = new System.Windows.Forms.RichTextBox();
            this.cmbxCamera = new System.Windows.Forms.ComboBox();
            this.btnScan = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picbxQR)).BeginInit();
            this.SuspendLayout();
            // 
            // picbxQR
            // 
            this.picbxQR.Location = new System.Drawing.Point(81, 84);
            this.picbxQR.Name = "picbxQR";
            this.picbxQR.Size = new System.Drawing.Size(316, 283);
            this.picbxQR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picbxQR.TabIndex = 1;
            this.picbxQR.TabStop = false;
            // 
            // rchtxbxOutput
            // 
            this.rchtxbxOutput.Location = new System.Drawing.Point(418, 98);
            this.rchtxbxOutput.Name = "rchtxbxOutput";
            this.rchtxbxOutput.Size = new System.Drawing.Size(279, 161);
            this.rchtxbxOutput.TabIndex = 2;
            this.rchtxbxOutput.Text = "";
            // 
            // cmbxCamera
            // 
            this.cmbxCamera.FormattingEnabled = true;
            this.cmbxCamera.Location = new System.Drawing.Point(149, 54);
            this.cmbxCamera.Name = "cmbxCamera";
            this.cmbxCamera.Size = new System.Drawing.Size(248, 24);
            this.cmbxCamera.TabIndex = 3;
            // 
            // btnScan
            // 
            this.btnScan.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnScan.Location = new System.Drawing.Point(418, 59);
            this.btnScan.Name = "btnScan";
            this.btnScan.Size = new System.Drawing.Size(134, 23);
            this.btnScan.TabIndex = 4;
            this.btnScan.Text = "Scan QR Code";
            this.btnScan.UseVisualStyleBackColor = true;
            this.btnScan.Click += new System.EventHandler(this.btnScan_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(78, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Camera:";
            // 
            // Timer
            // 
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // formScanner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnScan);
            this.Controls.Add(this.cmbxCamera);
            this.Controls.Add(this.rchtxbxOutput);
            this.Controls.Add(this.picbxQR);
            this.Name = "formScanner";
            this.Text = "Webcam Scanner";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.formScanner_FormClosing);
            this.Load += new System.EventHandler(this.formScanner_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picbxQR)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picbxQR;
        private System.Windows.Forms.RichTextBox rchtxbxOutput;
        private System.Windows.Forms.ComboBox cmbxCamera;
        private System.Windows.Forms.Button btnScan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer Timer;
    }
}

