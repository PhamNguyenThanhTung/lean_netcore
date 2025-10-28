namespace bt1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnew = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtngaygui = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtsotiengui = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDiachi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtHoten = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rdphatloc = new System.Windows.Forms.RadioButton();
            this.rdthuong = new System.Windows.Forms.RadioButton();
            this.btadd = new System.Windows.Forms.Button();
            this.cbtime = new System.Windows.Forms.ComboBox();
            this.txtmaKH = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btfind = new System.Windows.Forms.Button();
            this.btexit = new System.Windows.Forms.Button();
            this.lbDSKH = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnew);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtngaygui);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtsotiengui);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtDiachi);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtHoten);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.btadd);
            this.groupBox1.Controls.Add(this.cbtime);
            this.groupBox1.Controls.Add(this.txtmaKH);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(312, 426);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhập thông tin khách hàng gửi tiết kiệm";
            // 
            // btnew
            // 
            this.btnew.Location = new System.Drawing.Point(156, 364);
            this.btnew.Name = "btnew";
            this.btnew.Size = new System.Drawing.Size(75, 23);
            this.btnew.TabIndex = 14;
            this.btnew.Text = "Thêm mới";
            this.btnew.UseVisualStyleBackColor = true;
            this.btnew.Click += new System.EventHandler(this.btnew_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 169);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Họ tên KH";
            // 
            // txtngaygui
            // 
            this.txtngaygui.Location = new System.Drawing.Point(93, 140);
            this.txtngaygui.Name = "txtngaygui";
            this.txtngaygui.Size = new System.Drawing.Size(100, 20);
            this.txtngaygui.TabIndex = 12;
            this.txtngaygui.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 143);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Ngày gửi";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // txtsotiengui
            // 
            this.txtsotiengui.Location = new System.Drawing.Point(93, 114);
            this.txtsotiengui.Name = "txtsotiengui";
            this.txtsotiengui.Size = new System.Drawing.Size(100, 20);
            this.txtsotiengui.TabIndex = 10;
            this.txtsotiengui.TextChanged += new System.EventHandler(this.txtsotiengui_TextChanged);
            this.txtsotiengui.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtsotiengui_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Số tiền gửi";
            // 
            // txtDiachi
            // 
            this.txtDiachi.Location = new System.Drawing.Point(93, 88);
            this.txtDiachi.Name = "txtDiachi";
            this.txtDiachi.Size = new System.Drawing.Size(164, 20);
            this.txtDiachi.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Địa chỉ";
            // 
            // txtHoten
            // 
            this.txtHoten.Location = new System.Drawing.Point(93, 62);
            this.txtHoten.Name = "txtHoten";
            this.txtHoten.Size = new System.Drawing.Size(100, 20);
            this.txtHoten.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Họ tên KH";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rdphatloc);
            this.groupBox3.Controls.Add(this.rdthuong);
            this.groupBox3.Location = new System.Drawing.Point(19, 239);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(273, 44);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Loại tiết kiệm";
            // 
            // rdphatloc
            // 
            this.rdphatloc.AutoSize = true;
            this.rdphatloc.Location = new System.Drawing.Point(137, 19);
            this.rdphatloc.Name = "rdphatloc";
            this.rdphatloc.Size = new System.Drawing.Size(64, 17);
            this.rdphatloc.TabIndex = 1;
            this.rdphatloc.TabStop = true;
            this.rdphatloc.Text = "Phát lộc";
            this.rdphatloc.UseVisualStyleBackColor = true;
            // 
            // rdthuong
            // 
            this.rdthuong.AutoSize = true;
            this.rdthuong.Location = new System.Drawing.Point(17, 19);
            this.rdthuong.Name = "rdthuong";
            this.rdthuong.Size = new System.Drawing.Size(62, 17);
            this.rdthuong.TabIndex = 0;
            this.rdthuong.TabStop = true;
            this.rdthuong.Text = "Thường";
            this.rdthuong.UseVisualStyleBackColor = true;
            this.rdthuong.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // btadd
            // 
            this.btadd.Location = new System.Drawing.Point(23, 364);
            this.btadd.Name = "btadd";
            this.btadd.Size = new System.Drawing.Size(75, 23);
            this.btadd.TabIndex = 3;
            this.btadd.Text = "Thêm vào";
            this.btadd.UseVisualStyleBackColor = true;
            this.btadd.Click += new System.EventHandler(this.btadd_Click);
            // 
            // cbtime
            // 
            this.cbtime.FormattingEnabled = true;
            this.cbtime.Location = new System.Drawing.Point(93, 166);
            this.cbtime.Name = "cbtime";
            this.cbtime.Size = new System.Drawing.Size(43, 21);
            this.cbtime.TabIndex = 2;
            // 
            // txtmaKH
            // 
            this.txtmaKH.Location = new System.Drawing.Point(93, 36);
            this.txtmaKH.Name = "txtmaKH";
            this.txtmaKH.Size = new System.Drawing.Size(100, 20);
            this.txtmaKH.TabIndex = 1;
            this.txtmaKH.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtmaKH_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã KH";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbDSKH);
            this.groupBox2.Location = new System.Drawing.Point(330, 20);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(458, 329);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách khách hàng";
            // 
            // btfind
            // 
            this.btfind.Location = new System.Drawing.Point(539, 376);
            this.btfind.Name = "btfind";
            this.btfind.Size = new System.Drawing.Size(75, 23);
            this.btfind.TabIndex = 4;
            this.btfind.Text = "Tìm kiếm";
            this.btfind.UseVisualStyleBackColor = true;
            // 
            // btexit
            // 
            this.btexit.Location = new System.Drawing.Point(669, 376);
            this.btexit.Name = "btexit";
            this.btexit.Size = new System.Drawing.Size(75, 23);
            this.btexit.TabIndex = 5;
            this.btexit.Text = "Thoát";
            this.btexit.UseVisualStyleBackColor = true;
            this.btexit.Click += new System.EventHandler(this.btexit_Click);
            // 
            // lbDSKH
            // 
            this.lbDSKH.FormattingEnabled = true;
            this.lbDSKH.Location = new System.Drawing.Point(6, 19);
            this.lbDSKH.Name = "lbDSKH";
            this.lbDSKH.Size = new System.Drawing.Size(446, 303);
            this.lbDSKH.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btexit);
            this.Controls.Add(this.btfind);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtDiachi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtHoten;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rdthuong;
        private System.Windows.Forms.Button btadd;
        private System.Windows.Forms.ComboBox cbtime;
        private System.Windows.Forms.TextBox txtmaKH;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtngaygui;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtsotiengui;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnew;
        private System.Windows.Forms.RadioButton rdphatloc;
        private System.Windows.Forms.Button btfind;
        private System.Windows.Forms.Button btexit;
        private System.Windows.Forms.ListBox lbDSKH;
    }
}

