using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace b2b1
{
    using System;
    using System.Collections.Generic;

    abstract class Xe
    {
        public string HoTen { get; set; }
        public int SoGio { get; set; }

        public Xe(string hoTen, int soGio)
        {
            HoTen = hoTen;
            SoGio = soGio;
        }

        public abstract double TinhTien();

        public virtual void Xuat()
        {
            Console.WriteLine($"Họ tên: {HoTen}, Số giờ: {SoGio}, Thành tiền: {TinhTien():N0} đ");
        }
    }

    class XeDuLich : Xe
    {
        public XeDuLich(string hoTen, int soGio) : base(hoTen, soGio) { }

        public override double TinhTien()
        {
            if (SoGio <= 0) return 0;
            return 250000 + (SoGio - 1) * 70000;
        }
    }

    class XeTai : Xe
    {
        public XeTai(string hoTen, int soGio) : base(hoTen, soGio) { }

        public override double TinhTien()
        {
            if (SoGio <= 0) return 0;
            return 220000 + (SoGio - 1) * 85000;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Xe> ds = new List<Xe>();

            Console.Write("Nhập số lượng khách thuê xe: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"\n--- Khách {i + 1} ---");
                Console.Write("Nhập họ tên người thuê: ");
                string ht = Console.ReadLine();
                Console.Write("Nhập số giờ thuê: ");
                int gio = int.Parse(Console.ReadLine());
                Console.Write("Loại xe (1 = Du lịch, 2 = Tải): ");
                int loai = int.Parse(Console.ReadLine());

                if (loai == 1)
                    ds.Add(new XeDuLich(ht, gio));
                else
                    ds.Add(new XeTai(ht, gio));
            }

            Console.WriteLine("\n=== DANH SÁCH THUÊ XE ===");
            foreach (var xe in ds)
            {
                xe.Xuat();
            }
        }
    }

}
