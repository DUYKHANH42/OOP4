using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT1
{
     class HinhVuong: HCN
    {
        public HinhVuong(double canh) : base(canh, canh)
        {
        }
        public override void Xuat()
        {
            Console.WriteLine($"Hinh vuong:" +
                $"\nCanh: {ChieuDai}" +
                $"\nChu vi: {TinhChuVi()}" +
                $"\nDien tich: {TinhDienTich()}");
        }
    }
}
