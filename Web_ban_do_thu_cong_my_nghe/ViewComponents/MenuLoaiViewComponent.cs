using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Web_ban_do_thu_cong_my_nghe.Data;
using Web_ban_do_thu_cong_my_nghe.ViewModels;

namespace Web_ban_do_thu_cong_my_nghe.ViewComponents
{
    public class MenuLoaiViewComponent : ViewComponent
    {
        private readonly MynghevietDbContext db;

        public MenuLoaiViewComponent(MynghevietDbContext context) => db = context;

        public IViewComponentResult Invoke()
        {
            var data = db.Categories.Select(c => new MenuLoaiVM { 
                Name = c.Name, 
                Id = c.Id, 
                ProductCount = c.Products.Count }).OrderBy(p => p.Name);
            return View(data);
        }
    }    
    }

    

