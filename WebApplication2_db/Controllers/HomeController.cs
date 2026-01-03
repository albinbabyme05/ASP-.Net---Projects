using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApplication2_db.Models;

namespace WebApplication2_db.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _context;
        public HomeController(ApplicationDbContext context)
        {
            _context = context;
        }

        // register created pages
        public IActionResult Index() => View();
        public IActionResult Login() => View();
        public IActionResult Registration() => View();
        //public IActionResult DashBoard() => View();
        public IActionResult PasswordInCorrect() => View();
        public IActionResult UserNotFound() => View();
        public IActionResult UserAlreadyExisting() => View();

        public IActionResult DashBoard()
        {
            var data = _context.Products.ToList();
            return View(data);
        }


        //actions
        [HttpPost]
        public IActionResult RegisterUser(string username, string email,string password, string confirmPassword)
        {
            if (password != confirmPassword)
            {
                ViewBag.ErrorMessage = "Password do not match.";
                return View("PasswordInCorrect");
            }
            var existingUser = _context.Users.FirstOrDefault(u => u.Email == email || u.Name == username);
            if(existingUser != null)
            {
                return View("UserAlreadyExisting");
            }

            _context.Users.Add(new User
            {
                Name = username,
                Email = email,
                Passwordss = password,
                Role = "User"
            }
            );
            _context.SaveChanges();

            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult UserLogin(string email, string password)
        {
            var user = _context.Users.FirstOrDefault(u => u.Email == email && u.Passwordss == password);
            if(user == null)
            {
                return RedirectToAction("UserNotFound");
            }
            if (user.Passwordss != password)
            {
                ViewBag.ErrorMessage = "Password do not match.";
                return RedirectToAction("PasswordInCorrect");
            }

            
            return RedirectToAction("DashBoard");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
