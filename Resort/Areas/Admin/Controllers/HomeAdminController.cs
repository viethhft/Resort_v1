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
        public HomeAdminController(IUserRepo userRepo)
        {
            _userRepo= userRepo;
        }
		[Route("Admin/Home")]
        public async Task<IActionResult> IndexAdmin(string email, string pass)
        {
			var user = await _userRepo.GetUserByEmailAndPass(email, pass);
			if (user != null)
			{
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
    }
}
