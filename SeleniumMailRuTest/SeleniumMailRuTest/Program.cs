

namespace SeleniumMailRuTest
{
    class Program
    {
        static void Main(string[] args)
        {
            PageGmail pageGmail = new PageGmail();
            pageGmail.Login();
            pageGmail.SendMessage();
            pageGmail.Quit();

            PageMail pageMail = new PageMail();
            pageMail.Login();
            pageMail.ReadMessage();
            pageMail.Quit();

        }
    }
}
