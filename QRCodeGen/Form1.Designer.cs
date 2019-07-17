namespace QRCodeGen
{
    partial class MainFrm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.LblBar = new System.Windows.Forms.Label();
            this.LblQR = new System.Windows.Forms.Label();
            this.TxtBarc = new System.Windows.Forms.TextBox();
            this.TxtQr = new System.Windows.Forms.TextBox();
            this.BtnBarcode = new System.Windows.Forms.Button();
            this.BtnQR = new System.Windows.Forms.Button();
            this.PicBox1 = new System.Windows.Forms.PictureBox();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.BtnPrint = new System.Windows.Forms.Button();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.BtnPrint);
            this.panel1.Controls.Add(this.BtnQR);
            this.panel1.Controls.Add(this.BtnBarcode);
            this.panel1.Controls.Add(this.TxtQr);
            this.panel1.Controls.Add(this.TxtBarc);
            this.panel1.Controls.Add(this.LblQR);
            this.panel1.Controls.Add(this.LblBar);
            this.panel1.Location = new System.Drawing.Point(4, 582);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1351, 427);
            this.panel1.TabIndex = 0;
            // 
            // LblBar
            // 
            this.LblBar.AutoSize = true;
            this.LblBar.Enabled = false;
            this.LblBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblBar.Location = new System.Drawing.Point(25, 97);
            this.LblBar.Name = "LblBar";
            this.LblBar.Size = new System.Drawing.Size(203, 51);
            this.LblBar.TabIndex = 0;
            this.LblBar.Text = "Barcode:";
            // 
            // LblQR
            // 
            this.LblQR.AutoSize = true;
            this.LblQR.Enabled = false;
            this.LblQR.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblQR.Location = new System.Drawing.Point(8, 226);
            this.LblQR.Name = "LblQR";
            this.LblQR.Size = new System.Drawing.Size(220, 51);
            this.LblQR.TabIndex = 1;
            this.LblQR.Text = "QR Code:";
            // 
            // TxtBarc
            // 
            this.TxtBarc.Location = new System.Drawing.Point(228, 109);
            this.TxtBarc.Multiline = true;
            this.TxtBarc.Name = "TxtBarc";
            this.TxtBarc.Size = new System.Drawing.Size(718, 39);
            this.TxtBarc.TabIndex = 2;
            // 
            // TxtQr
            // 
            this.TxtQr.Location = new System.Drawing.Point(228, 241);
            this.TxtQr.Multiline = true;
            this.TxtQr.Name = "TxtQr";
            this.TxtQr.Size = new System.Drawing.Size(718, 36);
            this.TxtQr.TabIndex = 3;
            // 
            // BtnBarcode
            // 
            this.BtnBarcode.Location = new System.Drawing.Point(979, 109);
            this.BtnBarcode.Name = "BtnBarcode";
            this.BtnBarcode.Size = new System.Drawing.Size(176, 39);
            this.BtnBarcode.TabIndex = 4;
            this.BtnBarcode.Text = "Barcode";
            this.BtnBarcode.UseVisualStyleBackColor = true;
            this.BtnBarcode.Click += new System.EventHandler(this.BtnBarcode_Click);
            // 
            // BtnQR
            // 
            this.BtnQR.Location = new System.Drawing.Point(979, 241);
            this.BtnQR.Name = "BtnQR";
            this.BtnQR.Size = new System.Drawing.Size(176, 36);
            this.BtnQR.TabIndex = 5;
            this.BtnQR.Text = "QR Code";
            this.BtnQR.UseVisualStyleBackColor = true;
            this.BtnQR.Click += new System.EventHandler(this.BtnQR_Click);
            // 
            // PicBox1
            // 
            this.PicBox1.BackColor = System.Drawing.SystemColors.Window;
            this.PicBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PicBox1.Location = new System.Drawing.Point(4, 2);
            this.PicBox1.Name = "PicBox1";
            this.PicBox1.Size = new System.Drawing.Size(1351, 574);
            this.PicBox1.TabIndex = 1;
            this.PicBox1.TabStop = false;
            // 
            // BtnPrint
            // 
            this.BtnPrint.Location = new System.Drawing.Point(472, 323);
            this.BtnPrint.Name = "BtnPrint";
            this.BtnPrint.Size = new System.Drawing.Size(327, 65);
            this.BtnPrint.TabIndex = 6;
            this.BtnPrint.Text = "Print QR Code";
            this.BtnPrint.UseVisualStyleBackColor = true;
            this.BtnPrint.Click += new System.EventHandler(this.BtnPrint_Click);
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // MainFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1355, 1017);
            this.Controls.Add(this.PicBox1);
            this.Controls.Add(this.panel1);
            this.Name = "MainFrm";
            this.Text = "QR Code Generator";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnQR;
        private System.Windows.Forms.Button BtnBarcode;
        private System.Windows.Forms.TextBox TxtQr;
        private System.Windows.Forms.TextBox TxtBarc;
        private System.Windows.Forms.Label LblQR;
        private System.Windows.Forms.Label LblBar;
        private System.Windows.Forms.PictureBox PicBox1;
        private System.Windows.Forms.Button BtnPrint;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintDialog printDialog1;
    }
}

