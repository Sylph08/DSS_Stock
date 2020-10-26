using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSS_ChungKhoan
{
    public class Congty
    {
        private int idCongty;
        private string tenCongty;
        private double lNST;
        private double luongCP;
        private double tongTS;
        private double vonCSH;
        
        public Congty(int i1, string i2, double i3, double i4, double i5, double i6)
        {
            this.IdCongty = i1;
            this.TenCongty = i2;
            this.LNST = i3;
            this.LuongCP = i4;
            this.TongTS = i5;
            this.VonCSH = i6;
        }
        public Congty(DataRow row)
        {
            this.IdCongty = (int)row["IDcongty"];
            this.TenCongty = row["tencty"].ToString();
            this.LNST = Convert.ToDouble(row["LNST"]);
            this.LuongCP = Convert.ToDouble(row["luongCP"]);
            this.TongTS = Convert.ToDouble(row["tongTS"]);
            this.VonCSH = Convert.ToDouble(row["vonCSH"]);
        }

        public int IdCongty { get => idCongty; set => idCongty = value; }
        public string TenCongty { get => tenCongty; set => tenCongty = value; }
        public double LNST { get => lNST; set => lNST = value; }
        public double LuongCP { get => luongCP; set => luongCP = value; }
        public double TongTS { get => tongTS; set => tongTS = value; }
        public double VonCSH { get => vonCSH; set => vonCSH = value; }
    }
}
