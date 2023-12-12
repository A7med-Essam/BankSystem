using System.Net;
using System.Net.Mail;

namespace BankSystem.BL.Helper
{
    public static class MailHelper
    {
        public static void Send()
        {
            SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
            smtp.EnableSsl = true;
            smtp.Credentials = new NetworkCredential("madimodicom2@gmail.com", "hbrd mdrw frfb fvyi");
            //MailMessage mailMessage = new MailMessage();
            //mailMessage.From = "madimodicom2@gmail.com";
            //mailMessage.To = "madimodicom3@gmail.com";
            //mailMessage.Body =
            //mailMessage.CC =
            //mailMessage.Subject =
            smtp.Send("madimodicom2@gmail.com", "madimodicom3@gmail.com", "test subject", "test body");
        }
    }
}
