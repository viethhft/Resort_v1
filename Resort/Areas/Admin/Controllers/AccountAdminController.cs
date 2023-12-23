using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Resort.Models;
using Resort.Repo.IReponsitories;
using Resort.Ser.IServices;
using Resort.Validate;

namespace Resort.Areas.Admin.Controllers
{
	[Area("Admin")]
	public class AccountAdminController : Controller
	{
		User user = null;
		private readonly IUserSer _userSer;
		private readonly IUserDetailSer _userDetailRepo;
		public AccountAdminController(IUserSer userSer, IUserDetailSer userDetailSer)
		{
			_userSer = userSer;
			_userDetailRepo = userDetailSer;
		}

		public async Task<IActionResult> Login(string email, string pass)
		{
			var user = await _userSer.GetUserByEmailAndPass(email, pass);
			if (user != null)
			{
				ViewData["userDetail"] = await _userDetailRepo.GetUserDetailByIdUser(user.IdUser);
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
				user=await _userSer.GetUserByEmailAndPass(email,pass);
				UserDetail userDetail = new UserDetail() { IdUser = user.IdUser, Description = "", Gender = gender == "Nam" ? 0 : 1, DoB = date, UserName = name, ImageProfile = gender == "Nam" ? "6.jpg" : "7.jpg" };
				await _userDetailRepo.AddUserDetail(userDetail);
				return RedirectToAction("AdminLoginAccount", "HomeAdmin");
			}
			else
			{
				return RedirectToAction("AdminSignAccount", "HomeAdmin");
			}
		}
	}
}
