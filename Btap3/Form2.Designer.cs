namespace Btap3
{
    partial class frmNhanVien
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
            this.txtMSNV = new System.Windows.Forms.TextBox();
            this.txtTenNV = new System.Windows.Forms.TextBox();
            this.txtLuongCB = new System.Windows.Forms.TextBox();
            this.lblMSNV = new System.Windows.Forms.Label();
            this.lblTenNV = new System.Windows.Forms.Label();
            this.lblLuongCB = new System.Windows.Forms.Label();
            this.btnDongY = new System.Windows.Forms.Button();
            this.lblBoQua = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtMSNV
            // 
            this.txtMSNV.Location = new System.Drawing.Point(165, 31);
            this.txtMSNV.Name = "txtMSNV";
            this.txtMSNV.Size = new System.Drawing.Size(149, 22);
            this.txtMSNV.TabIndex = 0;
            // 
            // txtTenNV
            // 
            this.txtTenNV.Location = new System.Drawing.Point(165, 72);
            this.txtTenNV.Name = "txtTenNV";
            this.txtTenNV.Size = new System.Drawing.Size(205, 22);
            this.txtTenNV.TabIndex = 0;
            // 
            // txtLuongCB
            // 
            this.txtLuongCB.Location = new System.Drawing.Point(165, 116);
            this.txtLuongCB.Name = "txtLuongCB";
            this.txtLuongCB.Size = new System.Drawing.Size(149, 22);
            this.txtLuongCB.TabIndex = 0;
            // 
            // lblMSNV
            // 
            this.lblMSNV.AutoSize = true;
            this.lblMSNV.Location = new System.Drawing.Point(60, 31);
            this.lblMSNV.Name = "lblMSNV";
            this.lblMSNV.Size = new System.Drawing.Size(46, 16);
            this.lblMSNV.TabIndex = 1;
            this.lblMSNV.Text = "MSNV";
            // 
            // lblTenNV
            // 
            this.lblTenNV.AutoSize = true;
            this.lblTenNV.Location = new System.Drawing.Point(60, 72);
            this.lblTenNV.Name = "lblTenNV";
            this.lblTenNV.Size = new System.Drawing.Size(91, 16);
            this.lblTenNV.TabIndex = 1;
            this.lblTenNV.Text = "Tên nhân viên";
            // 
            // lblLuongCB
            // 
            this.lblLuongCB.AutoSize = true;
            this.lblLuongCB.Location = new System.Drawing.Point(60, 116);
            this.lblLuongCB.Name = "lblLuongCB";
            this.lblLuongCB.Size = new System.Drawing.Size(95, 16);
            this.lblLuongCB.TabIndex = 1;
            this.lblLuongCB.Text = "Lương căn bản";
            // 
            // btnDongY
            // 
            this.btnDongY.Location = new System.Drawing.Point(180, 163);
            this.btnDongY.Name = "btnDongY";
            this.btnDongY.Size = new System.Drawing.Size(78, 32);
            this.btnDongY.TabIndex = 2;
            this.btnDongY.Text = "Đồng Ý";
            this.btnDongY.UseVisualStyleBackColor = true;
            this.btnDongY.Click += new System.EventHandler(this.btnDongY_Click);
            // 
            // lblBoQua
            // 
            this.lblBoQua.Location = new System.Drawing.Point(295, 163);
            this.lblBoQua.Name = "lblBoQua";
            this.lblBoQua.Size = new System.Drawing.Size(75, 32);
            this.lblBoQua.TabIndex = 2;
            this.lblBoQua.Text = "Bỏ qua";
            this.lblBoQua.UseVisualStyleBackColor = true;
            this.lblBoQua.Click += new System.EventHandler(this.lblBoQua_Click);
            // 
            // frmNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 198);
            this.Controls.Add(this.lblBoQua);
            this.Controls.Add(this.btnDongY);
            this.Controls.Add(this.lblLuongCB);
            this.Controls.Add(this.lblTenNV);
            this.Controls.Add(this.lblMSNV);
            this.Controls.Add(this.txtLuongCB);
            this.Controls.Add(this.txtTenNV);
            this.Controls.Add(this.txtMSNV);
            this.Name = "frmNhanVien";
            this.Text = "Nhân Viên";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMSNV;
        private System.Windows.Forms.TextBox txtTenNV;
        private System.Windows.Forms.TextBox txtLuongCB;
        private System.Windows.Forms.Label lblMSNV;
        private System.Windows.Forms.Label lblTenNV;
        private System.Windows.Forms.Label lblLuongCB;
        private System.Windows.Forms.Button btnDongY;
        private System.Windows.Forms.Button lblBoQua;
    }
}