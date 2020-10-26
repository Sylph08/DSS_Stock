using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSS_ChungKhoan
{
    class Cophieu
    {
        private string maCP;
        private string tenCp;
        private double giaCP;
        private double cotuc;
        private int idCongty;
        public Cophieu(string i1, string i2, double i3, double i4,int i5)
        {
            this.MaCP = i1;
            this.TenCp = i2;
            this.GiaCP = i3;
            this.Cotuc = i4;
            this.IdCongty = i5;
        }
        public Cophieu(DataRow row)
        {
            this.MaCP = row["macp"].ToString();
            this.TenCp = row["tenCP"].ToString();
            this.GiaCP = Convert.ToDouble(row["giaCP"]);
            this.Cotuc = Convert.ToDouble(row["tilecotuc"]);
            this.IdCongty = (int)row["IDcongty"];
        }
        public string MaCP { get => maCP; set => maCP = value; }
        public string TenCp { get => tenCp; set => tenCp = value; }
        public double GiaCP { get => giaCP; set => giaCP = value; }
        public double Cotuc { get => cotuc; set => cotuc = value; }
        public int IdCongty { get => idCongty; set => idCongty = value; }
    }
}
