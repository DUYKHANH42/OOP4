using System;

namespace BT1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Red;
            HCN hcn = new HCN(5, 10); // khai bao bien moi cho san gia tri
            hcn.Xuat();
            HinhVuong hv = new HinhVuong(5); // khai bao bien moi cho san gia tri
            hv.Xuat();
            Console.ReadKey();
        }
    }
}
