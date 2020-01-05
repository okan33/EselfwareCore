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
    public class PricingFormController : Controller
    {
        public IActionResult PricingForm()
        {
            var date = DateTime.Today.ToString("d");
            ViewBag.Date = date;
            return View();
        }

        public ActionResult customerRequest(customerReg customerInfo)
        {
            var name = customerInfo.name;
            var title = customerInfo.title;
            var address = customerInfo.projectAdress;
            var city = customerInfo.projectCity;
            var telephone = customerInfo.telephone;
            var email = customerInfo.emailOne;
            var date = customerInfo.date;
            var pointNumber = customerInfo.pointNumber;
            var clientNumber = customerInfo.clientNumber;
            var webCloud = customerInfo.webCloud;
            var deployment = customerInfo.deployment;

            SendMail(name, title, address, city, telephone, email, date, pointNumber, clientNumber, webCloud, deployment);
            //SendMailTo(name, email);
            var deger = "Success";
            return Content(JsonConvert.SerializeObject(deger), "application/json");
        }

        public class customerReg
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
        }

        public void SendMail(string name, string title, string address, string city, string telephone, string email, string date, string pointNumber, string clientNumber, string webCloud, string deployment)
        {
            try
            {
                MailMessage ePosta = new MailMessage();

                ePosta.From = new MailAddress(email);

                ePosta.To.Add("eselfwareinfo@gmail.com");
                ePosta.Subject = "Müşteri Talep Formu";

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
            catch (Exception ex)
            {
                 
            }
        }

        public void SendMailTo(string name, string email)
        {
            try
            {
                MailMessage ePosta = new MailMessage();

                ePosta.From = new MailAddress("eselfwareinfo@gmail.com");

                ePosta.To.Add(email);
                ePosta.Subject = "Teşekkürler";

                ePosta.IsBodyHtml = true; 

                ePosta.Priority = MailPriority.High;

               // ePosta.Body = "<table style='background-color:black;padding:10px;width:620px;text-align:left;border-top:none,border-bottom:none;border-left:10px solid #155ca9;border-right:10px solid #155ca9' width='620' cellspacing='0' cellpadding='0'><tbody><tr><td><table style='background-color:#ffffff;' width='100%' cellspacing='0' cellpadding = '0'>  <tbody><tr><td style = 'padding: 10px;'><a href = 'http://enerotomasyon.com.tr/' target = '_blank' data - saferedirecturl = '' ></a></td><td style = 'color: #1a2640; font-family: Arial; font-size: 13px;' align = 'right' > +90 532 430 6484 | +90 232 433 1484 | +90 232 433 1437<span style = 'color: #a5b9c5; font-size: 24px;' >|</span> <a style = 'text-decoration: none; color: #1a2640;' href = 'http://enerotomasyon.com.tr/iletisim' target = '_blank' data - saferedirecturl = 'http://enerotomasyon.com.tr/iletisim'> www.enerotomasyon.com.tr </a> &nbsp; &nbsp; &nbsp;</td></tr><tr><td colspan = '2' ><img src = 'http://www.enerotomasyon.com.tr/images/logo.png' alt = '' style=width = '100px'; height = '33px' /></td></tr><tr><td style = 'width:20;padding: 10px; font-size: 12px; font-family: Arial;' colspan = '2' ><p style = 'margin: 0 0 10px 0;' > Sayın <strong>" + name + "</strong>,</p><p style = 'margin: 0 0 10px 0;' > " + DateTime.Now.ToString() + " tarihinde, " + " tarafınızca <strong> " + "</strong>fiyat talep formu doldurulmuştur.</p>";

                string mailbody = "<table style='background-color:#fff;padding:10px;width:620px;text-align:left;border-top:none,border-bottom:none;border-left:10px solid #155ca9;border-right:10px solid #155ca9' width='620' cellspacing='0' cellpadding='0'><tbody><tr><td><table style='background-color:#ffffff;' width='100%' cellspacing='0' cellpadding = '0'>  <tbody><tr><td style = 'padding: 10px;'><a href = 'http://www.saltur.com.tr' target = '_blank' data - saferedirecturl = '' > <img src = 'http://www.saltur.com.tr/images/salturbuyuklogo.png' alt = '' width = '200' height = '68' border = '0' /></a></td><td style = 'color: #1a2640; font-family: Arial; font-size: 13px;' align = 'right' > +90 (312) 425 13 33 <span style = 'color: #a5b9c5; font-size: 24px;' >|</span> <a style = 'text-decoration: none; color: #1a2640;' href = 'http://www.saltur.com.tr/iletisim' target = '_blank' data - saferedirecturl = 'http://www.saltur.com.tr/iletisim'> www.saltur.com.tr </a> &nbsp; &nbsp; &nbsp;</td></tr><tr><td colspan = '2' ><img src = 'http://www.saltur.com.tr/images/ustborder.png' alt = '' /></td></tr><tr><td style = 'padding: 10px; font-size: 12px; font-family: Arial;' colspan = '2' ><p style = 'margin: 0 0 10px 0;' > Sayın <strong>" + "asd" + "</strong>,</p><p style = 'margin: 0 0 10px 0;' > " + DateTime.Now.ToString() + " tarihinde, " + "asd" + " IP adresinden <strong> " + "asd" + "</strong> tur' u için ödeme işlemi yaptınız.Ödeme işleminiz ile ilgili en kısa sürede tarafınıza geri dönüş yapılacaktır.</p><h5><strong>Tur Bilgileri </strong></h5><strong> Tur Adı:</strong> " + "asd" + " <br/><strong> Tur Tarihi:</strong> " + "asd" + " <br /> <strong> Yetişkin Sayısı:</strong>  " + "asd" + " <br /> <strong>Çocuk Sayısı:</strong>  " + "asd" + " <br /><strong>Rezarvasyon Kodu:</strong style='color:red'>  " + "asd" + "<h5><strong> İletişim Bilgileri </strong ></h5><strong> Kişi Adı:</strong>" + "asd" + " <br /> <strong> Telefon No:</strong> " + "asd" + " <br /> <strong> E-mail Adresi </strong> " + email + " <br />  <strong> Adres: </strong> " + "asd" + " <br /> <strong> Yolcu istekleri: </strong> " + "asd" + " <h4>Yolcu Bilgileri</h4>";


                string mailbody2 = "";

             
                        mailbody2 = "<h5><strong>" + "asd" + " .Yolcu Bilgileri </strong ></h5><strong> Kişi Adı:</strong>" + "asd" + " <br /> <strong> Tc No:</strong> " + "asd" + " <br /> <strong> Doğum Tarihi </strong> " + "asd" + " <br /><strong> Cinsiyet:</strong>" + "asd" + " <br /><strong> Pasaport No:</strong>" + "asd" + "";
                  
                        mailbody2 += "<h5><strong>" + "asd" + " .Yolcu Bilgileri </strong ></h5><strong> Kişi Adı:</strong>" + "asd" + " <br /> <strong> Tc No:</strong> " + "asd" + " <br /> <strong> Doğum Tarihi </strong> " + "asd" + " <br /><strong> Cinsiyet:</strong>" + "asd" + " <br /><strong> Pasaport No:</strong>" + "asd" + " <br />";
               
                string mailbody3 = " <br /><p style = 'margin: 0 0 0 0;' >Her türlü sorunuzda bize <a style = 'color: #000000;' href = 'mailto:info@saltur.com.tr' target = '_blank' > info@saltur.com.tr </a> adresinden ulaşabilir veya<a href = 'tel:+90(312)4251333' target = '_blank' > +90(312) 425 13 33 </a> nolu telefondan müşteri hizmetleri ile görüşebilirsiniz.</p><p style = 'margin: 20px 0 0 0;' > Saygılarımızla,</p><p style = 'margin: 5px 0 0 0;' > Saltur Turizm Müşteri Hizmetleri</p></td></tr><tr><td colspan = '2' ><img src = 'http://www.saltur.com.tr/images/ustborder.png' alt = '' /></td></tr><tr><td style = 'padding: 10px; color: #808080; font-size: 12px;' colspan = '2'><p style = 'margin: 0 0 0 0; font-family: Arial;' > Copyright &copy; Saltur.com.tr Tüm hakları saklıdır.</p></td></tr></tbody></table></td></tr></tbody></table> ";

                ePosta.Body = mailbody + mailbody2 + mailbody3;


                //< img src = 'https://www.eselfware.com/Content/Template/eself.png' alt = '' style = width = '100px'; height = '33px' />


                SmtpClient smtp = new SmtpClient();



                smtp.Credentials = new System.Net.NetworkCredential("eselfwareinfo@gmail.com", "Ener4331435");
                smtp.Port = 25;
                smtp.Host = "smtp.gmail.com";
                smtp.EnableSsl = true;
                smtp.Send(ePosta);
                 
            }
            catch (Exception ex)
            {

            }
        }
    }
}