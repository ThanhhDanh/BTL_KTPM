using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Support;
using System.Timers;
using System.Threading;

namespace _18_LeThanhDanh_BTL2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnUrl_Click(object sender, EventArgs e)
        {
            //18_Lê Thanh Danh
            //Đóng cmd
            ChromeDriverService TDanh_18 = ChromeDriverService.CreateDefaultService();
            TDanh_18.HideCommandPromptWindow = true;
            //18_Lê Thanh Danh
            IWebDriver Danh_18 = new ChromeDriver(TDanh_18);
            Danh_18.Url = "https://github.com/ThanhhDanh";//Gán URL
            Danh_18.Navigate(); //Điều hướng để mở trang url đã gán bằng navigate
            Thread.Sleep(1000);

            //18_Lê Thanh Danh
            //Click vào ô tìm kiếm bằng ClassName
            Danh_18.FindElement(By.ClassName("search-input-container")).Click();
            Thread.Sleep(1000);
            //18_Lê Thanh Danh
            //Sử dụng Name để truyền SendKeys cần tìm kiếm
            IWebElement Danh_18_link = Danh_18.FindElement(By.Name("query-builder-test"));
            Danh_18_link.SendKeys("KiemThuPhanMemTest" + OpenQA.Selenium.Keys.Enter);
            Thread.Sleep(2000);
           //18_Lê Thanh Danh
            Danh_18.FindElement(By.ClassName("search-title")).Click();
            Thread.Sleep(3000);
            //18_Lê Thanh Danh
            //Nếu muốn xóa thì phải đăng nhập nếu trước đó chưa đăng nhập
            Danh_18.FindElement(By.LinkText("Sign in")).Click();
            Thread.Sleep(1000);
            //18_Lê Thanh Danh
            //Input của email để truyền giá trị từ SendKeys vào
            IWebElement Danh_18_email = Danh_18.FindElement(By.Name("login"));
            Danh_18_email.SendKeys("ThanhhDanh");
            Thread.Sleep(1000);
            //18_Lê Thanh Danh
            //Input của password để truyền giá trị từ SendKeys vào
            IWebElement Danh_18_password = Danh_18.FindElement(By.Name("password"));
            Danh_18_password.SendKeys("lethanhdanh2003");
            Thread.Sleep(2000);
            //18_Lê Thanh Danh
            //Click vào nút 'Log in'
            IWebElement Danh_18_click = Danh_18.FindElement(By.Name("commit"));
            Danh_18_click.Click();
            Thread.Sleep(1000);

            //18_Lê Thanh Danh
            Danh_18.FindElement(By.LinkText("Settings")).Click();
            Thread.Sleep(1000);
            //18_Lê Thanh Danh
            //Click vào "Delete this repository"
            Danh_18.FindElement(By.Id("dialog-show-repo-delete-menu-dialog")).Click();
            Thread.Sleep(2000);
            //18_Lê Thanh Danh
            //Sau đó Click vào "I want to delete this repository"
            Danh_18.FindElement(By.Id("repo-delete-proceed-button-container")).Click();
            Thread.Sleep(2000);
            //18_Lê Thanh Danh
            //Sau đó Click tiếp vào "I have read and understand these effects"
            Danh_18.FindElement(By.Id("repo-delete-proceed-button-container")).Click();
            Thread.Sleep(2000);
            //18_Lê Thanh Danh
            //Cuối cùng điền vào "To confirm, type "Repository" in the box below" muốn xóa qua SendKeys
            IWebElement Danh_18_search =  Danh_18.FindElement(By.Name("verification_field"));
            Danh_18_search.SendKeys("ThanhhDanh/KiemThuPhanMemTest123");
            Thread.Sleep(2000);
            //18_Lê Thanh Danh
            //Sau khi gán Repository xong thì nếu đúng thì sẽ xóa không thì không thể xóa
            Danh_18.FindElement(By.Id("repo-delete-proceed-button")).Click();

        }
    }
}
