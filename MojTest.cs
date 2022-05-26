using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SamirCourse
{
    [TestClass]
    public class MojTest
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

            string SearchParameter = GoogleSearch.SearchParameter("Academy387");

            string Lecturers = GoogleSearch.Lecturers("Nemanja Pusara");

            string Events = GoogleSearch.Events("");

            string Blog = GoogleSearch.Blog("");

            string Clients = GoogleSearch.Clients("");

            string Contact = GoogleSearch.Contact("");

            if (!SearchParameter.Contains("Error") && (!Lecturers.Contains("Error")) && (!Events.Contains("Error")) && (!Blog.Contains("Error")) && (!Clients.Contains("Error")) && (!Contact.Contains("Error")))
            {
                subject = "Passed!!!" + subject;
                body = "Test has Passed" + "\n" + SearchParameter + Lecturers + Events + Blog + Clients + Contact;
            }
            else
            {
                subject = "Failed!!!" + subject;
                body = SearchParameter + Lecturers + Events + Blog + Clients + Contact;
            }

            Functions.SendEmailAttachment(subject, body);

            Assert.IsTrue(subject.Contains("Passed"));

        }

        [TestCleanup]
        public void Cleanup()
        {
            Driver.Close();
        }
    }
}