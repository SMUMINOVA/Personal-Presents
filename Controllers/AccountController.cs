using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PersonalPresents.DataBase;
using PersonalPresents.Models;

namespace PersonalPresents.Controllers
{
    public class AccountController : Controller
    {
        private AppDbContent _context;
        public AccountController(AppDbContent context)
        {
            _context = context;
        }  
        [HttpGet]
        public IActionResult Register(){
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register (RegisterModel model){
            if(ModelState.IsValid){
                User user = await _context.Users.FirstOrDefaultAsync(x => x.Email == model.Email);
                if(user == null){
                    user = new User {
                        Email = model.Email,
                        Password = model.Password
                    };
                    Role userRole = await _context.Roles.FirstOrDefaultAsync(x => x.Name == "user");
                    if(userRole != null){
                        user.Role = userRole;
                        _context.Users.Add(user);
                        await _context.SaveChangesAsync();
                        await Authenticate(user);
                        return RedirectToAction("Index", "Home");
                    }
                }
                else
                    ModelState.AddModelError("","Неверные логин или пароль");
            }
            return View(model);
        }
        [HttpGet]
        public IActionResult Login(){
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginModel model){
            if(ModelState.IsValid){
                User user = await _context.Users
                    .Include(x => x.Role)
                    .FirstOrDefaultAsync(x => x.Email == model.Email && x.Password == model.Password);
                if(user != null){
                    await Authenticate(user);
                    return RedirectToAction("Index", "Home");
                }
                ModelState.AddModelError("","Некорректные логин или пароль");
            }
            return View(model);
        }
        private async Task Authenticate(User user){
            var claims = new List<Claim>{
                new Claim (ClaimsIdentity.DefaultNameClaimType, user.Email),
                new Claim (ClaimsIdentity.DefaultRoleClaimType, user.Role.Name)
            };
            ClaimsIdentity id = new ClaimsIdentity(claims, "ApplicationCookie", ClaimsIdentity.DefaultNameClaimType, ClaimsIdentity.DefaultRoleClaimType);
            await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(id));
        }
    }
}