using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HCN hcn = new HCN(5, 10);
            hcn.Xuat();
            Console.BackgroundColor = ConsoleColor.Red;
            HinhVuong hv = new HinhVuong(5);
            hv.Xuat();
            Console.ReadKey();
        }
    }
}
