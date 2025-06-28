using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;
using OpenQA.Selenium.Interactions;

namespace Triangle_51_Diem_02_Dang
{
    public partial class Selenium_51_Diem_02_Dang : Form
    {
        public Selenium_51_Diem_02_Dang()
        {
            InitializeComponent();
        }

        private void download_02_51_Click(object sender, EventArgs e)
        {
            //Đóng màn hình đen khi chạy
            ChromeDriverService chrome_02_51 = ChromeDriverService.CreateDefaultService();
            chrome_02_51.HideCommandPromptWindow = true;
            //Điều hướng trình duyệt đến link
            IWebDriver driver_02_51 = new ChromeDriver(chrome_02_51);
            //Chuyển Link cho Selenium điều hướng
            driver_02_51.Navigate().GoToUrl("https://www.nhaccuatui.com/");
            //Search nhạc
            IWebElement search = driver_02_51.FindElement(By.Id("txtSearch"));
            search.SendKeys(search_txtb_02_51.Text);
            search.Submit();
            //Select First
            IReadOnlyList<IWebElement> first_02_51 = driver_02_51.FindElements(By.ClassName("thumb"));
            first_02_51.First().Click();
            //Tải nhạc
            driver_02_51.FindElement(By.Id("btnDownloadBox")).Click();
            Thread.Sleep(2000);
            driver_02_51.FindElement(By.Id("downloadBasic")).Click();
            //driver_02_51.Close();
        }

        private void search_02_51_Click(object sender, EventArgs e)
        {
            //Đóng màn hình đen khi chạy
            ChromeDriverService chrome_02_51 = ChromeDriverService.CreateDefaultService();
            chrome_02_51.HideCommandPromptWindow = true;
            //Điều hướng trình duyệt đến link
            IWebDriver driver_02_51 = new ChromeDriver(chrome_02_51);
            //Chuyển Link cho Selenium điều hướng
            driver_02_51.Navigate().GoToUrl("https://www.nhaccuatui.com/");
            //Search nhạc
            IWebElement search = driver_02_51.FindElement(By.Id("txtSearch"));
            search.SendKeys(search_txtb_02_51.Text);
            search.Submit();
            //Select First
            IReadOnlyList<IWebElement> first_02_51 = driver_02_51.FindElements(By.ClassName("thumb"));
            first_02_51.First().Click();
            //driver_02_51.Close();
        }

        private void login_02_51_Click(object sender, EventArgs e)
        {
            //Đóng màn hình đen khi chạy
            ChromeDriverService chrome_02_51 = ChromeDriverService.CreateDefaultService();
            chrome_02_51.HideCommandPromptWindow = true;
            //Điều hướng trình duyệt đến link
            IWebDriver driver_02_51 = new ChromeDriver(chrome_02_51);
            //Chuyển Link cho Selenium điều hướng
            driver_02_51.Navigate().GoToUrl("https://www.nhaccuatui.com/");
            //Click nút đăng nhập
            driver_02_51.FindElement(By.ClassName("profile-login")).Click();
            //Nhập username
            driver_02_51.FindElement(By.Name("uname")).SendKeys(uname_02_51.Text);
            //Nhập password
            driver_02_51.FindElement(By.Name("password")).SendKeys(pw_02_51.Text);
            //Chấp nhận điều khoản
            driver_02_51.FindElement(By.Id("privacy_allow")).Click();
            //Nhấp đăng nhập
            driver_02_51.FindElement(By.XPath("//*[@id=\"_frmLogin\"]/div/a")).Click();
        }

        private void sharing_02_51_Click(object sender, EventArgs e)
        {
            //Đóng màn hình đen khi chạy
            ChromeDriverService chrome_02_51 = ChromeDriverService.CreateDefaultService();
            chrome_02_51.HideCommandPromptWindow = true;
            //Điều hướng trình duyệt đến link
            IWebDriver driver_02_51 = new ChromeDriver(chrome_02_51);
            //Chuyển Link cho Selenium điều hướng
            driver_02_51.Navigate().GoToUrl("https://www.nhaccuatui.com/");
            //Search nhạc
            IWebElement search = driver_02_51.FindElement(By.Id("txtSearch"));
            search.SendKeys(search_txtb_02_51.Text);
            search.Submit();
            //Select First
            IReadOnlyList<IWebElement> first_02_51 = driver_02_51.FindElements(By.ClassName("thumb"));
            first_02_51.First().Click();
            //Click Share
            driver_02_51.FindElement(By.Id("btnShareNowPlaying")).Click();
            Console.WriteLine(driver_02_51.FindElement(By.Id("urlEmbedBlog")).GetAttribute("value"));
        }

        private void top100_02_51_Click(object sender, EventArgs e)
        {
            //Đóng màn hình đen khi chạy
            ChromeDriverService chrome_02_51 = ChromeDriverService.CreateDefaultService();
            chrome_02_51.HideCommandPromptWindow = true;
            //Điều hướng trình duyệt đến link
            IWebDriver driver_02_51 = new ChromeDriver(chrome_02_51);
            //Chuyển Link cho Selenium điều hướng
            driver_02_51.Navigate().GoToUrl("https://www.nhaccuatui.com/");
            //Vào mục top 100
            driver_02_51.FindElement(By.LinkText("Top 100")).Click();
            //Nghe toàn bộ
            driver_02_51.FindElement(By.ClassName("active_play")).Click();
            //driver_02_51.Close();
        }

        private void logout_02_51_Click(object sender, EventArgs e)
        {
            //Đóng màn hình đen khi chạy
            ChromeDriverService chrome_02_51 = ChromeDriverService.CreateDefaultService();
            chrome_02_51.HideCommandPromptWindow = true;
            //Điều hướng trình duyệt đến link
            IWebDriver driver_02_51 = new ChromeDriver(chrome_02_51);
            //Chuyển Link cho Selenium điều hướng
            driver_02_51.Navigate().GoToUrl("https://www.nhaccuatui.com/");
            //Click nút đăng nhập
            driver_02_51.FindElement(By.ClassName("profile-login")).Click();
            //Nhập username
            driver_02_51.FindElement(By.Name("uname")).SendKeys(uname_02_51.Text);
            //Nhập password
            driver_02_51.FindElement(By.Name("password")).SendKeys(pw_02_51.Text);
            //Chấp nhận điều khoản
            driver_02_51.FindElement(By.Id("privacy_allow")).Click();
            //Nhấp đăng nhập
            driver_02_51.FindElement(By.XPath("//*[@id=\"_frmLogin\"]/div/a")).Click();
            //Hover qua dropdown menu
            Actions action_02_51 = new Actions(driver_02_51);
            IWebElement ele_02_51 = driver_02_51.FindElement(By.ClassName("userprofile-card-item"));
            action_02_51.MoveToElement(ele_02_51).Perform();
            //Đăng xuất
            driver_02_51.FindElement(By.XPath("//*[@id=\"user_control\"]/ul/li[5]/a")).Click();
        }
    }
}
