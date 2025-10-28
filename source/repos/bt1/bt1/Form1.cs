using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bt1
{
    public partial class Form1 : Form
    {   
        List<Nguoigui> nguoiguiList = new List<Nguoigui>();

        public Form1()
        {
            InitializeComponent();
        }
        private void AddComboBox()

        {

            cbtime.Items.Add("1");

            cbtime.Items.Add("3");

            cbtime.Items.Add("6");

            cbtime.Items.Add("12");


        }

        private void Form1_Load(object sender, EventArgs e)

        {

            AddComboBox();

            this.KeyPreview = true;

        }
        private void btadd_Click(object sender, EventArgs e)
        {
            int check = 0;
            if (txtmaKH.Text.Length < 6)
            {
                MessageBox.Show("mã khách hàng phải đủ 6 chũ số");
                txtmaKH.Focus();
            }
            else if (txtHoten.Text.Length == 0)
            {
                MessageBox.Show("họ tên không được để trống");
                txtHoten.Focus();
            }
            else if (txtDiachi.Text.Length == 0)
            {
                MessageBox.Show("địa chỉ không được để trống");
                txtDiachi.Focus();

            }
            double tienlai = 0;
            double tiengui = Convert.ToDouble(txtsotiengui.Text);
            double lai = 0;

            if (cbtime.Text == "1") lai = 0.06;
            else if (cbtime.Text == "3") lai = 0.07;
            else if (cbtime.Text == "6") lai = 0.08;
            else if (cbtime.Text == "12") lai = 0.09;
            if (rdphatloc.Checked) lai += 0.01;

            tienlai = tiengui * lai;
            string khachHangInfo = $"{txtmaKH.Text} | {txtHoten.Text} | {txtDiachi.Text} | {txtngaygui.Text} | {tiengui} | {cbtime} tháng | Tiền lãi: {Math.Round(tienlai, 2)}";

            lbDSKH.Items.Add(khachHangInfo);
            nguoiguiList.Add((new Nguoigui(Convert.ToInt32(txtmaKH.Text), txtHoten.Text, txtDiachi.Text, Convert.ToInt32(txtsotiengui.Text),txtngaygui.Text,cbtime.Text,tienlai)));
            StaticData._Nguoigui = nguoiguiList;

        }
        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txtmaKH_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar)) {
                e.Handled = true;
            }
        }
        
        private void txtsotiengui_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtsotiengui_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar)) {
                e.Handled = true;
            }
        }

        private void btnew_Click(object sender, EventArgs e)
        {
            txtmaKH.Text = "";
            txtHoten.Text = "";
            txtDiachi.Text = "";
            txtngaygui.Text = "";
            txtsotiengui.Text = "";
            cbtime.SelectedIndex = -1;
            rdphatloc.Checked = false;
            rdthuong.Checked = false;
        }

        private void btexit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("bạn có muốn thoát không?", "thông báo",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
