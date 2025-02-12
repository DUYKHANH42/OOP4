using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HinhTron C1 = new HinhTron(5);
            HinhTru C2 = new HinhTru(5,10);
            Console.WriteLine($"Hinh Tron C1: " +
                $"\nban kinh = {C1.BanKinh}" +
                $"\nchu vi= {C1.TinhChuVi()}" +
                $"\ndien tich= {C1.TinhDienTich()}");
            Console.WriteLine($"Hinh Tru C2: " +
               $"\nban kinh = {C2.BanKinh}" +
               $"\nchieu cao= {C2.chieuCao}" +
               $"\nthe tich= {C2.TinhTheTich()}" +
               $"\ndien tich= {C2.TinhDienTich()}");
            Console.ReadKey();
        }
    }
}
