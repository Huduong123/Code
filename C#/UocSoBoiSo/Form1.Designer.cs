namespace UocSoBoiSo
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
            this.label1 = new System.Windows.Forms.Label();
            this.NhapSoA = new System.Windows.Forms.Label();
            this.NhapSoB = new System.Windows.Forms.Label();
            this.txtNhapSoA = new System.Windows.Forms.TextBox();
            this.txtNhapSoB = new System.Windows.Forms.TextBox();
            this.USCLonNhat = new System.Windows.Forms.Label();
            this.BSCNhoNhat = new System.Windows.Forms.Label();
            this.btnThucHien = new System.Windows.Forms.Button();
            this.btnTiepTuc = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.ResultUSCLonNhat = new System.Windows.Forms.TextBox();
            this.ResultBSCNhoNhat = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(63, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(608, 53);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ước Số Chung - Bội Số Chung";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // NhapSoA
            // 
            this.NhapSoA.AutoSize = true;
            this.NhapSoA.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NhapSoA.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.NhapSoA.Location = new System.Drawing.Point(125, 124);
            this.NhapSoA.Name = "NhapSoA";
            this.NhapSoA.Size = new System.Drawing.Size(134, 33);
            this.NhapSoA.TabIndex = 1;
            this.NhapSoA.Text = "Nhập số a:";
            this.NhapSoA.Click += new System.EventHandler(this.NhapSoA_Click);
            // 
            // NhapSoB
            // 
            this.NhapSoB.AutoSize = true;
            this.NhapSoB.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NhapSoB.Location = new System.Drawing.Point(123, 191);
            this.NhapSoB.Name = "NhapSoB";
            this.NhapSoB.Size = new System.Drawing.Size(136, 33);
            this.NhapSoB.TabIndex = 2;
            this.NhapSoB.Text = "Nhập số b:";
            this.NhapSoB.Click += new System.EventHandler(this.NhapSoB_Click);
            // 
            // txtNhapSoA
            // 
            this.txtNhapSoA.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNhapSoA.Location = new System.Drawing.Point(292, 124);
            this.txtNhapSoA.Multiline = true;
            this.txtNhapSoA.Name = "txtNhapSoA";
            this.txtNhapSoA.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtNhapSoA.Size = new System.Drawing.Size(320, 35);
            this.txtNhapSoA.TabIndex = 3;
            this.txtNhapSoA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtNhapSoA.TextChanged += new System.EventHandler(this.txtNhapSoA_TextChanged);
            // 
            // txtNhapSoB
            // 
            this.txtNhapSoB.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNhapSoB.Location = new System.Drawing.Point(292, 189);
            this.txtNhapSoB.Multiline = true;
            this.txtNhapSoB.Name = "txtNhapSoB";
            this.txtNhapSoB.Size = new System.Drawing.Size(320, 35);
            this.txtNhapSoB.TabIndex = 4;
            this.txtNhapSoB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtNhapSoB.TextChanged += new System.EventHandler(this.txtNhapSoB_TextChanged);
            // 
            // USCLonNhat
            // 
            this.USCLonNhat.AutoSize = true;
            this.USCLonNhat.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.USCLonNhat.Location = new System.Drawing.Point(117, 243);
            this.USCLonNhat.Name = "USCLonNhat";
            this.USCLonNhat.Size = new System.Drawing.Size(284, 33);
            this.USCLonNhat.TabIndex = 5;
            this.USCLonNhat.Text = "Ước số chung lớn nhất :";
            this.USCLonNhat.Click += new System.EventHandler(this.USCLonNhat_Click);
            // 
            // BSCNhoNhat
            // 
            this.BSCNhoNhat.AutoSize = true;
            this.BSCNhoNhat.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BSCNhoNhat.Location = new System.Drawing.Point(117, 298);
            this.BSCNhoNhat.Name = "BSCNhoNhat";
            this.BSCNhoNhat.Size = new System.Drawing.Size(281, 33);
            this.BSCNhoNhat.TabIndex = 6;
            this.BSCNhoNhat.Text = "Bội số chung nhỏ nhất :";
            this.BSCNhoNhat.Click += new System.EventHandler(this.BSCNhoNhat_Click);
            // 
            // btnThucHien
            // 
            this.btnThucHien.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnThucHien.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnThucHien.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnThucHien.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThucHien.Location = new System.Drawing.Point(111, 374);
            this.btnThucHien.Name = "btnThucHien";
            this.btnThucHien.Size = new System.Drawing.Size(148, 48);
            this.btnThucHien.TabIndex = 9;
            this.btnThucHien.Text = "Thực Hiện";
            this.btnThucHien.UseVisualStyleBackColor = false;
            this.btnThucHien.Click += new System.EventHandler(this.btnThucHien_Click);
            // 
            // btnTiepTuc
            // 
            this.btnTiepTuc.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnTiepTuc.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTiepTuc.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTiepTuc.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnTiepTuc.Location = new System.Drawing.Point(338, 374);
            this.btnTiepTuc.Name = "btnTiepTuc";
            this.btnTiepTuc.Size = new System.Drawing.Size(123, 48);
            this.btnTiepTuc.TabIndex = 10;
            this.btnTiepTuc.Text = "Tiếp Tục";
            this.btnTiepTuc.UseVisualStyleBackColor = false;
            this.btnTiepTuc.Click += new System.EventHandler(this.btnTiepTuc_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnThoat.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnThoat.Location = new System.Drawing.Point(542, 370);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(116, 52);
            this.btnThoat.TabIndex = 11;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // ResultUSCLonNhat
            // 
            this.ResultUSCLonNhat.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ResultUSCLonNhat.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResultUSCLonNhat.Location = new System.Drawing.Point(437, 243);
            this.ResultUSCLonNhat.Multiline = true;
            this.ResultUSCLonNhat.Name = "ResultUSCLonNhat";
            this.ResultUSCLonNhat.Size = new System.Drawing.Size(175, 35);
            this.ResultUSCLonNhat.TabIndex = 12;
            this.ResultUSCLonNhat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ResultUSCLonNhat.TextChanged += new System.EventHandler(this.ResultUSCLonNhat_TextChanged);
            // 
            // ResultBSCNhoNhat
            // 
            this.ResultBSCNhoNhat.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ResultBSCNhoNhat.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResultBSCNhoNhat.Location = new System.Drawing.Point(437, 296);
            this.ResultBSCNhoNhat.Multiline = true;
            this.ResultBSCNhoNhat.Name = "ResultBSCNhoNhat";
            this.ResultBSCNhoNhat.Size = new System.Drawing.Size(175, 35);
            this.ResultBSCNhoNhat.TabIndex = 13;
            this.ResultBSCNhoNhat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ResultBSCNhoNhat.TextChanged += new System.EventHandler(this.ResultBSCNhoNhat_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(765, 450);
            this.Controls.Add(this.ResultBSCNhoNhat);
            this.Controls.Add(this.ResultUSCLonNhat);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnTiepTuc);
            this.Controls.Add(this.btnThucHien);
            this.Controls.Add(this.BSCNhoNhat);
            this.Controls.Add(this.USCLonNhat);
            this.Controls.Add(this.txtNhapSoB);
            this.Controls.Add(this.txtNhapSoA);
            this.Controls.Add(this.NhapSoB);
            this.Controls.Add(this.NhapSoA);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Ước Số - Bội Số";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label NhapSoA;
        private System.Windows.Forms.Label NhapSoB;
        private System.Windows.Forms.TextBox txtNhapSoA;
        private System.Windows.Forms.TextBox txtNhapSoB;
        private System.Windows.Forms.Label USCLonNhat;
        private System.Windows.Forms.Label BSCNhoNhat;
        private System.Windows.Forms.Button btnThucHien;
        private System.Windows.Forms.Button btnTiepTuc;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.TextBox ResultUSCLonNhat;
        private System.Windows.Forms.TextBox ResultBSCNhoNhat;
    }
}

