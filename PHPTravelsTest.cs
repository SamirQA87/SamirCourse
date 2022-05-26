using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SamirCourse
{
    [TestClass]
    public class PHPTravels
    {
        [TestInitialize]
        public void Init()
        {
            TestArguments parameters = new TestArguments();

            int a = int.Parse(parameters.browser);

            Driver.Initialize(a);
            Functions.WriteInto("End of Init");

        }
        [TestMethod]
        public void TestMethod1()
        {
            string subject = "",
                   body = "";

            TestArguments parameters = new TestArguments();
            string URL = parameters.url;

            OpenUrl.GoTo(URL);

            string SearchParameter = PHPGoogle.PHPGoogleSearch("PHP Travels");

            string OpenCompany = PHPGoogle.Company("");

            string OpenCompanyBlog = PHPGoogle.OpenCompanyBlog("");

            string BlogSearch = PHPGoogle.BlogSearch("can you travel the world with crypto");

            string Categories = PHPGoogle.Categories("");



        }
 

        [TestCleanup]
        public void Cleanup()

        {
         Driver.Close();
        }
    }
}
