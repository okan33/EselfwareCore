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
    public class DealersFormController : Controller
    {
        public IActionResult DealersForm()
        {
            return View();
        }

        public ActionResult DealersCode(dealerReg dealerReg)
        {
            var name = dealerReg.name;
            var title = dealerReg.title;
            var address = dealerReg.projectAdress;
            var city = dealerReg.projectCity;
            var telephone = dealerReg.telephone;
            var email = dealerReg.emailOne;
            var date = dealerReg.date;
            var pointNumber = dealerReg.pointNumber;
            var clientNumber = dealerReg.clientNumber;
            var webCloud = dealerReg.webCloud;
            var deployment = dealerReg.deployment;
            var dealerCode = dealerReg.dealerCode;

            SendMail(name, title, address, city, telephone, email, date, pointNumber, clientNumber, webCloud, deployment, dealerCode);

            var deger = "Success";
            return Content(JsonConvert.SerializeObject(deger), "application/json");
        }


        public class dealerReg
        {
            public string name { get; set; }
            public string title { get; set; }
            public string projectAdress { get; set; }
            public string projectCity { get; set; }
            public string telephone { get; set; }
            public string emailOne { get; set; }
            public string date { get; set; }
            public string pointNumber { get; set; }
            public string clientNumber { get; set; }
            public string webCloud { get; set; }
            public string deployment { get; set; }

            public string dealerCode { get; set; }
        }

        public void SendMail(string name, string title, string address, string city, string telephone, string email, string date, string pointNumber, string clientNumber, string webCloud, string deployment, string dealerCode)
        {
            MailMessage ePosta = new MailMessage();

            ePosta.From = new MailAddress(email);

            ePosta.To.Add("eselfwareinfo@gmail.com");
            ePosta.Subject = "Firma Talep Formu";

            ePosta.IsBodyHtml = true;
            //ePosta.Body = "<h4>Merhaba ben</h4>"+ "<h4>"+ name + ".</h4>" +"  "+ email + " adresinden"+" Müşteri Talep Formu Oluşturmuş bulunmaktayım"+
            //    "<h6>Telefon Numaram :</h6>"+ telephone+
            //    "<h6>Adresim :</h6>" + address +
            //    "<h6>pointNumber :</h6>" + pointNumber+
            //    "<h6>clientNumber :</h6>" + clientNumber+
            //    "<h6>webCloud :</h6>" + webCloud+
            //    "<h6>deployment : </h6>" + deployment;

            ePosta.Priority = MailPriority.High;

            ePosta.Body = "<h5><strong>" + " İletişim Bilgileri </strong ></h5><strong> Kişi Adı:</strong>" + name + " <br /> <strong> Email:</strong> " + email + " <br /> <strong> Adresi : </strong> " + address + " <br /> <strong> Telefon : </strong> " + telephone + " <br /><strong> Point Number:</strong>" + pointNumber + " <br /><strong> Client Number:</strong>" + clientNumber + " <br /><strong>Web Cloud:</strong>" + webCloud + " <br /><strong>Deployment:</strong>" + deployment;

            SmtpClient smtp = new SmtpClient();



            smtp.Credentials = new System.Net.NetworkCredential("eselfwareinfo@gmail.com", "Ener4331435");
            smtp.Port = 25;
            smtp.Host = "smtp.gmail.com";
            smtp.EnableSsl = true;
            smtp.Send(ePosta);

        }
    }
}