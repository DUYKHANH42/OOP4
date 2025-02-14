using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT1
{
     class HinhVuong: HCN // Khai bao lop con
    {
        public HinhVuong(double canh) : base(canh, canh) //
        {
        }
        public override void Xuat() //Ghi de xuat man hinh
        {
            Console.WriteLine($"Hinh vuong:" +
                $"\nCanh: {ChieuDai}" +
                $"\nChu vi: {TinhChuVi()}" +
                $"\nDien tich: {TinhDienTich()}");
        }
    }
}
