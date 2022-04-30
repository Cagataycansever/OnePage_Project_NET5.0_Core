using CoreProject.Areas.Writer.Models;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace CoreProject.Areas.Writer.Controllers
{
    [Area("Writer")]
    public class RegisterController : Controller
    {
        private readonly UserManager<WriterUser> _userManager;
        public RegisterController(UserManager<WriterUser> userManager)
        {
            _userManager = userManager;
        }

        public IActionResult Index()
        {
            return View(new UserRegisterVM());
        }
        [HttpPost]
        public async Task<IActionResult> Index(UserRegisterVM userRegister)
        {            
                WriterUser writerUser = new WriterUser()
                {
                    Name = userRegister.Name,
                    SurName = userRegister.SurName,
                    Email=userRegister.Mail,
                    UserName = userRegister.UserName,
                    Image=userRegister.ImageURL
                };
                if(userRegister.Password == userRegister.ConfirmPassword)
                {
                    var results = await _userManager.CreateAsync(writerUser, userRegister.Password);
                
                    if (results.Succeeded)
                    {
                        return RedirectToAction("Index", "Login");
                    }
                    else
                    {
                        foreach(var item in results.Errors)
                        {
                            ModelState.AddModelError("", item.Description);
                        }
                    }
                }


            return View();
        }
    }
}
