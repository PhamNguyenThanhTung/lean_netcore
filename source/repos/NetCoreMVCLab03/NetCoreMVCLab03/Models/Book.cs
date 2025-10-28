using Microsoft.AspNetCore.Mvc.Rendering;
using System.Reflection.Metadata.Ecma335;
using static System.Reflection.Metadata.BlobBuilder;

namespace NetCoreMVCLab03.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int AuthorId { get; set; }
        public int GenreId { get; set; }
        public string Image { get; set; }
        public float Price { get; set; }
        public int TotalPage { get; set; }
        public string Sumary { get; set; }

        //danh sach
        public List<Book> GetBookList()
        {
            List<Book> books = new List<Book>()
            {
                new Book()
        {
            Id = 1,
            Title = "Chí Phèo",
            AuthorId = 1,  // Nam Cao
            GenreId = 1,   // Truyện tranh
            Image = "/images/products/b1.jpg",
            Price = 500000,
            Sumary = "Tác phẩm nổi tiếng của Nam Cao về số phận người nông dân.",
            TotalPage = 250
        },
        new Book()
        {
            Id = 2,
            Title = "Lão Hạc",
            AuthorId = 2,  // Ngô Tất Tố
            GenreId = 1,   // Truyện tranh
            Image = "/images/products/b2.jpg",
            Price = 450000,
            Sumary = "Câu chuyện xúc động về tình phụ tử và thân phận con người.",
            TotalPage = 200
        },
        new Book()
        {
            Id = 3,
            Title = "Conan Phiêu lưu ký",
            AuthorId = 3,  // Adam Khoo
            GenreId = 1,   // Truyện tranh
            Image = "/images/products/b3.jpg",
            Price = 700000,
            Sumary = "Tập truyện phiêu lưu kỳ thú với nhân vật Conan.",
            TotalPage = 350
        },
        new Book()
        {
            Id = 4,
            Title = "Đường Xưa Mây Trắng",
            AuthorId = 4,  // Thiền sư Thích Nhất Hạnh
            GenreId = 1,   // Truyện tranh
            Image = "/images/products/b4.jpg",
            Price = 850000,
            Sumary = "Tác phẩm nổi tiếng về hành trình của Đức Phật do Thích Nhất Hạnh viết.",
            TotalPage = 400
        }
            };
            return books;
        }
        
        //chi tiet 1 cuon sach
        public Book GetBookById(int id)
        {
            Book book = this.GetBookList().FirstOrDefault(b => b.Id == id);
            return book;
        }

        //selectListItem Authors
        public List<SelectListItem> Authors { get; } = new List<SelectListItem>
           {
            new SelectListItem { Value = "1", Text = "Nam Cao" },
            new SelectListItem { Value = "2", Text = "Ngô Tất Tố" },
            new SelectListItem { Value = "3", Text = "Adam Khoo" },
            new SelectListItem { Value = "4", Text = "Thiền sư Thích Nhất Hạnh" }
           };

        //SelectListItem Genres
        public List<SelectListItem> Genres { get; } = new List<SelectListItem>
        {
            new SelectListItem { Value = "1", Text = "Truyện tranh" },
            new SelectListItem { Value = "2", Text = "Văn học đương đại" },
            new SelectListItem { Value = "3", Text = "Phật học phổ thông" },
            new SelectListItem { Value = "4", Text = "Truyện cười" }
        };



    }
}
