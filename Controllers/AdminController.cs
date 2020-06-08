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
    public class AdminController
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
    }
}