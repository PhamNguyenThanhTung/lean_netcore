using bth1.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Hosting; // Để inject IWebHostEnvironment
using System.IO; // Để làm việc với file và đường dẫn
namespace bth1.Controllers
{
    [Route("Admin/Student")]
    public class StudentController : Controller
    {
        private List<Student> ListStudents = new List<Student>();
        private readonly IWebHostEnvironment _webHostEnvironment;
        public StudentController(IWebHostEnvironment webHostEnvironment)
        {
            _webHostEnvironment = webHostEnvironment;
            ListStudents = new List<Student>()
            {
                new Student() { Id = 101, Name = "Hải Nam", Branch = Branch.IT,
                    Gender = Gender.Male, IsRegular = true,
                    Address = "A1-2018", Email = "nam@g.com" },
                new Student() { Id = 102, Name = "Minh Tú", Branch = Branch.BE,
                    Gender = Gender.Female, IsRegular = true,
                    Address = "A1-2019", Email = "tu@g.com" },
                new Student() { Id = 103, Name = "Hoàng Phong", Branch = Branch.CE,
                    Gender = Gender.Male, IsRegular = false,
                    Address = "A1-2020", Email = "phong@g.com" },
                new Student() { Id = 104, Name = "Xuân Mai", Branch = Branch.EE,
                    Gender = Gender.Female, IsRegular = false,
                    Address = "A1-2021", Email = "mai@g.com" }
            };
            _webHostEnvironment = webHostEnvironment;
        }
        [Route("List", Name = "StudentList")]
        public IActionResult Index()
        {
            return View(ListStudents);
        }

        [HttpGet("Add", Name = "CreateStudentForm")]
        public IActionResult Create()
        {
            ViewBag.AllGenders = Enum.GetValues(typeof(Gender)).Cast<Gender>().ToList();

            ViewBag.AllBranches = new List<SelectListItem>()
            {
                new SelectListItem {Text = "IT",Value = "1"},
                new SelectListItem {Text = "BE",Value = "2"},
                new SelectListItem {Text = "CE",Value = "3"},
                new SelectListItem {Text = "EE",Value = "4"}
            };
            return View();
        }

        [HttpPost("Add", Name = "SubmitStudentForm")]
        public IActionResult Create(Student s, IFormFile avatarFile)
        {
            //if (avatarFile != null)
            //{
            //    // Lấy đường dẫn thư mục wwwroot
            //    string wwwRootPath = _webHostEnvironment.WebRootPath;
            //    string uploadsFolder = Path.Combine(wwwRootPath, "uploads");

            //    // Tạo thư mục 'uploads' nếu chưa có
            //    if (!Directory.Exists(uploadsFolder))
            //    {
            //        Directory.CreateDirectory(uploadsFolder);
            //    }

            //    // Tạo tên file duy nhất
            //    string uniqueFileName = Guid.NewGuid().ToString() + "_" + avatarFile.FileName;
            //    string filePath = Path.Combine(uploadsFolder, uniqueFileName);

            //    // Lưu file
            //    using (var fileStream = new FileStream(filePath, FileMode.Create))
            //    {
            //        avatarFile.CopyTo(fileStream);
            //    }

            //    // Gán đường dẫn file đã lưu vào model Student
            //    // URL để truy cập từ trình duyệt sẽ là /uploads/ten-file
            //    s.AvatarUrl = "/uploads/" + uniqueFileName;
            //}
            s.Id = ListStudents.Last().Id+1;
            ListStudents.Add(s);
            return View("Index",ListStudents);
        }
    }
}
