using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using _18_LeThanhDanh_BTL_NUnit;

namespace _18_LeThanhDanh_BTL_NUnit_Tester
{
    [TestClass]
    public class UnitTest1
    {
        private CheckTamGiac Danh_18;


        //thiết lập dữ liệu dùng chung tester
        public TestContext TestContext { get; set; }
        [TestInitialize]


        //Liên kết testdata với project
        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV",
            @".\18_Danh_Data\18_Danh_DataTamGiac.csv", "18_Danh_DataTamGiac#csv", DataAccessMethod.Sequential)]
        public void Danh_18_TestWithDataSource()
        {
            int Danh_18_a, Danh_18_b, Danh_18_c;
            string Danh_18_expected, Danh_18_actual;
            Danh_18_a = int.Parse(TestContext.DataRow[0].ToString());
            Danh_18_b = int.Parse(TestContext.DataRow[1].ToString());
            Danh_18_c = int.Parse(TestContext.DataRow[2].ToString());
            Danh_18_expected = TestContext.DataRow[3].ToString();
            Danh_18_expected = Danh_18_expected.Remove(0, 1);
            Danh_18 = new CheckTamGiac(Danh_18_a, Danh_18_b, Danh_18_c);
            Danh_18_actual = Danh_18.funcTamGiac();
            Assert.AreEqual(Danh_18_expected, Danh_18_actual);    
        }
    }
}
