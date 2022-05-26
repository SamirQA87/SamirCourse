using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Threading;

namespace SamirCourse
{
    public class PHPGoogle
    {
        public static string PHPGoogleSearch(string word)
        {
            string message = "";


            try
            {
                var findText = Driver.Instance.FindElement(By.Name("q"));
                findText.SendKeys(word);
                Thread.Sleep(500);

                Actions builder = new Actions(Driver.Instance);
                builder.SendKeys(Keys.Enter).Perform();
                Thread.Sleep(1000);

                var phpTravels = Driver.Instance.FindElement(By.CssSelector("#rso > div:nth-child(1) > div > div:nth-child(1)  div:nth-child(1) div.NJo7tc.Z26q7c.jGGQ5e a h3"));
                phpTravels.Click();
                Thread.Sleep(1000);

                var openCompany = Driver.Instance.FindElement(By.CssSelector("body header nav div.lvl-0.dropdown.headerLang.open span"));
                openCompany.Click();
                Thread.Sleep(1000);

            }
            catch (Exception e)
            {
                message += "ERROR!!!" + e.Message;
            }

            return message;
        }
        public static string Company(string word)
        {
            string message = "";

            try
            {
                var openCompany = Driver.Instance.FindElement(By.CssSelector("body > header > div > nav > div.lvl-0.dropdown.headerLang > span"));
                openCompany.Click();
                Thread.Sleep(1000);

            }
            catch (Exception e)
            {
                message += "ERROR!!!" + e.Message;
            }

            return message;
        }

        public static string OpenCompanyBlog(string word)
        {
            string message = "";

            try
            {
                var openCompanyBlog = Driver.Instance.FindElement(By.CssSelector("body .lvl-0.dropdown.headerLang a:nth-child(1)"));
                openCompanyBlog.Click();
                Thread.Sleep(1000);

            }
            catch (Exception e)
            {
                message += "ERROR!!!" + e.Message;
            }

            return message;
        }

        public static string BlogSearch(string word)
        {
            string message = "",
            qa = "can you travel the world with crypto";

            try
            {
                var blogSearch = Driver.Instance.FindElement(By.CssSelector("#select2-5tvv-container span"));
                blogSearch.Click();
                Thread.Sleep(1000);

                var blogSearchbyName = Driver.Instance.FindElement(By.CssSelector("#lecturers-search"));
                blogSearchbyName.SendKeys(qa);
                Thread.Sleep(500);

                var blogSearchResults = Driver.Instance.FindElement(By.CssSelector("#select2-tstr-results > li a"));
                blogSearchResults.Click();
                Thread.Sleep(1000);

            }
            catch (Exception e)
            {
                message += "ERROR!!!" + e.Message;
            }

            return message;
        }

        public static string Categories(string word)
        {
            string message = "";

            try
            {
                var openCategory = Driver.Instance.FindElement(By.XPath("/html/body/header/nav/div/div"));
                openCategory.Click();
                Thread.Sleep(1000);

                var blogSearchResults = Driver.Instance.FindElement(By.CssSelector("#select2-5tvv-results > li a div.select2-result-repository__meta div.select2-result-repository__title"));
                blogSearchResults.Click();
                Thread.Sleep(1000);

            }
            catch (Exception e)
            {
                message += "ERROR!!!" + e.Message;
            }

            return message;
        }

    }
}
