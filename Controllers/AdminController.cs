using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PersonalPresents.DataBase;
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
        public async Task<IActionResult> Add(){
            ViewBag.Gender = await _context.Genders.ToListAsync();
            ViewBag.Festival = await _context.Festivals.ToListAsync();
            ViewBag.Interest = await _context.Interests.ToListAsync();
            ViewBag.Profession = await _context.Professions.ToListAsync();
            ViewBag.RoleForUser = await _context.RoleForUsers.ToListAsync();
            return View();            
        }
        [HttpPost]
        public async Task<IActionResult> Add(PresentViewModel p){
            string file = Path.GetFileNameWithoutExtension(p.ImgPath.FileName);
            string extension = Path.GetExtension(p.ImgPath.FileName);
            file = file + DateTime.Now.ToString("yymmssfff") + extension;
            p.Img = "~/Data/img/" + file;
            if(ModelState.IsValid){
                Present present = new Present(){
                    Name = p.Name,
                    Price = p.Price,
                    Description = p.Description,
                    Img = p.Img,
                    RoleId = p.RoleId,
                    GenderId = p.GenderId,
                    ProfessionId = p.ProfessionId,
                    InterestId = p.InterestId,
                    FestivalId = p.FestivalId
                };
                var gender = await _context.Genders.FirstOrDefaultAsync(x => x.Id == p.GenderId);
                present.gender = gender;
                var role = await _context.RoleForUsers.FirstOrDefaultAsync(x => x.Id == p.RoleId);
                present.role = role;
                var fest = await _context.Festivals.FirstOrDefaultAsync(x => x.Id == p.FestivalId);
                present.festival = fest;
                var interest = await _context.Interests.FirstOrDefaultAsync(x => x.Id == p.InterestId);
                present.interest = interest;
                var prof = await _context.Professions.FirstOrDefaultAsync(x => x.Id == p.ProfessionId);
                present.profession = prof;
                _context.Presents.Add(present);
                gender.Presents.Add(present);
                prof.Presents.Add(present);
                interest.Presents.Add(present);
                fest.Presents.Add(present);
                role.Presents.Add(present);
                await _context.SaveChangesAsync();
                return RedirectToAction("GetAllPresents");
            }
            return BadRequest(ModelState);
        }
        [HttpGet]
        public async Task<IActionResult> Change(int Id){
            Present p = await _context.Presents.FindAsync(Id);
            //ViewBag.Gender = await _context.Genders.ToListAsync();
            //ViewBag.Festival = await _context.Festivals.ToListAsync();
            //ViewBag.Interest = await _context.Interests.ToListAsync();
            //ViewBag.Profession = await _context.Professions.ToListAsync();
            //ViewBag.RoleForUser = await _context.RoleForUsers.ToListAsync();
            return View(p);
        }
        [HttpPost]
        public async Task<IActionResult> Change(Present p){
            Present present = await _context.Presents.FirstOrDefaultAsync(x => x.Id == p.Id);
            present.Name = p.Name;
            present.Price = p.Price;
            present.Description = p.Description;
            //present.GenderId = p.GenderId;
            //present.FestivalId = p.FestivalId;
            //present.RoleId = p.RoleId;
            //present.InterestId = p.InterestId;
            //present.ProfessionId = p.ProfessionId;
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