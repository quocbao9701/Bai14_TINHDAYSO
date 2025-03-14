namespace Bai14_TINHDAYSO
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
            this.txtBatdau = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtKetthuc = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTong = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTongchan = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTongle = new System.Windows.Forms.TextBox();
            this.btnTinh = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "số bắt đầu";

            // 
            // txtBatdau
            // 
            this.txtBatdau.Location = new System.Drawing.Point(137, 63);
            this.txtBatdau.Name = "txtBatdau";
            this.txtBatdau.Size = new System.Drawing.Size(100, 20);
            this.txtBatdau.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(227, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Chương trình tính toán";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(344, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "số kết thúc";
            // 
            // txtKetthuc
            // 
            this.txtKetthuc.Location = new System.Drawing.Point(427, 63);
            this.txtKetthuc.Name = "txtKetthuc";
            this.txtKetthuc.Size = new System.Drawing.Size(100, 20);
            this.txtKetthuc.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "tổng";

            // 
            // txtTong
            // 
            this.txtTong.Location = new System.Drawing.Point(137, 193);
            this.txtTong.Name = "txtTong";
            this.txtTong.Size = new System.Drawing.Size(100, 20);
            this.txtTong.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 253);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "tổng chẵn";

            // 
            // txtTongchan
            // 
            this.txtTongchan.Location = new System.Drawing.Point(137, 253);
            this.txtTongchan.Name = "txtTongchan";
            this.txtTongchan.Size = new System.Drawing.Size(100, 20);
            this.txtTongchan.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(32, 316);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "tổng lẻ";

            // 
            // txtTongle
            // 
            this.txtTongle.Location = new System.Drawing.Point(137, 316);
            this.txtTongle.Name = "txtTongle";
            this.txtTongle.Size = new System.Drawing.Size(100, 20);
            this.txtTongle.TabIndex = 1;
            // 
            // btnTinh
            // 
            this.btnTinh.Location = new System.Drawing.Point(253, 123);
            this.btnTinh.Name = "btnTinh";
            this.btnTinh.Size = new System.Drawing.Size(75, 23);
            this.btnTinh.TabIndex = 6;
            this.btnTinh.Text = "Tính";
            this.btnTinh.UseVisualStyleBackColor = true;
            this.btnTinh.Click += new System.EventHandler(this.btnTinh_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 562);
            this.Controls.Add(this.btnTinh);
            this.Controls.Add(this.txtKetthuc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTongle);
            this.Controls.Add(this.txtTongchan);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtTong);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtBatdau);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBatdau;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtKetthuc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTong;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTongchan;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTongle;
        private System.Windows.Forms.Button btnTinh;
    }
}

