namespace DSS_ChungKhoan
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
            this.tcMain = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtCPMua = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnTinhtoan = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtVonDT = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnTinhtoan2 = new System.Windows.Forms.Button();
            this.txtCPmuaDudinh = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtKetLuan = new System.Windows.Forms.TextBox();
            this.btnThemCP = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbMaCP = new System.Windows.Forms.ComboBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.txtROE = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtROA = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtPE = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtEPS = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.txtLNCC = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblQuyetdinh = new System.Windows.Forms.Label();
            this.tcMain.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcMain
            // 
            this.tcMain.Controls.Add(this.tabPage1);
            this.tcMain.Controls.Add(this.tabPage2);
            this.tcMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tcMain.Location = new System.Drawing.Point(13, 61);
            this.tcMain.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tcMain.Name = "tcMain";
            this.tcMain.SelectedIndex = 0;
            this.tcMain.Size = new System.Drawing.Size(618, 210);
            this.tcMain.TabIndex = 0;
            this.tcMain.SelectedIndexChanged += new System.EventHandler(this.tcMain_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 34);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage1.Size = new System.Drawing.Size(610, 172);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Đối tượng đang đầu tư";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtCPMua);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.btnTinhtoan);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtVonDT);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(9, 9);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(593, 156);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhập thông tin";
            // 
            // txtCPMua
            // 
            this.txtCPMua.Location = new System.Drawing.Point(238, 65);
            this.txtCPMua.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCPMua.Name = "txtCPMua";
            this.txtCPMua.Size = new System.Drawing.Size(224, 30);
            this.txtCPMua.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 68);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(216, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Lượng cổ phiếu đã mua";
            // 
            // btnTinhtoan
            // 
            this.btnTinhtoan.Location = new System.Drawing.Point(210, 105);
            this.btnTinhtoan.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnTinhtoan.Name = "btnTinhtoan";
            this.btnTinhtoan.Size = new System.Drawing.Size(169, 40);
            this.btnTinhtoan.TabIndex = 5;
            this.btnTinhtoan.Text = "Tính toán";
            this.btnTinhtoan.UseVisualStyleBackColor = true;
            this.btnTinhtoan.Click += new System.EventHandler(this.btnTinhtoan_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(470, 28);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "(nghìn đồng)";
            // 
            // txtVonDT
            // 
            this.txtVonDT.Location = new System.Drawing.Point(238, 25);
            this.txtVonDT.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtVonDT.Name = "txtVonDT";
            this.txtVonDT.Size = new System.Drawing.Size(224, 30);
            this.txtVonDT.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 28);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Lượng vốn đầu tư";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox4);
            this.tabPage2.Location = new System.Drawing.Point(4, 34);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage2.Size = new System.Drawing.Size(610, 172);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Đối tượng mong muốn đầu tư";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnTinhtoan2);
            this.groupBox4.Controls.Add(this.txtCPmuaDudinh);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Location = new System.Drawing.Point(10, 12);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox4.Size = new System.Drawing.Size(592, 117);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Nhập thông tin";
            // 
            // btnTinhtoan2
            // 
            this.btnTinhtoan2.Location = new System.Drawing.Point(212, 64);
            this.btnTinhtoan2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnTinhtoan2.Name = "btnTinhtoan2";
            this.btnTinhtoan2.Size = new System.Drawing.Size(180, 40);
            this.btnTinhtoan2.TabIndex = 11;
            this.btnTinhtoan2.Text = "Tính toán";
            this.btnTinhtoan2.UseVisualStyleBackColor = true;
            this.btnTinhtoan2.Click += new System.EventHandler(this.btnTinhtoan2_Click);
            // 
            // txtCPmuaDudinh
            // 
            this.txtCPmuaDudinh.Location = new System.Drawing.Point(274, 25);
            this.txtCPmuaDudinh.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCPmuaDudinh.Name = "txtCPmuaDudinh";
            this.txtCPmuaDudinh.Size = new System.Drawing.Size(224, 30);
            this.txtCPmuaDudinh.TabIndex = 7;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(8, 28);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(258, 25);
            this.label11.TabIndex = 6;
            this.label11.Text = "Lượng cổ phiếu dự định mua";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtKetLuan);
            this.groupBox3.Location = new System.Drawing.Point(13, 277);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox3.Size = new System.Drawing.Size(618, 141);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thông tin hỗ trợ";
            // 
            // txtKetLuan
            // 
            this.txtKetLuan.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtKetLuan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKetLuan.Location = new System.Drawing.Point(9, 33);
            this.txtKetLuan.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtKetLuan.Multiline = true;
            this.txtKetLuan.Name = "txtKetLuan";
            this.txtKetLuan.ReadOnly = true;
            this.txtKetLuan.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtKetLuan.Size = new System.Drawing.Size(597, 98);
            this.txtKetLuan.TabIndex = 0;
            // 
            // btnThemCP
            // 
            this.btnThemCP.Location = new System.Drawing.Point(528, 18);
            this.btnThemCP.Name = "btnThemCP";
            this.btnThemCP.Size = new System.Drawing.Size(38, 35);
            this.btnThemCP.TabIndex = 8;
            this.btnThemCP.Text = "+";
            this.btnThemCP.UseVisualStyleBackColor = true;
            this.btnThemCP.Click += new System.EventHandler(this.btnThemCP_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Lựa chọn cổ phiếu";
            // 
            // cbMaCP
            // 
            this.cbMaCP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMaCP.FormattingEnabled = true;
            this.cbMaCP.Location = new System.Drawing.Point(297, 18);
            this.cbMaCP.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbMaCP.Name = "cbMaCP";
            this.cbMaCP.Size = new System.Drawing.Size(224, 33);
            this.cbMaCP.TabIndex = 0;
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox5.Controls.Add(this.txtROE);
            this.groupBox5.Controls.Add(this.label15);
            this.groupBox5.Controls.Add(this.txtROA);
            this.groupBox5.Controls.Add(this.label16);
            this.groupBox5.Controls.Add(this.txtPE);
            this.groupBox5.Controls.Add(this.label17);
            this.groupBox5.Controls.Add(this.txtEPS);
            this.groupBox5.Controls.Add(this.label18);
            this.groupBox5.Controls.Add(this.label19);
            this.groupBox5.Controls.Add(this.txtLNCC);
            this.groupBox5.Controls.Add(this.label20);
            this.groupBox5.Location = new System.Drawing.Point(639, 31);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox5.Size = new System.Drawing.Size(501, 240);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Các chỉ số";
            // 
            // txtROE
            // 
            this.txtROE.Location = new System.Drawing.Point(206, 201);
            this.txtROE.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtROE.Name = "txtROE";
            this.txtROE.ReadOnly = true;
            this.txtROE.Size = new System.Drawing.Size(164, 30);
            this.txtROE.TabIndex = 10;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(8, 204);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(54, 25);
            this.label15.TabIndex = 9;
            this.label15.Text = "ROE";
            // 
            // txtROA
            // 
            this.txtROA.Location = new System.Drawing.Point(206, 161);
            this.txtROA.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtROA.Name = "txtROA";
            this.txtROA.ReadOnly = true;
            this.txtROA.Size = new System.Drawing.Size(164, 30);
            this.txtROA.TabIndex = 8;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(8, 164);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(55, 25);
            this.label16.TabIndex = 7;
            this.label16.Text = "ROA";
            // 
            // txtPE
            // 
            this.txtPE.Location = new System.Drawing.Point(206, 121);
            this.txtPE.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPE.Name = "txtPE";
            this.txtPE.ReadOnly = true;
            this.txtPE.Size = new System.Drawing.Size(164, 30);
            this.txtPE.TabIndex = 6;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(8, 124);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(44, 25);
            this.label17.TabIndex = 5;
            this.label17.Text = "P/E";
            // 
            // txtEPS
            // 
            this.txtEPS.Location = new System.Drawing.Point(206, 81);
            this.txtEPS.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtEPS.Name = "txtEPS";
            this.txtEPS.ReadOnly = true;
            this.txtEPS.Size = new System.Drawing.Size(164, 30);
            this.txtEPS.TabIndex = 4;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(8, 84);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(52, 25);
            this.label18.TabIndex = 3;
            this.label18.Text = "EPS";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(378, 46);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(123, 25);
            this.label19.TabIndex = 2;
            this.label19.Text = "(nghìn đồng)";
            // 
            // txtLNCC
            // 
            this.txtLNCC.Location = new System.Drawing.Point(206, 41);
            this.txtLNCC.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtLNCC.Name = "txtLNCC";
            this.txtLNCC.ReadOnly = true;
            this.txtLNCC.Size = new System.Drawing.Size(164, 30);
            this.txtLNCC.TabIndex = 1;
            // 
            // label20
            // 
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(8, 28);
            this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(190, 57);
            this.label20.TabIndex = 0;
            this.label20.Text = "Lợi nhuận cuối cùng của nhà đầu tư";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblQuyetdinh);
            this.groupBox2.Location = new System.Drawing.Point(639, 279);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(501, 79);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Hỗ trợ ra quyết định";
            // 
            // lblQuyetdinh
            // 
            this.lblQuyetdinh.AutoSize = true;
            this.lblQuyetdinh.Location = new System.Drawing.Point(7, 30);
            this.lblQuyetdinh.Name = "lblQuyetdinh";
            this.lblQuyetdinh.Size = new System.Drawing.Size(17, 25);
            this.lblQuyetdinh.TabIndex = 0;
            this.lblQuyetdinh.Text = ".";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1175, 430);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnThemCP);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.tcMain);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbMaCP);
            this.Controls.Add(this.groupBox5);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chương trình hỗ trợ ra quyết định đầu tư chứng khoán";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
           
            this.tcMain.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tcMain;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtKetLuan;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtCPMua;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnTinhtoan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtVonDT;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbMaCP;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox txtROE;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtROA;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtPE;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtEPS;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtLNCC;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnTinhtoan2;
        private System.Windows.Forms.TextBox txtCPmuaDudinh;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnThemCP;
        private System.Windows.Forms.Label lblQuyetdinh;
    }
}

