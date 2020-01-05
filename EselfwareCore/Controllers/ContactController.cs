using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace EselfwareCore.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Contact()
        {
            return View();
        }
        public ActionResult sendContact(sendMessageRequest sendMessage)
        {
            var name = sendMessage.name;
            var email = sendMessage.email;
            var subject = sendMessage.subject;
            var message = sendMessage.message;

            var deger = "Success";
            SendMail(name, email, subject, message);
            return Content(JsonConvert.SerializeObject(deger), "application/json");
        }

        public class sendMessageRequest
        {
            public string name { get; set; }
            public string email { get; set; }
            public string subject { get; set; }
            public string message { get; set; }
        }


        public void SendMail(string name, string email, string subject, string message)
        {
            MailMessage ePosta = new MailMessage();

            ePosta.From = new MailAddress(email);

            ePosta.To.Add("eselfwareinfo@gmail.com");
            ePosta.Subject = "İletişim";

            ePosta.IsBodyHtml = true;
            //ePosta.Body = "<h4>Merhaba ben</h4>"+ "<h4>"+ name + ".</h4>" +"  "+ email + " adresinden"+" Müşteri Talep Formu Oluşturmuş bulunmaktayım"+
            //    "<h6>Telefon Numaram :</h6>"+ telephone+
            //    "<h6>Adresim :</h6>" + address +
            //    "<h6>pointNumber :</h6>" + pointNumber+
            //    "<h6>clientNumber :</h6>" + clientNumber+
            //    "<h6>webCloud :</h6>" + webCloud+
            //    "<h6>deployment : </h6>" + deployment;

            ePosta.Priority = MailPriority.High;

            ePosta.Body = "<h5><strong>" + " İletişim Bilgileri </strong ></h5><strong> Kişi Adı:</strong>" + name + " <br /> <strong> Email:</strong> " + email + " <br /> <strong> Mesajı : </strong> " + message;
            SmtpClient smtp = new SmtpClient();



            smtp.Credentials = new System.Net.NetworkCredential("eselfwareinfo@gmail.com", "Ener4331435");
            smtp.Port = 25;
            smtp.Host = "smtp.gmail.com";
            smtp.EnableSsl = true;
            smtp.Send(ePosta);


        }
    }
}