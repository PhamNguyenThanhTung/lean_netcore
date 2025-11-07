using bth1.Models;
using Microsoft.AspNetCore.Mvc;

namespace bth1.ViewComponents
{
    public class RenderViewComponent : ViewComponent
    {
        private List<MenuItem> MenuItems = new List<MenuItem>();

        public RenderViewComponent()
        {
            // Khởi tạo danh sách menu
            MenuItems = new List<MenuItem>()
            {
                new MenuItem() { Id = 1, Name = "Dashboard", Link = "Home/Index" },
                new MenuItem() { Id = 2, Name = "Branches", Link = "Branch/Index" }, // Giả sử
                new MenuItem() { Id = 3, Name = "Students", Link = "Student/Index" },
                new MenuItem() { Id = 4, Name = "Subjects", Link = "Subject/Index" }, // Giả sử
                new MenuItem() { Id = 5, Name = "Courses", Link = "Course/Index" } // Giả sử
            };
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            // Trả về view "RenderLeftMenu" và truyền danh sách MenuItems cho nó
            return View("RenderLeftMenu", MenuItems);
        }
    }
}