namespace LapTrinhDesktop_2212482_Buoi3_2
{
    partial class FormBai2
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
            this.btnChonHang = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblTongTien = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnTinhTien = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBoHang = new System.Windows.Forms.Button();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnChonHang);
            this.panel1.Controls.Add(this.listBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(386, 425);
            this.panel1.TabIndex = 0;
            // 
            // btnChonHang
            // 
            this.btnChonHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnChonHang.Location = new System.Drawing.Point(278, 189);
            this.btnChonHang.Name = "btnChonHang";
            this.btnChonHang.Size = new System.Drawing.Size(105, 27);
            this.btnChonHang.TabIndex = 2;
            this.btnChonHang.Text = "Chọn hàng >";
            this.btnChonHang.UseVisualStyleBackColor = true;
            this.btnChonHang.Click += new System.EventHandler(this.btnChonHang_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[] {
            "Chuột ",
            "Bàn phím ",
            "Máy in",
            "USB KingMax"});
            this.listBox1.Location = new System.Drawing.Point(40, 97);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(231, 212);
            this.listBox1.TabIndex = 1;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(76, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Danh sách hàng hóa";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblTongTien);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.btnTinhTien);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.btnBoHang);
            this.panel2.Controls.Add(this.listBox2);
            this.panel2.Location = new System.Drawing.Point(405, 13);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(386, 425);
            this.panel2.TabIndex = 1;
            // 
            // lblTongTien
            // 
            this.lblTongTien.AutoSize = true;
            this.lblTongTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblTongTien.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblTongTien.Location = new System.Drawing.Point(189, 380);
            this.lblTongTien.Name = "lblTongTien";
            this.lblTongTien.Size = new System.Drawing.Size(18, 20);
            this.lblTongTien.TabIndex = 8;
            this.lblTongTien.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(19, 380);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Tổng tiền thanh toán";
            // 
            // btnTinhTien
            // 
            this.btnTinhTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnTinhTien.Location = new System.Drawing.Point(193, 327);
            this.btnTinhTien.Name = "btnTinhTien";
            this.btnTinhTien.Size = new System.Drawing.Size(75, 23);
            this.btnTinhTien.TabIndex = 6;
            this.btnTinhTien.Text = "Tính tiền";
            this.btnTinhTien.UseVisualStyleBackColor = true;
            this.btnTinhTien.Click += new System.EventHandler(this.btnTinhTien_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(164, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Mặt hàng đã mua";
            // 
            // btnBoHang
            // 
            this.btnBoHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnBoHang.Location = new System.Drawing.Point(3, 189);
            this.btnBoHang.Name = "btnBoHang";
            this.btnBoHang.Size = new System.Drawing.Size(105, 27);
            this.btnBoHang.TabIndex = 5;
            this.btnBoHang.Text = "< Bỏ hàng";
            this.btnBoHang.UseVisualStyleBackColor = true;
            this.btnBoHang.Click += new System.EventHandler(this.btnBoHang_Click);
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(114, 97);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(231, 212);
            this.listBox2.TabIndex = 4;
            // 
            // FormBai2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FormBai2";
            this.Text = "Bán hàng";
            this.Load += new System.EventHandler(this.FormBai2_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnBoHang;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnChonHang;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnTinhTien;
        private System.Windows.Forms.Label lblTongTien;
        private System.Windows.Forms.Label label3;
    }
}