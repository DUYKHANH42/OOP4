using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            QLPTGT ql = new QLPTGT();
            ql.Dulieucosan();
            int chon;
            do
            {
                Console.WriteLine("1. Them phuong tien giao thong");
                Console.WriteLine("2. Xoa phuong tien giao thong");
                Console.WriteLine("3. Tim kiem phuong tien giao thong theo hang ");
                Console.WriteLine("4. Tim kiem phuong tien giao thong theo mau ");
                Console.WriteLine("5. Hien thi phuong tien giao thong");
                Console.WriteLine("6. Thoat");
                chon = int.Parse(Console.ReadLine());
                switch (chon)
                {
                    case 1:
                        ql.AddPTGT();
                        break;
                    case 2:
                        ql.RemovePTGT();
                        break;
                    case 3:
                        ql.TimPTGTTheoHang();
                        break;
                    case 4:
                        ql.TimPTGTTheoMau();
                        break;
                    case 5:
                        ql.Xuat();
                        break;
                    case 6:
                        Console.WriteLine("Thoat");
                        break;
                }
            } while (chon != 6);
            Console.ReadLine();
        }
    }
}
