using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DSS_ChungKhoan
{
    public partial class AddNewCP : Form
    {
        public AddNewCP()
        {
            InitializeComponent();
        }
        public int IDcty;
        public AddNewCP(int idcty)
        {
            InitializeComponent();
            IDcty = idcty;
            txtIDcty.Text = IDcty.ToString();
            txtMacty.Text= IDcty.ToString();
        }

        private void btnAddCP_Click(object sender, EventArgs e)
        {
            try
            {
                bool dieukien = CheckNull();
                if (dieukien)
                {
                    string sql1 = "insert into congty (tencty,LNST,luongCP,tongTS,vonCSH) values ('" + txtTencty.Text + "', " + txtLNST.Text + "," + txtLuongCP.Text + "," + txtTongTS.Text + "," + txtVonCSH.Text + ")";
                    string sql2 = "insert into Cophieu values ('" + txtMaCP.Text + "','" + txtTenCp.Text + "'," + txtGiaCP.Text + "," + txtTileCT.Text + "," + txtMacty.Text + ")";
                    int x = DataProvider.Instance.ExecuteNonQuery(sql1);
                    int y = DataProvider.Instance.ExecuteNonQuery(sql2);
                    if (x > 0 && y > 0)
                    {
                        MessageBox.Show("Thêm thành công!");
                        this.Close();
                    }
                    else MessageBox.Show("Thêm thất bại!");
                }
                else MessageBox.Show("Một số trường dữ liệu không được bỏ trống!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }            
        }

        private bool CheckNull()
        {
            if (txtTencty.Text != "" && txtLNST.Text != "" && txtLuongCP.Text != "" && txtTongTS.Text != "" && txtVonCSH.Text != "" && txtMaCP.Text != "" && txtGiaCP.Text != "" && txtTileCT.Text != "" && txtMacty.Text != "")
                return true;
            else return false;
        }

        private void AddNewCP_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
        }
    }
}
