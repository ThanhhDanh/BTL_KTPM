using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_LeThanhDanh_BTL_NUnit
{
    public class CheckTamGiac
    {
        private int Danh_18_a, Danh_18_b, Danh_18_c;

        public CheckTamGiac(int x,int y,int z) {
            this.Danh_18_a = x; this.Danh_18_b = y; this.Danh_18_c = z;
        }

        public string funcTamGiac()
        {
            string Danh_18_loaiTG;
            if(Danh_18_a < 0 || Danh_18_b < 0 || Danh_18_c < 0) {
                return Danh_18_loaiTG = "Tam giác không được cạnh < 0";
            }
            else
            {
                if (Danh_18_a == Danh_18_b && Danh_18_b == Danh_18_c)
                    return Danh_18_loaiTG = "Tam giac deu";
                else if (Danh_18_a == Danh_18_b || Danh_18_a == Danh_18_c || Danh_18_b == Danh_18_c)
                    return Danh_18_loaiTG = "Tam giac can";
                else
                    return Danh_18_loaiTG = "Tam giac thuong";

            }
        }
    }
}
