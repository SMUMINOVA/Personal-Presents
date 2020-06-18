using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting.Internal;
using PersonalPresents.DataBase;
using PersonalPresents.Models.PresentModels;

namespace PersonalPresents.Controllers
{
    public class AdminController : Controller
    {
        private AppDbContent _context;
        private IWebHostEnvironment _hostEnvironment;
        public AdminController(AppDbContent context, IWebHostEnvironment hostEnvironment)
        {
            _hostEnvironment = hostEnvironment;
            _context = context;
        }
        [Authorize(Roles = "admin")]
        [HttpGet]
        public async Task<IActionResult> GetAllPresents(){
            var presetns = await _context.Presents.ToListAsync();
            return View(presetns);
        }
        [HttpGet] 
        public async Task<IActionResult> Add(){
            ViewBag.Gender = await _context.Genders.ToListAsync();
            ViewBag.Festival = await _context.Festivals.ToListAsync();
            ViewBag.Interest = await _context.Interests.ToListAsync();
            ViewBag.Profession = await _context.Professions.ToListAsync();
            ViewBag.RoleForUser = await _context.RoleForUsers.ToListAsync();
            return View();            
        }
        [HttpPost]
        public async Task<IActionResult> Add(Present p){
            string wwRootPath = _hostEnvironment.WebRootPath;
            string file = Path.GetFileNameWithoutExtension(p.ImgFile.FileName);
            string extension = Path.GetExtension(p.ImgFile.FileName);
            file = file + DateTime.Now.ToString("yymmssfff") + extension;
            p.Img = file;
            var path = Path.Combine(wwRootPath + "/img/", file);
            var fileStream = new FileStream(path, FileMode.Create);
            await p.ImgFile.CopyToAsync(fileStream);
            var gender = await _context.Genders.FirstOrDefaultAsync(x => x.Id == p.GenderId);
            p.gender = gender;
            var role = await _context.RoleForUsers.FirstOrDefaultAsync(x => x.Id == p.RoleId);
            p.role = role;
            var fest = await _context.Festivals.FirstOrDefaultAsync(x => x.Id == p.FestivalId);
            p.festival = fest;
            var interest = await _context.Interests.FirstOrDefaultAsync(x => x.Id == p.InterestId);
            p.interest = interest;
            var prof = await _context.Professions.FirstOrDefaultAsync(x => x.Id == p.ProfessionId);
            p.profession = prof;
            _context.Presents.Add(p);
            gender.Presents.Add(p);
            prof.Presents.Add(p);
            interest.Presents.Add(p);
            fest.Presents.Add(p);
            role.Presents.Add(p);
            await _context.SaveChangesAsync();
            return RedirectToAction("GetAllPresents");
        }
        [HttpGet]
        public async Task<IActionResult> Change(int Id){
            Present p = await _context.Presents.FindAsync(Id);
            return View(p);
        }
        [HttpPost]
        public async Task<IActionResult> Change(Present p){
            Present present = await _context.Presents.FirstOrDefaultAsync(x => x.Id == p.Id);
            present.Name = p.Name;
            present.Price = p.Price;
            present.Description = p.Description;
            await _context.SaveChangesAsync();
            return RedirectToAction("GetAllPresents");
        }
        public async Task<IActionResult> Delete(int Id){
            Present p = await _context.Presents.FirstOrDefaultAsync(x => x.Id == Id);
            _context.Presents.Remove(p);
            var gender = await _context.Genders.FirstOrDefaultAsync(x => x.Id == p.GenderId);
            gender.Presents.Remove(p);
            var role = await _context.RoleForUsers.FirstOrDefaultAsync(x => x.Id == p.RoleId);
            role.Presents.Remove(p);
            var fest = await _context.Festivals.FirstOrDefaultAsync(x => x.Id == p.FestivalId);
            fest.Presents.Remove(p);
            var interest = await _context.Interests.FirstOrDefaultAsync(x => x.Id == p.InterestId);
            interest.Presents.Remove(p);
            var prof = await _context.Professions.FirstOrDefaultAsync(x => x.Id == p.ProfessionId);
            prof.Presents.Remove(p);
            await _context.SaveChangesAsync();
            return RedirectToAction("GetAllPresents");
        }
        public async Task<IActionResult> Orders(){
            var or = await _context.Orders.ToListAsync();
            return View(or);
        }
    }
}