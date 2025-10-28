using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CanHoHCN
{
    class HCN
    {
        double cd, cr;
        public void nhap()
        {
            cd = double.Parse(Console.ReadLine());
            cr = double.Parse(Console.ReadLine());
        }
        public void xuat()
        {
            Console.WriteLine("cd " + cd.ToString("0.00") + "cr " + cr.ToString("0.00"));
        }
        public double Cd
        {
            get { return cd; }
            set { cd = value; }
        }
        public double Cr
        {
            get { return cr; }
            set { cr = value; }

        }
        public double tinhdt()
        {
            return cd * cr;
        }
    }
    class CH
    {
        int ma;
        HCN kt;
        public HCN Kt
        {
            set { kt = value; }
            get { return kt; }
        }
        public void nhapch()
        {
            ma = int.Parse(Console.ReadLine());
            kt = new HCN();
            kt.nhap();
        }
        public void xuatch()
        {
            Console.WriteLine("\nmaphong: " + ma.ToString());
            kt.xuat();
            Console.WriteLine("dientich: " + kt.tinhdt().ToString());

        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            CH[] h = new CH[200];
            n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++) {
                h[i] = new CanHoHCN.CH();
                h[i].nhapch();
            }
            for (int i = 0; i < n; i++) {
                h[i].xuatch();
            }
            double max;
            CH chmax = h[1];
            max = h[1].Kt.tinhdt();
            for (int i = 2; i <= n; i++)
                if (max < h[i].Kt.tinhdt())
                { max = h[i].Kt.tinhdt(); chmax = h[i]; }
            Console.Write("can hoc co dien tich max:"); chmax.xuatch();
            Console.ReadKey();

        }
    } 
}
