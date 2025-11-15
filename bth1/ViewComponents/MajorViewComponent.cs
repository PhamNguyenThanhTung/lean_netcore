using bth1.Data;
using bth1.Models;
using Microsoft.AspNetCore.Mvc;

namespace bth1.ViewComponents
{
    public class MajorViewComponent : ViewComponent
    {
        SchoolContext db; // [cite: 49]
        List<Major> majors; // [cite: 50]

        public MajorViewComponent(SchoolContext context)
        {
            db = context; // [cite: 51]
            majors = db.Majors.ToList(); // [cite: 54]
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            // Trả về view "RenderMajor" và gửi kèm danh sách majors
            return View("RenderMajor", majors); // [cite: 57]
        }
    }
}