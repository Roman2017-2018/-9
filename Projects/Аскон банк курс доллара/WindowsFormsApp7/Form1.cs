using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using OpenQA.Selenium.Chrome;
using HtmlAgilityPack;
using OpenQA.Selenium;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;

namespace WindowsFormsApp7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var browser = new ChromeDriver();
            browser.Navigate().GoToUrl("https://www.plus-bank.ru");
            browser.Manage().Window.Maximize();
            var document = new HtmlAgilityPack.HtmlDocument();
            document.LoadHtml(browser.PageSource);
          
            var item = document.DocumentNode.SelectNodes(@"//html/body/div[3]/div[1]/div[1]/div/div/div[5]/a/table/tbody/tr[1]/td[2]");
            richTextBox1.AppendText(item[0].InnerText);
            document.LoadHtml(browser.PageSource);
            Thread.Sleep(1000);
            //var script = "/bitrix/rk.php?id=118&site_id=s1&event1=banner&event2=click&event3=1+%2F+%5B118%5D+%5Bak_banners%5D+%D0%A1%D0%BB%D0%B0%D0%B9%D0%B4%D0%B5%D1%80+%D0%BD%D0%B0+%D0%B3%D0%BB%D0%B0%D0%B2%D0%BD%D0%BE%D0%B9&goto=%2Flegal_persons%2Fsettlement_and_cash_services%2Fopening_account_online.php";


//
        /// /  browser.FindElementByXPath("//*[@id='carousel-1RrCS']/div/div[1]/div/div[2]/div/a").Click(); Thread.Sleep(1000);




        
            browser.FindElementByXPath("//*[@id='carousel-1RrCS']/a[2]/span/i").Click(); Thread.Sleep(1000);
           browser.FindElementByXPath("//*[@id='carousel-1RrCS']/a[2]/span/i").Click(); Thread.Sleep(1000);
          // browser.FindElementByXPath("//*[@id='carousel-1RrCS']/a[2]/span/i").Click(); Thread.Sleep(1000);

            browser.FindElementByXPath("//*[@id='carousel-1RrCS']/div/div[3]/div/div[2]/div/a").Click(); Thread.Sleep(1000);
            //  browser.FindElementByXPath("//*[@id='carousel-1RrCS']/a[2]/span/i").Click(); Thread.Sleep(1000);
            //  browser.FindElementByXPath("//*[@id='carousel-1RrCS']/a[2]/span/i").Click(); Thread.Sleep(1000);
            //   browser.FindElementByXPath("//*[@id='carousel-1RrCS']/a[2]/span/i").Click(); Thread.Sleep(1000);
            //   browser.FindElementByXPath("//*[@id='carousel-1RrCS']/a[2]/span/i").Click(); Thread.Sleep(1000);
            //  browser.FindElementByXPath("//*[@id='carousel-1RrCS']/a[2]/span/i").Click(); Thread.Sleep(1000);
            // IWebElement checkbox = browser.FindElement(By.ClassName("button orange big"));
            // checkbox.Click();


            // browser.FindElementByXPath("//*[@id='carousel - 1RrCS']/div/div[3]/div/div[2]/div/a").Click();
            // button.Click();

            String pat1 = @"\<td class=""exchange-table-buy"">\n\s+([0-9]+\.[0-9]+)\s+</td>";
            System.Net.WebClient wc = new System.Net.WebClient();
            String Response = wc.DownloadString("https://www.plus-bank.ru/");
            String pat = @"<td>([0-9]+)</td>";
            // String Rate = System.Text.RegularExpressions.Regex.Match(Response, @" class=""wid_valute_div wid_curses_test widget_er_bank_pursh"" style=""margin-right: 25px;"">([0-9]+\.[0-9]+)").Groups[1].Value;
          
            // String Rate = System.Text.RegularExpressions.Regex.Match(Response, @" class=""wid_valute_div wid_curses_test widget_er_bank_pursh"" style=""margin-right: 25px;"">57.35</div>\r\n\s+.*?([0-9]+\.[0-9]+)</div>").Groups[1].Value;
            // String Rate = System.Text.RegularExpressions.Regex.Match(Response, @"\<td class=""exchange-table-sell"">\n\s+([0-9]+\.[0-9]+)\s+</td>").Groups[1].Value;
            string result1 = "";
            Regex r1 = new Regex(pat, RegexOptions.IgnoreCase);
            Match m1 = r1.Match(Response);
            int matchCount1 = 0;
            while (m1.Success)
            {
                richTextBox1.AppendText("Плюс банк: " + "  " + "покупка доллара" + "(" + result1 + ")" + " р." + "  ");
                result1 = m1.Groups[1].Value;

                m1 = m1.NextMatch();
                matchCount1++;
            }
            //string result = "";
            //Regex r = new Regex(pat, RegexOptions.IgnoreCase);
            //Match m = r.Match(Response);
            //int matchCount = 0;
            //while (m.Success)
            //{
            //    if (matchCount == 5) { richTextBox1.AppendText("продажа доллара " + "(" + result + ")" + " р. \r\n"); }
            //    result = m.Groups[1].Value;

            //    m = m.NextMatch(); matchCount++;
            //}

        }
         static bool SelectItem(IWebElement comboBox, string text)
           {
                IReadOnlyCollection<IWebElement> items =  comboBox.FindElements(By.XPath("//*[@id='root']/div/div/div/div/div/form/div[3]/div[1]/div/div/div/div/div[2]/div/div/input"));
                foreach (IWebElement item in items)
                    if (item.GetAttribute("value") == text)
                    {
                        item.Click();
                        return true;
                    }
                return false;
             }
        private void button2_Click(object sender, EventArgs e)
        {
            var browser = new ChromeDriver();
            browser.Navigate().GoToUrl("http://e.mail.ru/login/");
         


           // browser.Manage().Window.Maximize();
            
            var document = new HtmlAgilityPack.HtmlDocument();
            document.LoadHtml(browser.PageSource); //Thread.Sleep(2000);
            IWebElement detailFrame = browser.FindElement(By.XPath(@"//*[@id='auth-form']/div/div/iframe"));
            browser.SwitchTo().Frame(detailFrame);
            //var documertnt = browser.FindElementByXPath(@"//div[@class = 'Select-control']");
            var documertn = browser.FindElementsByCssSelector("[class=domain-select]");
        //    Thread.Sleep(1000);
            var items2 = browser.FindElementByXPath("//*[@id='root']/div/div/div/div/div/form/div[3]/div[1]");
            Actions act = new Actions(browser);
            act.MoveToElement(items2);
            act.Click();
             act.SendKeys("papa-ap");
            act.Perform();
       //    Thread.Sleep(1000);
           


          

            var items1 = browser.FindElementByXPath("//*[@id='root']/div/div/div/div/div/form/div[3]/div[2]");
            Actions a = new Actions(browser);
            a.MoveToElement(items1);
            a.Click();
            a.SendKeys("r55555");
            a.Perform();
      //      Thread.Sleep(1000);


 documertn[0].Click();
            
                                         //IWebElement detailFrame1 = browser.FindElement(By.XPath(@"//*[@id='root']/div/div/div/iframe"));

              //browser.SwitchTo().Frame(detailFrame1);


              var doc = browser.FindElementByXPath("//*[@id='react-select-2--list']");

            Actions actions = new Actions(browser);
            actions.MoveToElement(doc);
           
            actions.SendKeys(OpenQA.Selenium.Keys.Down);
            actions.SendKeys(OpenQA.Selenium.Keys.Down);
          

            actions.SendKeys(OpenQA.Selenium.Keys.Enter);
            actions.Build().Perform();
          //  Thread.Sleep(1000);
            //IWebElement items = browser.FindElement(By.CssSelector("[class=c0137_c0142]"));
            // items.Click();
            // items.SendKeys("papa-ap");
           

            browser.FindElementByXPath("//*[@id='root']/div/div/div/div/div/form/div[3]/div[4]/div/div[1]/button").Click();
         //IWebElement items = browser.FindElement(By.XPath("//*[@id='root']/div/div/div/div/div/form/div[3]/div[1]/div/div/div/div/div[2]/div/div/input"));
            //IWebElement item = browser.FindElement(By.XPath("//*[@id='react-select-2--option-0']"));
            //string fgh = items.GetAttribute("value");
            //Thread.Sleep(1000);
            //doc.SendKeys(OpenQA.Selenium.Keys.Down);
            //Thread.Sleep(1000);
            //SelectItem(documertn[0], "inbox.ru");
            //Thread.Sleep(1000);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                notifyIcon1.Visible = true;
                Hide();
            }
        }

        private void notifyIcon1_Click(object sender, EventArgs e)
        {
            notifyIcon1.Visible = false;
            Show(); WindowState = FormWindowState.Normal;
        }

       
    }
}
