using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PersonalPresents.DataBase;
using PersonalPresents.Models;
using System.Diagnostics;
using System.Linq;
using Microsoft.AspNetCore.Authorization;
using Microsoft.Extensions.Logging;
using PersonalPresents.Models.PresentModels;

namespace PersonalPresents.Controllers
{
    public class AdminController : Controller
    {
        private AppDbContent _context;
        public AdminController(AppDbContent context)
        {
            _context = context;
        }
        [HttpGet]
        public async Task<IActionResult> GetAllPresents(){
            var presetns = await _context.Presents.ToListAsync();
            return View(presetns);
        }
        [HttpGet]
        public async Task<IActionResult> Change(int Id){
            Present p = new Present(){Id = Id};
            ViewBag.Gender = await _context.Genders.ToListAsync();
            ViewBag.Festival = await _context.Festivals.ToListAsync();
            ViewBag.Interest = await _context.Interests.ToListAsync();
            ViewBag.Profession = await _context.Professions.ToListAsync();
            ViewBag.RoleForUser = await _context.RoleForUsers.ToListAsync();
            return View(p);
        }
        public IActionResult Change(Present p){
            
        }
    }
}