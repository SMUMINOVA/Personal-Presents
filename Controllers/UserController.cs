using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PersonalPresents.DataBase;

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
    }
}