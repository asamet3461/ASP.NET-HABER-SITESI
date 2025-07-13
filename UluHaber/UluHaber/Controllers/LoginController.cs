using Microsoft.AspNetCore.Mvc;
using UluHaber.Data;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;

namespace UluHaber.Controllers
{
    public class LoginController : Controller
    {
        private readonly ApplicationDbContext _context;

        public LoginController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Index(string email, string password)
        {
            try
            {
                var kullanici = _context.Users.FirstOrDefault(x=> x.Email == email && x.Password == password
                && x.IsActive);
                if (kullanici == null) TempData["Mesaj"] = "E-posta veya şifrenizi kontrol edin.";
                else
                {
                    var haklar = new List<Claim>() { new Claim(ClaimTypes.Email, kullanici.Email) };
                    if (kullanici.IsAdmin)
                        haklar.Add(new Claim(ClaimTypes.Role, "Admin"));
                    if (kullanici.IsAuthor)
                        haklar.Add(new Claim(ClaimTypes.Role, "Yazar"));
                    var kullaniciKimligi = new ClaimsIdentity(haklar,"Login");
                    ClaimsPrincipal claimsPrincipal = new ClaimsPrincipal(kullaniciKimligi);
                    await HttpContext.SignInAsync(claimsPrincipal);
                    if (kullanici.IsAdmin)
                    {
                        return Redirect("/Admin");
                    }
                    else return Redirect("/Home");
                }
            }
            catch (Exception hata)
            {
                TempData["Mesaj"] = "Hata Oluştu!";
            }
            return View();
        }
        [Route("Logout")]
        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync();
            return Redirect("/");
        }
    }
}
