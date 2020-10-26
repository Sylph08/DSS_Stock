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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LoadComboBox();
        }
        public int dem;
        List<string> Decision = new List<string>()
        {
            "Bạn nên đầu tư",
            "Bạn không nên đầu tư",
            "Bạn nên tiếp tục đầu tư",
            "Bạn không nên tiếp tục đầu tư"
        };
        private void LoadComboBox()
        {
            try
            {
                string sql = "select * from Cophieu";
                DataTable table = DataProvider.Instance.ExecuteQuery(sql);
                cbMaCP.DataSource = table;
                cbMaCP.DisplayMember = "macp";
                cbMaCP.ValueMember = "macp";                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            
        }
        Cophieu LoadCpFromCb(string macp)
        {
            string sql = "select * from Cophieu where macp ='" + macp + "'";
            DataTable table = DataProvider.Instance.ExecuteQuery(sql);
            DataRow row = table.Rows[0];
            Cophieu cpSelected = new Cophieu(row);
            return cpSelected;
        }
        Congty LoadCtyFromCb(string idcty)
        {
            string sql2 = "select * from congty where IDcongty=" + idcty;
            DataTable table2 = DataProvider.Instance.ExecuteQuery(sql2);
            DataRow row2 = table2.Rows[0];
            Congty ctySelected = new Congty(row2);
            return ctySelected;
        }
        string Thongtinhotro()
        {
            string ketluan = "";
            
            string kl2 = "*Từ chỉ tiêu EPS => ";
            string kl3 = "*Từ chỉ tiêu P/E =>";
            string kl4 = "*Từ chỉ tiêu ROA và ROE =>";
            double eps = Convert.ToDouble(txtEPS.Text);
            double pe = Convert.ToDouble(txtPE.Text);
            double roa = Convert.ToDouble(txtROA.Text);
            double roe = Convert.ToDouble(txtROE.Text);            

            if (eps > 0)
            {
                if (eps > 1) kl2 += "Kết quả kinh doanh của công ty đang rất tốt";
                else kl2 += "Kết quả kinh doanh của công ty đang khá tốt";
                dem += 1;
            }
            else if (eps < 0)
            {
                kl2 += "Kết quả kinh doanh của công ty đang thua lỗ";
                dem -= 1;
            }
            else kl2 += "Cần xem xét thêm các phương diện khác để có quyết định";

            if (pe > 0 && pe < 10)
            {
                kl3 += "Giá của cổ phiếu đang rẻ";
                dem += 1;
            }
            else if (pe >= 10 && pe < 20)
            {
                kl3 += "Giá của cổ phiếu đang ở mức trung bình";
                dem += 1;
            }
            else
            {
                kl3 += "Giá của cổ phiếu đang đắt";
                dem -= 1;
            }

            if (roe > 0.15f && roa > 0.075f)
            {
                kl4 += "Công ty có năng lực tài chính tốt";
                dem += 1;
            }
            else
            {
                kl4 += "Công ty có năng lực tài chính không tốt";
                dem -= 1;
            }
            ketluan = ketluan + kl2 + Environment.NewLine + kl3 + Environment.NewLine + kl4;
            return ketluan;
        }
        void TinhToanChiSo(Cophieu cpSelected, Congty ctySelected, double cpmua)
        {
            try
            {
                double ct = ctySelected.LNST * cpSelected.Cotuc / cpmua;
                double eps = (ctySelected.LNST - ct) / ctySelected.LuongCP;
                txtEPS.Text = eps.ToString();
                double pe = 0.0f;
                if (eps != 0)
                {
                    pe = cpSelected.GiaCP / eps;
                    txtPE.Text = pe.ToString();
                }
                double roa = ctySelected.LNST / ctySelected.TongTS;
                txtROA.Text = roa.ToString();
                double roe = ctySelected.LNST / ctySelected.VonCSH;
                txtROE.Text = roe.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            
        }
        void Quyetdinh(string keep, string sold)
        {
            if (dem >= 0)
            {
                lblQuyetdinh.Text = keep;
                lblQuyetdinh.ForeColor = Color.Blue;
                lblQuyetdinh.Font = new Font(lblQuyetdinh.Font.Name, 16);
            }

            else
            {
                lblQuyetdinh.Text= sold;
                lblQuyetdinh.ForeColor = Color.Red;
                lblQuyetdinh.Font = new Font(lblQuyetdinh.Font.Name, 16);
            }
            
        }
        
        private void btnTinhtoan_Click(object sender, EventArgs e)
        {
            try
            {
                dem = 0;
                string macp = cbMaCP.SelectedValue.ToString();
                Cophieu cpSelected = LoadCpFromCb(macp);
                string idcty = cpSelected.IdCongty.ToString();
                Congty ctySelected = LoadCtyFromCb(idcty);
                double cpmua = Convert.ToDouble(txtCPMua.Text);
                double lncc = cpSelected.Cotuc * cpSelected.GiaCP * cpmua - Convert.ToDouble(txtVonDT.Text);
                txtLNCC.Text = lncc.ToString();
                string kl1 = "*Từ chỉ tiêu LNCC của NĐT => ";
                if (lncc < 0)
                {
                    kl1 += "Cổ phiếu đang không sinh lợi nhuận" + Environment.NewLine;
                    dem -= 1;
                }
                else
                {
                    kl1 += "Cổ phiếu đang sinh lợi nhuận" + Environment.NewLine;
                    dem += 1;
                }                
                TinhToanChiSo(cpSelected, ctySelected, cpmua);
                txtKetLuan.Text = kl1 + Thongtinhotro();
                string keep = Decision[2].ToString();
                string sold = Decision[3].ToString();
                Quyetdinh(keep, sold);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }            
        }
        
        private void btnTinhtoan2_Click(object sender, EventArgs e)
        {
            txtLNCC.Text = "";
            try
            {
                dem = 0;
                string macp = cbMaCP.SelectedValue.ToString();
                Cophieu cpSelected = LoadCpFromCb(macp);
                string idcty = cpSelected.IdCongty.ToString();
                Congty ctySelected = LoadCtyFromCb(idcty);
                double cpmua = Convert.ToDouble(txtCPmuaDudinh.Text);
                TinhToanChiSo(cpSelected, ctySelected, cpmua);
                txtKetLuan.Text = Thongtinhotro();
                string keep = Decision[0].ToString();
                string sold = Decision[1].ToString();
                Quyetdinh(keep, sold);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }            
        }

        private void btnThemCP_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = "select max(idcongty) from congty";
                int nextID = (int)DataProvider.Instance.ExecuteScalar(sql);
                AddNewCP form = new AddNewCP(nextID + 1);
                form.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }            
        }

        private void tcMain_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtVonDT.Text = "";
            txtCPMua.Text = "";
            txtCPmuaDudinh.Text = "";
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát không?", "Cảnh báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) != DialogResult.OK)
            {
                e.Cancel = true;
            }
        }
    }
}
