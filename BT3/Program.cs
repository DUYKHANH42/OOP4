using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            QLSinhVien ql = new QLSinhVien();
            ql.DulieuSan();


            int chon ;

            do
            {
                Console.WriteLine("1. Nhap sinh vien");
                Console.WriteLine("2. Xuat danh sach sinh vien");
                Console.WriteLine("3. Xuat Sinh Vien co hoc luc gioi");
                Console.WriteLine("4.Sap xep sinh vien theo diem ");
                Console.WriteLine("5. Thoat");
                chon = int.Parse(Console.ReadLine());
                switch (chon)
                {
                    case 1:
                        ql.NhapSinhVien();
                        break;
                    case 2:
                        ql.Xuat();
                        break;
                    case 3:
                        ql.XuatSinhVienGioi();
                        break;
                    case 4:
                        ql.SapXepTheoDiem();
                        break;
                    case 5:
                        Console.WriteLine("Thoat");
                        break;
                } 
            } while (chon != 5);
            Console.ReadLine();
        }
    }
}
