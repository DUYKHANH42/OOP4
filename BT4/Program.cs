using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TuyenSInh ts = new TuyenSInh();
            ts.Dulieusan();
            int chon;
            do 
            { 
                Console.WriteLine("1. Them thi sinh");
                Console.WriteLine("2. Xoa thi sinh");
                Console.WriteLine("3. Hien thi thi sinh");
                Console.WriteLine("4. Tim kiem thi sinh");
                Console.WriteLine("5. Thoat");
                chon = int.Parse(Console.ReadLine());
                switch(chon)
                {
                    case 1:
                        ts.AddThiSinh();
                        break;
                    case 2:
                        Console.WriteLine("Nhap so bao danh can xoa: ");
                        string soBaoDanh = Console.ReadLine();
                        ts.RemoveThiSinh(soBaoDanh);
                        break;
                    case 3:
                        ts.Xuat();
                        break;
                    case 4:
                        Console.WriteLine("Nhap so bao danh can tim: ");
                        soBaoDanh = Console.ReadLine();
                        ts.TimKiem(soBaoDanh);
                        break;
                    case 5:
                        Console.WriteLine("Thoat");
                        break;
                }



            } while (chon !=5 );
            Console.ReadLine();
        }
    }
}
