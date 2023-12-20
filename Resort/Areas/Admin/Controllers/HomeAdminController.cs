using Microsoft.AspNetCore.Mvc;
using Resort.Models;
using Resort.Repo.IReponsitories;

namespace Resort.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class HomeAdminController : Controller
    {
		User user = null;
        private readonly IUserRepo _userRepo;
        private readonly IUserDetailRepo _userDetailRepo;
        public HomeAdminController(IUserRepo userRepo,IUserDetailRepo userDetailRepo)
        {
            _userRepo= userRepo;
            _userDetailRepo = userDetailRepo;
        }
		[Route("Admin/Home")]
        public async Task<IActionResult> IndexAdmin(string email, string pass)
        {
			var user = await _userRepo.GetUserByEmailAndPass(email, pass);
			if (user != null)
			{
                ViewData["userDetail"] = await _userDetailRepo.GetUserDetailByIdUser(user.IdUser);
				return View(user);
			}
			else
			{
                return BadRequest();
			}
		}

        [Route("Admin/Login")]
        public IActionResult AdminLoginAccount()
        {
            return View();
        }

        [Route("Admin/Sign")]
        public IActionResult AdminSignAccount()
        {
            return View();
        }

        [Route("Admin/ForgotPassword")]
        public IActionResult ForGotPassword()
        {
            return View();
        }
    }
}
