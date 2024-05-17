using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _18_LeThanhDanh_BTL_NUnit
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtC_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnKQ_Click(object sender, EventArgs e)
        {
            int Danh_18_a, Danh_18_b, Danh_18_c;
            //18_Le Thanh Danh
            Danh_18_a = int.Parse(txtA.Text);
            Danh_18_b = int.Parse(txtB.Text);
            Danh_18_c = int.Parse(txtC.Text);
            CheckTamGiac Danh_18 = new CheckTamGiac(Danh_18_a,Danh_18_b,Danh_18_c);
            string Danh_18_kq = Danh_18.funcTamGiac();
            txtKQ.Text = Danh_18_kq.ToString();
        }
    }
}
