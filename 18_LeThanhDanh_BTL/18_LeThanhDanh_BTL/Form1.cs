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


namespace _18_LeThanhDanh_BTL
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
            Danh_18.Url = "https://github.com/";//Gán URL
            Danh_18.Navigate(); //Điều hướng để mở trang url đã gán bằng navigate

            //18_Lê Thanh Danh
            //Dùng LinkText để lấy được đường dẫn đến trang đăng nhập
            IWebElement Danh_18_signin = Danh_18.FindElement(By.LinkText("Sign in"));
            Danh_18_signin.Click();
            Thread.Sleep(2000);
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
        }
    }
}
