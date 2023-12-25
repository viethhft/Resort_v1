using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Resort.Models;
using Resort.Repo.IReponsitories;
using Resort.Ser.IServices;
using Resort.Validate;
using System.Net;
using System.Net.Mail;
using System.Net.WebSockets;

namespace Resort.Areas.Admin.Controllers
{
	[Area("Admin")]
	public class AccountAdminController : Controller
	{
		User user = null;
		private readonly IUserSer _userSer;
		private readonly IUserDetailSer _userDetailSer;
		private readonly IEmailSendSer _emailSendSer;
		public AccountAdminController(IUserSer userSer, IUserDetailSer userDetailSer, IEmailSendSer emailSendSer)
		{
			_userSer = userSer;
			_userDetailSer = userDetailSer;
			_emailSendSer = emailSendSer;
		}

		public async Task<IActionResult> Login(string email, string pass)
		{
			var user = await _userSer.GetUserByEmailAndPass(email, pass);
			if (user != null)
			{
				ViewData["userDetail"] = await _userDetailSer.GetUserDetailByIdUser(user.IdUser);
				var userIn4 = JsonConvert.SerializeObject(await _userSer.GetUserById(user.IdUser));
				var userDetailIn4 = JsonConvert.SerializeObject(ViewData["userDetail"]);
				HttpContext.Session.SetString("user", userIn4);
				HttpContext.Session.SetString("userDetail", userDetailIn4);
				return RedirectToAction("IndexAdmin", "HomeAdmin");
			}
			else
			{
				return RedirectToAction("AdminLoginAccount", "HomeAdmin");
			}
		}

		public async Task<IActionResult> Sign(string name, string email, string pass, string gender, string date)
		{
			if (name != null && email != null && pass != null && gender != null && date != null)
			{
				User user = new User() { Email = email, Password = ValidateRegex.ReversePass(pass), IdRole = 2, Status = 1 };
				await _userSer.AddUser(user);
				user = await _userSer.GetUserByEmailAndPass(email, pass);
				UserDetail userDetail = new UserDetail() { IdUser = user.IdUser, Description = "", Gender = gender == "Nam" ? 0 : 1, DoB = date, UserName = name, ImageProfile = gender == "Nam" ? "6.jpg" : "7.jpg" };
				await _userDetailSer.AddUserDetail(userDetail);
				return RedirectToAction("AdminLoginAccount", "HomeAdmin");
			}
			else
			{
				return RedirectToAction("AdminSignAccount", "HomeAdmin");
			}
		}

		[Route("Admin/SendCode")]
		public async Task<string> SendCodeForEmail(string email)
		{
			if (email==null)
			{
				return "Vui lòng nhập email của bạn";
			}
			else
			{
				var emailFrom = await _emailSendSer.GetEmailSend();
				var code = ValidateRegex.CreateCodeAccept();
				MailAddress mailFrom = new MailAddress(emailFrom.Email, "Review Resort");
				MailAddress mailTo = new MailAddress(email);
				MailMessage message = new MailMessage(mailFrom,mailTo);
				message.Subject = "Mã xác nhận ";
				message.Body = $"Mã xác nhận của bạn là: <b>{code}</b> <br>" +
							   $"Mã xác nhận chỉ có hiệu lực trong 5 phút! <br>" +
							   $"Liên hệ với chúng tôi qua Email: binhlonchammamtom@gmail.com<br>" +
							   $"hoặc liên hệ trực tiếp qua 0124567821 để được hỗ trợ trực tiếp";
				message.IsBodyHtml = true;
				message.Priority = MailPriority.High;
				SmtpClient client = new SmtpClient();
				client.Host = "smtp.gmail.com";
				client.Port = 587;
				client.EnableSsl = true;
				client.DeliveryMethod = SmtpDeliveryMethod.Network;
				client.UseDefaultCredentials = false;
				client.Credentials = new NetworkCredential(emailFrom.Email, emailFrom.PassWord);
				await client.SendMailAsync(message);
				return $"Mã xác thực đã gửi tới email của bạn!! + {code}";
			}
		}
		
	}
}
