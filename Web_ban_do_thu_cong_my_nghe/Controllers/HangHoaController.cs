using Microsoft.AspNetCore.Mvc;

namespace Web_ban_do_thu_cong_my_nghe.Controllers
{
    public class HangHoaController : Controller
    {
        public IActionResult Index(int name)
        {
            return View();
        }
    }
}
