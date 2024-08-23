namespace LapTrinhDesktop_2212482_buoi3
{
    partial class bai1
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
            this.txtTen = new System.Windows.Forms.TextBox();
            this.btnXuLy = new System.Windows.Forms.Button();
            this.txtSaoChep = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSaoChep = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(158, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập tên của bạn";
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(285, 114);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(209, 20);
            this.txtTen.TabIndex = 1;
            this.txtTen.TextChanged += new System.EventHandler(this.txtTen_TextChanged);
            // 
            // btnXuLy
            // 
            this.btnXuLy.BackColor = System.Drawing.SystemColors.Control;
            this.btnXuLy.Location = new System.Drawing.Point(321, 177);
            this.btnXuLy.Name = "btnXuLy";
            this.btnXuLy.Size = new System.Drawing.Size(75, 23);
            this.btnXuLy.TabIndex = 2;
            this.btnXuLy.Text = "Xử lý";
            this.btnXuLy.UseVisualStyleBackColor = false;
            this.btnXuLy.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtSaoChep
            // 
            this.txtSaoChep.Location = new System.Drawing.Point(285, 243);
            this.txtSaoChep.Name = "txtSaoChep";
            this.txtSaoChep.ReadOnly = true;
            this.txtSaoChep.Size = new System.Drawing.Size(209, 20);
            this.txtSaoChep.TabIndex = 4;
            this.txtSaoChep.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(158, 243);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Bạn đã nhập";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnSaoChep
            // 
            this.btnSaoChep.BackColor = System.Drawing.SystemColors.Control;
            this.btnSaoChep.Location = new System.Drawing.Point(453, 177);
            this.btnSaoChep.Name = "btnSaoChep";
            this.btnSaoChep.Size = new System.Drawing.Size(75, 23);
            this.btnSaoChep.TabIndex = 5;
            this.btnSaoChep.Text = "Copy";
            this.btnSaoChep.UseVisualStyleBackColor = false;
            this.btnSaoChep.Click += new System.EventHandler(this.btnSaoChep_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSaoChep);
            this.Controls.Add(this.txtSaoChep);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnXuLy);
            this.Controls.Add(this.txtTen);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Chương trình 1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.Button btnXuLy;
        private System.Windows.Forms.TextBox txtSaoChep;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSaoChep;
    }
}

