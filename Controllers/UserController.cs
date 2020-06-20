using System;
using System.Collections.Generic;
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
        //Просмотр всеч подарков из бд
        public async Task<IActionResult> GetAllPresents(){
            var presents = await _context.Presents.ToListAsync();
            return View(presents);
        }
        //Просмотр отдельного подарка из бд
        public async Task<IActionResult> GetPresent(int Id){
            var present = await _context.Presents.Where(x => x.Id == Id).ToListAsync();
            return View("GetAllPresents", present);
        }
        //получение данных о категориях для взятия информации о человеке которому подбирается подарок
        [HttpGet]
        public async Task<IActionResult> PersonalPresents(){
            ViewBag.Gender = await _context.Genders.ToListAsync();
            ViewBag.Festival = await _context.Festivals.ToListAsync();
            ViewBag.Interest = await _context.Interests.ToListAsync();
            ViewBag.Profession = await _context.Professions.ToListAsync();
            ViewBag.RoleForUser = await _context.RoleForUsers.ToListAsync();
            return View("GetInformationForPresent"); 
        }
        //подбор подарка по полученной информации
        [HttpPost]
        public async Task<IActionResult> PersonalPresents(Present p){
            var present = await _context.Presents.Where( x => x.Price <= p.Price).ToListAsync();
            var ByGender = present.Where(x => x.GenderId == p.GenderId || x.GenderId == 3).ToList();
            var ByRoleAndGender = ByGender.Where(x => x.RoleId == p.RoleId || x.RoleId == 15).ToList();
            var ByRoleGenderAndProfession = ByRoleAndGender.Where(x => x.ProfessionId == p.ProfessionId || x.ProfessionId == 14).ToList();
            var ByRoleGenderProfessionAndInterests = ByRoleGenderAndProfession.Where(x => x.InterestId == p.InterestId).ToList();                
            var ByRoleGenderAndInterests = ByRoleAndGender.Where(x => x.InterestId == p.InterestId).ToList();
            var ByRoleGenderProfessionInterestsAndFestival = ByRoleGenderAndProfession.Where(x => x.FestivalId == p.FestivalId || x.FestivalId == 16).ToList();
            var ByRoleGenderAndFestival = ByRoleAndGender.Where(x => x.FestivalId == p.FestivalId || x.FestivalId == 16).ToList();
            //соединение всех коллекций подарков по определнным категориям в одну общую коллекцию
            var PersonalPresents = ByRoleGenderProfessionInterestsAndFestival.Union(ByRoleGenderProfessionAndInterests).Union(ByRoleGenderAndProfession).Union(ByRoleGenderAndInterests).Union(ByRoleGenderAndFestival).Union(ByRoleAndGender).ToList();
            return View(PersonalPresents);
        }
        //добавление подарка в корзину
        [Authorize]
        [HttpGet]
        public async Task<IActionResult> ToBasket(int Id){
            var p = await _context.Presents.FindAsync(Id);
            var basket = new Basket(){
                Name = p.Name,
                PresentsId = p.Id,
                Price = p.Price,
                Description = p.Description
            };
            var user = await _context.Users.FirstOrDefaultAsync(x => x.Email == User.Identity.Name);
            basket.UserId = user.Id;
            _context.Baskets.Add(basket);
            await _context.SaveChangesAsync();
            ViewBag.Id = basket.Id;
            return View(basket);
        }
        //добавление дополнительной информации о подарке в корзине
        [Authorize]
        [HttpPost]
        public async Task<IActionResult> ToBasket(Basket b){
            var basket = await _context.Baskets.FindAsync(b.Id);
            basket.Count = b.Count;
            basket.Price = basket.Price * b.Count;
            var user = await _context.Users.FirstOrDefaultAsync(x => x.Email == User.Identity.Name);
            user.baskets.Add(basket);
            await _context.SaveChangesAsync();
            return RedirectToAction("MyBasket", "User");
        }
        //просмотр подарков добавленных в корзину
        [Authorize]
        public async Task<IActionResult> MyBasket(){
            var user = await _context.Users.FirstOrDefaultAsync(x => x.Email == User.Identity.Name);
            var presents = await _context.Baskets.Where(x => x.UserId == user.Id).ToListAsync();
            return View(presents);
        }
        //удаление подарка из корзины
        public async Task<IActionResult> DeleteBasket(int Id){
            var basket = await _context.Baskets.FindAsync(Id);
            _context.Baskets.Remove(basket);
            await _context.SaveChangesAsync();
            return RedirectToAction("MyBasket");
        }
        //покупка подарка: получение дополнительной информации о покупателе
        [Authorize]
        [HttpGet]
        public async Task<IActionResult> Buy(int Id){
            ViewBag.BasketId = Id;
            ViewBag.Payment = await _context.Payments.ToListAsync();
            return View();
        }
        //заполнение заявки на покупку подарка из полученной информации
        [Authorize]
        [HttpPost]
        public async Task<IActionResult> Buy(Order o){
            var basket = await _context.Baskets.FindAsync(o.Id);
            var order = new Order(){
                Present = basket.Name,
                Count = basket.Count,
                PresentsId = basket.PresentsId,
                Price = basket.Price,
                Date = DateTime.Now,
                Adress = o.Adress,
                PhoneNumber = o.PhoneNumber,
                PaymentId = o.PaymentId
            };
            _context.Baskets.Remove(basket);
            var user = await _context.Users.FirstOrDefaultAsync(x => x.Email == User.Identity.Name);
            order.UserId = user.Id;
            _context.Orders.Add(order);
            await _context.SaveChangesAsync();
            user.orders.Add(order);
            await _context.SaveChangesAsync();
            return RedirectToAction("MyOrders");
        }
        //просмотр заявок пользователя
        [Authorize]
        public async Task<IActionResult> MyOrders(){
            var user = await _context.Users.FirstOrDefaultAsync(x => x.Email == User.Identity.Name);
            var orders = await _context.Orders.Where(x => x.UserId == user.Id).ToListAsync();
            return View(orders);
        }
        //выбор категории
        public IActionResult Categories(){
            return View();
        }
        //поиск подарка по категории пол
        [HttpGet]
        public async Task<IActionResult> GenderCategorie(){
            var gender = await _context.Genders.ToListAsync();
            return View(gender);
        }
        public async Task<IActionResult> GenderCategories(int Id){
            var presents = await _context.Presents.Where(x => x.GenderId == Id || x.GenderId == 3).ToListAsync();
            return View("GetAllPresents", presents);
        }
        //поиск подарка по категории роль
        [HttpGet]
        public async Task<IActionResult> RoleCategorie(){
            var role = await _context.RoleForUsers.ToListAsync();
            return View(role);
        }
        public async Task<IActionResult> RoleCategories(int Id){
            var presents = await _context.Presents.Where(x => x.RoleId == Id || x.RoleId == 15).ToListAsync();
            return View("GetAllPresents", presents);
        }
        //поиск подарка по категории праздник
        [HttpGet]
        public async Task<IActionResult> FestivalCategorie(){
            var fest = await _context.Festivals.ToListAsync();
            return View(fest);
        }
        public async Task<IActionResult> FestivalCategories(int Id){
            var presents = await _context.Presents.Where(x => x.FestivalId == Id || x.FestivalId == 16).ToListAsync();
            return View("GetAllPresents", presents);
        }
        //поиск подарка по категории интересы
        [HttpGet]
        public async Task<IActionResult> InterestCategorie(){
            var interests = await _context.Interests.ToListAsync();
            return View(interests);
        }
        public async Task<IActionResult> InterestCategories(int Id){
            var presents = await _context.Presents.Where(x => x.FestivalId == Id).ToListAsync();
            return View("GetAllPresents", presents);
        }
        //поиск подарка по категории профессия
        [HttpGet]
        public async Task<IActionResult> ProfessionCategorie(){
            var profession = await _context.Professions.ToListAsync();
            return View(profession);
        }
        public async Task<IActionResult> ProfessionCategories(int Id){
            var presents = await _context.Presents.Where(x => x.ProfessionId == Id || x.ProfessionId == 14).ToListAsync();
            return View("GetAllPresents", presents);
        }

    }
}