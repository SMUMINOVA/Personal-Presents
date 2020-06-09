using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PersonalPresents.DataBase;
using PersonalPresents.Models.PackageModels;
using PersonalPresents.Models.PresentModels;

namespace PersonalPresents.Controllers
{
    public class UserController : Controller
    {
        private AppDbContent _context;
        public UserController(AppDbContent context)
        {
            _context = context;
        }
        public async Task<IActionResult> GetAllPresents(){
            var presents = await _context.Presents.ToListAsync();
            return View(presents);
        }
        [HttpGet]
        public async Task<IActionResult> PersonalPresents(){
            ViewBag.Gender = await _context.Genders.ToListAsync();
            ViewBag.Festival = await _context.Festivals.ToListAsync();
            ViewBag.Interest = await _context.Interests.ToListAsync();
            ViewBag.Profession = await _context.Professions.ToListAsync();
            ViewBag.RoleForUser = await _context.RoleForUsers.ToListAsync();
            return View("GetInformationForPresent"); 
        }
        [HttpPost]
        public async Task<IActionResult> PersonalPresents(Present p){
            var present = await _context.Presents.Where( x => x.Price <= p.Price).ToListAsync();
            var ByGender = present.Where(x => x.GenderId == p.GenderId || x.GenderId == 3).ToList();
            var ByRoleAndGender = ByGender.Where(x => x.RoleId == p.RoleId || x.RoleId == 15).ToList();
            var ByRoleGenderAndProfession = ByRoleAndGender.Where(x => x.ProfessionId == p.ProfessionId || x.ProfessionId == 14).ToList();
            var ByRoleGenderProfessionAndInterests = ByRoleGenderAndProfession.Where(x => x.InterestId == p.InterestId).ToList();
            var ByRoleGenderProfessionInterestsAndFestival = ByRoleGenderProfessionAndInterests.Where(x => x.FestivalId == p.FestivalId || x.FestivalId == 16).ToList();
            var ByRoleGenderAndInterests = ByRoleAndGender.Where(x => x.InterestId == p.InterestId).ToList();
            var ByRoleGenderAndFestival = ByRoleAndGender.Where(x => x.FestivalId == p.FestivalId || x.FestivalId == 16).ToList();
            var AllPresents = new ViewPersonalPresent(){
                First = ByRoleGenderProfessionInterestsAndFestival,
                Second = ByRoleGenderProfessionAndInterests,
                Third = ByRoleGenderAndInterests,
                Fourth = ByRoleGenderAndProfession,
                Fifth = ByRoleGenderAndFestival,
                Sixth = ByRoleAndGender
            };
            return View(AllPresents);
        }
        [Authorize]
        [HttpGet]
        public async Task<IActionResult> ToBasket(int Id){
            var p = await _context.Presents.FindAsync(Id);
            var basket = new Basket(){
                Name = p.Name,
                Img = p.Img,
                PresentsId = p.Id
            };
            return View(basket);
        }
        [Authorize]
        [HttpPost]
        public async Task<IActionResult> ToBasket(Basket b){
            b.Price = b.Price * b.Count;
            var user = await _context.Users.FirstOrDefaultAsync(x => x.Email == User.Identity.Name);
            b.UserId = user.Id;
            _context.Baskets.Add(b);
            await _context.SaveChangesAsync();
            user.baskets.Add(b);
            await _context.SaveChangesAsync();
            return RedirectToAction("Basket", "User");
        }
        [Authorize]
        public async Task<IActionResult> MyBasket(){
            var user = await _context.Users.FirstOrDefaultAsync(x => x.Email == User.Identity.Name);
            var presents = await _context.Baskets.Where(x => x.UserId == user.Id).ToListAsync();
            return View(presents);
        }
        public async Task<IActionResult> DeleteBasket(int Id){
            var basket = await _context.Baskets.FindAsync(Id);
            _context.Baskets.Remove(basket);
            await _context.SaveChangesAsync();
            return RedirectToAction("MyBasket");
        }
        [Authorize]
        [HttpGet]
        public async Task<IActionResult> Buy(int Id){
            var basket = await _context.Baskets.FindAsync(Id);
            ViewBag.BasketId = Id;
            ViewBag.Payment = await _context.Payments.ToListAsync();
            var order = new Order(){
                Present = basket.Name,
                Count = basket.Count,
                PresentsId = basket.PresentsId,
                Price = basket.Price,
                Date = DateTime.Now,
            };
            return View(order);
        }
        [Authorize]
        [HttpPost]
        public async Task<IActionResult> Buy(Order o){
            var user = await _context.Users.FirstOrDefaultAsync(x => x.Email == User.Identity.Name);
            o.UserId = user.Id;
            _context.Orders.Add(o);
            await _context.SaveChangesAsync();
            user.orders.Add(o);
            await _context.SaveChangesAsync();
            return RedirectToAction("MyOrders");
        }
        [Authorize]
        public async Task<IActionResult> MyOrders(){
            var user = await _context.Users.FirstOrDefaultAsync(x => x.Email == User.Identity.Name);
            var orders = await _context.Orders.Where(x => x.UserId == user.Id).ToListAsync();
            return View(orders);
        }
    }
}