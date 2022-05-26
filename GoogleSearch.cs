using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Threading;

namespace SamirCourse
{
    public class GoogleSearch
    {
        public static string SearchParameter(string word)
        {
            string message = "",
                   qa = "qa",
                   priceMin = "50",
                   priceMax = "500";

            try
            {
                var findText = Driver.Instance.FindElement(By.Name("q"));
                findText.SendKeys(word);
                Thread.Sleep(500);

                Actions builder = new Actions(Driver.Instance);
                builder.SendKeys(Keys.Enter).Perform();
                Thread.Sleep(1000);

                var academy387 = Driver.Instance.FindElement(By.CssSelector("#rso div:nth-child(1) div:nth-child(2) .yuRUbf a h3"));
                academy387.Click();
                Thread.Sleep(1000);

                var academy387SearchField = Driver.Instance.FindElement(By.Id("main-search-input"));
                academy387SearchField.SendKeys(qa);
                Thread.Sleep(500);

                builder.SendKeys(Keys.Enter).Perform();
                Thread.Sleep(1000);

                var academy387CategoryIt = Driver.Instance.FindElement(By.CssSelector("#category_id option:nth-child(2)"));
                academy387CategoryIt.Click();
                Thread.Sleep(500);

                var academy387LecturerNemanja = Driver.Instance.FindElement(By.CssSelector("#lecturer_id option:nth-child(214)"));
                academy387LecturerNemanja.Click();
                Thread.Sleep(500);

                var academy387PriceMin = Driver.Instance.FindElement(By.Id("price_min"));
                academy387PriceMin.SendKeys(priceMin);
                Thread.Sleep(500);

                var academy387PriceMax = Driver.Instance.FindElement(By.Id("price_max"));
                academy387PriceMax.SendKeys(priceMax);
                Thread.Sleep(500);

                var academy387Submit = Driver.Instance.FindElement(By.CssSelector("body .page-content .col-xs-12.col-md-3.seach-filters-col input.btn.btn-green.btn-block"));
                academy387Submit.Click();
                Thread.Sleep(500);

            }
            catch (Exception e)
            {
                message += "ERROR!!!" + e.Message;
            }

            return message;
        }

        public static string Lecturers(string word)
        {
            string message = "",
                   qa = "Nemanja";


            try
            {
                var lecturers = Driver.Instance.FindElement(By.CssSelector("#bs-example-navbar-collapse-1 ul.nav.navbar-nav.navbar-right li:nth-child(2) a"));
                lecturers.Click();
                Thread.Sleep(1000);

                var lecturersM = Driver.Instance.FindElement(By.CssSelector("body div.page-content section div:nth-child(1) div.col-xs-12.hidden-xs.hidden-sm  ul li:nth-child(13) a"));
                lecturersM.Click();
                Thread.Sleep(1000);

                var searchLecturer = Driver.Instance.FindElement(By.CssSelector("#lecturers-search"));
                searchLecturer.Click();
                Thread.Sleep(1000);

                var lecturersSearchField = Driver.Instance.FindElement(By.CssSelector("#lecturers-search"));
                lecturersSearchField.SendKeys(qa);
                Thread.Sleep(500);

                Actions builder = new Actions(Driver.Instance);
                builder.SendKeys(Keys.Enter).Perform();
                Thread.Sleep(1000);

                var selectLecturer = Driver.Instance.FindElement(By.CssSelector("#lecturers-container div:nth-child(2) a div.lecturer-image.text-center img"));
                selectLecturer.Click();
                Thread.Sleep(1000);
            }
            catch (Exception e)
            {
                message += "ERROR!!!" + e.Message;
            }

            return message;
        }

        public static string Events(string word)
        {
            string message = "";


            try
            {
                var events = Driver.Instance.FindElement(By.CssSelector("#bs-example-navbar-collapse-1 ul.nav.navbar-nav.navbar-right li:nth-child(3) a"));
                events.Click();
                Thread.Sleep(1000);

                var showMoreEvents = Driver.Instance.FindElement(By.CssSelector("#more-events-btn"));
                showMoreEvents.Click();
                Thread.Sleep(1000);
            }
            catch (Exception e)
            {
                message += "ERROR!!!" + e.Message;
            }

            return message;
        }

        public static string Blog(string word)
        {
            string message = "";


            try
            {
                var blog = Driver.Instance.FindElement(By.CssSelector("#bs-example-navbar-collapse-1 ul.nav.navbar-nav.navbar-right li:nth-child(4) a"));
                blog.Click();
                Thread.Sleep(1000);

                var openBlogTopic = Driver.Instance.FindElement(By.Name("Grafički dizajn kao jedno od najpopularnijih zanimanja današnjice"));
                openBlogTopic.Click();
                Thread.Sleep(1000);
            }
            catch (Exception e)
            {
                message += "ERROR!!!" + e.Message;
            }

            return message;
        }

        public static string Clients(string word)
        {
            string message = "";


            try
            {
                var clients = Driver.Instance.FindElement(By.CssSelector("#bs-example-navbar-collapse-1 ul.nav.navbar-nav.navbar-right li:nth-child(5) a"));
                clients.Click();
                Thread.Sleep(1000);

            }
            catch (Exception e)
            {
                message += "ERROR!!!" + e.Message;
            }

            return message;
        }

        public static string Contact(string word)
        {
            string message = "";


            try
            {
                var contact = Driver.Instance.FindElement(By.CssSelector("#bs-example-navbar-collapse-1 ul.nav.navbar-nav.navbar-right li:nth-child(6) a"));
                contact.Click();
                Thread.Sleep(1000);

                var contactPhoneNumber = Driver.Instance.FindElement(By.CssSelector("body div.page-content  p.contact-info a:nth-child(8)"));
                contactPhoneNumber.Click();
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