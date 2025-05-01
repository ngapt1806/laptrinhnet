namespace baocao
{
    partial class HoaDonNhap
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSoHDN = new System.Windows.Forms.TextBox();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.txtNCC = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.msktungay = new System.Windows.Forms.MaskedTextBox();
            this.mskdenngay = new System.Windows.Forms.MaskedTextBox();
            this.txtkhoangbd = new System.Windows.Forms.TextBox();
            this.txtkhoangkt = new System.Windows.Forms.TextBox();
            this.dataGridViewHĐN = new System.Windows.Forms.DataGridView();
            this.btnTimkiem = new System.Windows.Forms.Button();
            this.btnBoqua = new System.Windows.Forms.Button();
            this.btnTaoHDN = new System.Windows.Forms.Button();
            this.btnXuat = new System.Windows.Forms.Button();
            this.btnDong = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHĐN)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(358, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(317, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "HÓA ĐƠN NHẬP HÀNG";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Số hóa đơn nhập";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mã nhân viên";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 324);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Mã nhà cung cấp";
            // 
            // txtSoHDN
            // 
            this.txtSoHDN.Location = new System.Drawing.Point(199, 69);
            this.txtSoHDN.Name = "txtSoHDN";
            this.txtSoHDN.Size = new System.Drawing.Size(134, 26);
            this.txtSoHDN.TabIndex = 6;
            // 
            // txtMaNV
            // 
            this.txtMaNV.Location = new System.Drawing.Point(199, 115);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(134, 26);
            this.txtMaNV.TabIndex = 7;
            // 
            // txtNCC
            // 
            this.txtNCC.Location = new System.Drawing.Point(199, 321);
            this.txtNCC.Name = "txtNCC";
            this.txtNCC.Size = new System.Drawing.Size(134, 26);
            this.txtNCC.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(375, 69);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(134, 20);
            this.label7.TabIndex = 9;
            this.label7.Text = "Số lượng hóa đơn";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.mskdenngay);
            this.groupBox1.Controls.Add(this.msktungay);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(34, 167);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(299, 125);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ngày nhập";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Từ ngày";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 73);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 20);
            this.label8.TabIndex = 1;
            this.label8.Text = "Đến ngày";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtkhoangkt);
            this.groupBox2.Controls.Add(this.txtkhoangbd);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(34, 366);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(284, 116);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tổng tiền";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 40);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Từ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 79);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 20);
            this.label9.TabIndex = 1;
            this.label9.Text = "Đến";
            // 
            // msktungay
            // 
            this.msktungay.Location = new System.Drawing.Point(122, 33);
            this.msktungay.Name = "msktungay";
            this.msktungay.Size = new System.Drawing.Size(113, 26);
            this.msktungay.TabIndex = 2;
            // 
            // mskdenngay
            // 
            this.mskdenngay.Location = new System.Drawing.Point(122, 73);
            this.mskdenngay.Name = "mskdenngay";
            this.mskdenngay.Size = new System.Drawing.Size(113, 26);
            this.mskdenngay.TabIndex = 3;
            // 
            // txtkhoangbd
            // 
            this.txtkhoangbd.Location = new System.Drawing.Point(99, 40);
            this.txtkhoangbd.Name = "txtkhoangbd";
            this.txtkhoangbd.Size = new System.Drawing.Size(136, 26);
            this.txtkhoangbd.TabIndex = 2;
            // 
            // txtkhoangkt
            // 
            this.txtkhoangkt.Location = new System.Drawing.Point(99, 72);
            this.txtkhoangkt.Name = "txtkhoangkt";
            this.txtkhoangkt.Size = new System.Drawing.Size(136, 26);
            this.txtkhoangkt.TabIndex = 3;
            // 
            // dataGridViewHĐN
            // 
            this.dataGridViewHĐN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewHĐN.Location = new System.Drawing.Point(379, 106);
            this.dataGridViewHĐN.Name = "dataGridViewHĐN";
            this.dataGridViewHĐN.RowHeadersWidth = 62;
            this.dataGridViewHĐN.RowTemplate.Height = 28;
            this.dataGridViewHĐN.Size = new System.Drawing.Size(585, 494);
            this.dataGridViewHĐN.TabIndex = 12;
            this.dataGridViewHĐN.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewHĐN_CellContentClick);
            // 
            // btnTimkiem
            // 
            this.btnTimkiem.Location = new System.Drawing.Point(45, 544);
            this.btnTimkiem.Name = "btnTimkiem";
            this.btnTimkiem.Size = new System.Drawing.Size(88, 36);
            this.btnTimkiem.TabIndex = 13;
            this.btnTimkiem.Text = "Tìm kiếm";
            this.btnTimkiem.UseVisualStyleBackColor = true;
            this.btnTimkiem.Click += new System.EventHandler(this.btnTimkiem_Click);
            // 
            // btnBoqua
            // 
            this.btnBoqua.Location = new System.Drawing.Point(212, 544);
            this.btnBoqua.Name = "btnBoqua";
            this.btnBoqua.Size = new System.Drawing.Size(75, 36);
            this.btnBoqua.TabIndex = 14;
            this.btnBoqua.Text = "Bỏ qua";
            this.btnBoqua.UseVisualStyleBackColor = true;
            // 
            // btnTaoHDN
            // 
            this.btnTaoHDN.Location = new System.Drawing.Point(434, 659);
            this.btnTaoHDN.Name = "btnTaoHDN";
            this.btnTaoHDN.Size = new System.Drawing.Size(151, 32);
            this.btnTaoHDN.TabIndex = 15;
            this.btnTaoHDN.Text = "Tạo hóa đơn mới";
            this.btnTaoHDN.UseVisualStyleBackColor = true;
            // 
            // btnXuat
            // 
            this.btnXuat.Location = new System.Drawing.Point(675, 659);
            this.btnXuat.Name = "btnXuat";
            this.btnXuat.Size = new System.Drawing.Size(141, 32);
            this.btnXuat.TabIndex = 16;
            this.btnXuat.Text = "Xuất danh sách";
            this.btnXuat.UseVisualStyleBackColor = true;
            // 
            // btnDong
            // 
            this.btnDong.Location = new System.Drawing.Point(889, 659);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(75, 32);
            this.btnDong.TabIndex = 17;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            // 
            // HoaDonNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(995, 719);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.btnXuat);
            this.Controls.Add(this.btnTaoHDN);
            this.Controls.Add(this.btnBoqua);
            this.Controls.Add(this.btnTimkiem);
            this.Controls.Add(this.dataGridViewHĐN);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtNCC);
            this.Controls.Add(this.txtMaNV);
            this.Controls.Add(this.txtSoHDN);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "HoaDonNhap";
            this.Load += new System.EventHandler(this.HoaDonNhap_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHĐN)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSoHDN;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.TextBox txtNCC;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox mskdenngay;
        private System.Windows.Forms.MaskedTextBox msktungay;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtkhoangkt;
        private System.Windows.Forms.TextBox txtkhoangbd;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridViewHĐN;
        private System.Windows.Forms.Button btnTimkiem;
        private System.Windows.Forms.Button btnBoqua;
        private System.Windows.Forms.Button btnTaoHDN;
        private System.Windows.Forms.Button btnXuat;
        private System.Windows.Forms.Button btnDong;
    }
}