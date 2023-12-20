using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Resort.Models;
using Resort.Repo.IReponsitories;

namespace Resort.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AccountAdminController : Controller
    {
        User user = null;
        private readonly IUserRepo _userRepo;
        private readonly IUserDetailRepo _userDetailRepo;
        public AccountAdminController(IUserRepo userRepo, IUserDetailRepo userDetailRepo)
        {
            _userRepo = userRepo;
            _userDetailRepo = userDetailRepo;
        }

        public async Task<IActionResult> Index(string email, string pass)
        {
            var user = await _userRepo.GetUserByEmailAndPass(email, pass);
            if (user != null)
            {
                ViewData["userDetail"] = await _userDetailRepo.GetUserDetailByIdUser(user.IdUser);
                var userIn4 = JsonConvert.SerializeObject(await _userRepo.GetUserById(user.IdUser));
                var userDetailIn4 = JsonConvert.SerializeObject(ViewData["userDetail"]);
                HttpContext.Session.SetString("user", userIn4);
                HttpContext.Session.SetString("userDetail", userDetailIn4);
                return RedirectToAction("IndexAdmin","HomeAdmin",user);
            }
            else
            {
                return BadRequest();
            }
        }
    }
}
