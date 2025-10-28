using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace b1b1
{
    class ThiSinh
    {
        public string sbd;
        public string ht;
        public double m1, m2, m3;

        public ThiSinh() { }

        public ThiSinh(string sbd, string ht, double m1, double m2, double m3)
        {
            this.sbd = sbd;
            this.ht = ht;
            this.m1 = m1;
            this.m2 = m2;
            this.m3 = m3;
        }

        public virtual void Nhap()
        {
            Console.Write("Nhập SBD: ");
            sbd = Console.ReadLine();
            Console.Write("Nhập Họ Tên: ");
            ht = Console.ReadLine();
            Console.Write("Nhập điểm M1: ");
            m1 = double.Parse(Console.ReadLine());
            Console.Write("Nhập điểm M2: ");
            m2 = double.Parse(Console.ReadLine());
            Console.Write("Nhập điểm M3: ");
            m3 = double.Parse(Console.ReadLine());
        }

        public virtual double TinhTong()
        {
            return m1 + m2 + m3;
        }
    }

    class TuyenSinh : ThiSinh
    {
        public int khuvuc;

        public override void Nhap()
        {
            base.Nhap(); // gọi nhập từ lớp cha
            Console.Write("Nhập khu vực (1/2/3): ");
            khuvuc = int.Parse(Console.ReadLine());
        }

        public override double TinhTong()
        {
            double diemKV = 0;
            if (khuvuc == 2) diemKV = 1;
            else if (khuvuc == 3) diemKV = 2;
            return base.TinhTong() + diemKV;
        }

        public void Xuat()
        {
            Console.WriteLine($"SBD: {sbd}, Họ tên: {ht}, KV: {khuvuc}, Tổng điểm: {TinhTong()}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhập số lượng thí sinh: ");
            int n = int.Parse(Console.ReadLine());
            List<TuyenSinh> ds = new List<TuyenSinh>();

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"\n--- Nhập thí sinh thứ {i + 1} ---");
                TuyenSinh ts = new TuyenSinh();
                ts.Nhap();
                ds.Add(ts);
            }

            Console.Write("\nNhập điểm chuẩn: ");
            double diemChuan = double.Parse(Console.ReadLine());

            Console.WriteLine("\n=== Danh sách trúng tuyển ===");
            foreach (var ts in ds)
            {
                if (ts.TinhTong() >= diemChuan)
                {
                    ts.Xuat();
                }
            }
        }
    }
}
