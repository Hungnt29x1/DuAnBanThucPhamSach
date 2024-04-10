using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using WebShop.Models;
using WebShop.ModelViews;

namespace WebShop.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly dbMarketsContext _context;

        public HomeController(ILogger<HomeController> logger, dbMarketsContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            HomeViewVM model = new HomeViewVM();

            var lsProducts = _context.Products.AsNoTracking()
                .Where(x => x.Active == true && x.HomeFlag == true)
                .OrderByDescending(x => x.DateCreated)
                .ToList();

            List<ProductHomeVM> lsProductViews = new List<ProductHomeVM>();
            var lsCats = _context.Categories
                .AsNoTracking()
                .Where(x => x.Published == true)
                .OrderByDescending(x => x.Ordering)
                .ToList();

            foreach (var item in lsCats)
            {
                ProductHomeVM productHome = new ProductHomeVM();
                productHome.category = item;
                productHome.lsProducts = lsProducts.Where(x => x.CatId == item.CatId).ToList();
                lsProductViews.Add(productHome);

                var quangcao = _context.QuangCaos
                    .AsNoTracking()
                    .FirstOrDefault(x => x.Active == true);

                var TinTuc = _context.TinDangs
                    .AsNoTracking()
                    .Where(x => x.Published == true && x.IsNewfeed == true)
                    .OrderByDescending(x => x.CreatedDate)
                    .Take(3)
                    .ToList();
                model.Products = lsProductViews;
                model.quangcao = quangcao;
                model.TinTucs = TinTuc;
                ViewBag.AllProducts = lsProducts;   
            }
            return View(model);
        }

        [Route("lien-he.html", Name = "Contact")]
        public IActionResult Contact()
        {
            return View();
        }

        [HttpPost]
        [Route("lien-he.html",Name ="Contact")]
        public IActionResult Contact(WebShop.ModelViews.ContactModel contact)
        {
            if (ModelState.IsValid)
            {
                // Gửi email
                bool emailSent = SendEmail(contact);

                if (emailSent)
                {
                    ViewBag.SuccessMessage = "Cảm ơn bạn đã liên hệ chúng tôi!";
                }
                else
                {
                    ViewBag.ErrorMessage = "Có lỗi xảy ra khi gửi email.";
                }
            }

            return View(contact);
        }

        private bool SendEmail(ContactModel contact)
        {
            try
            {
                string smtpServer = "smtp.gmail.com";
                int smtpPort = 587;
                string smtpUsername = "hungntph17579@fpt.edu.vn"; // Thay thế bằng địa chỉ email thực tế
                string smtpPassword = "rzzkasitfwitfxhi"; // Thay thế bằng mật khẩu email thực tế

                MailMessage mail = new MailMessage();
                mail.From = new MailAddress(smtpUsername);
                mail.To.Add(contact.Email); // Thay thế bằng địa chỉ email người nhận
                mail.Subject = contact.Subject;
                mail.Body = $@"<!DOCTYPE html>
<html>
<head>
    <style>
        body {{
            font-family: Arial, sans-serif;
            margin: 0;
            padding: 0;
            background-color: #f4f4f4;
        }}
        .container {{
            max-width: 600px;
            margin: 0 auto;
            background-color: #ffffff;
            box-shadow: 0 2px 4px rgba(0, 0, 0, 0.1);
        }}
        .header {{
            background-color: #3498db;
            color: #fff;
            text-align: center;
            padding: 20px 0;
        }}
        .content {{
            padding: 20px;
        }}
        .footer {{
            text-align: center;
            margin-top: 20px;
            padding: 10px 0;
            background-color: #f4f4f4;
        }}
    </style>
</head>
<body>
    <div class=""container"">
        <div class=""header"">
            <h1>Cảm ơn bạn đã phản hồi!</h1>
        </div>
        <div class=""content"">
            <p>Xin chào <strong>{{contact.FullName}}</strong>,</p>
            <p>Cảm ơn bạn đã phản hồi. Chúng tôi đã nhận được thông tin của bạn và sẽ xem xét nó cẩn thận.</p>
            <p>Chi tiết phản hồi:</p>
            <ul>
                <li><strong>Email:</strong> {contact.Email}</li>
                <li><strong>Tiêu đề:</strong> {contact.Subject}</li>
                <li><strong>Mô tả:</strong> {contact.Description}</li>
            </ul> 
           <p>Chúng tôi sẽ liên hệ với bạn trong thời gian sớm nhất có thể.</p>
            <p>Xin cảm ơn và chúc bạn một ngày vui vẻ!</p>
        </div>
        <div class=""footer"">
            <p>© 2023 Your Company. All rights reserved.</p>
        </div>
    </div>
</body>
</html>
";
                mail.IsBodyHtml = true;
                SmtpClient smtpClient = new SmtpClient(smtpServer, smtpPort);
                smtpClient.UseDefaultCredentials = false;
                smtpClient.Credentials = new NetworkCredential(smtpUsername, smtpPassword);
                smtpClient.EnableSsl = true;

                smtpClient.Send(mail);

                return true;
            }
            catch (Exception ex)
            {
                // Log lỗi hoặc xử lý lỗi tùy theo yêu cầu
                return false;
            }
        }

        [Route("gioi-thieu.html", Name = "About")]
        public IActionResult About()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
