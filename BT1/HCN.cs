using System;

namespace BT1
{
    public class HCN // Khai bao lop Cha HCN 
    {
        // Khai bao kieu du lieu
        private double chieuDai;
        private double chieuRong;
        public double ChieuDai // Get;Set
        {
            get { return chieuDai; }
            set { chieuDai = value; }
        }
        public double ChieuRong
        {
            get { return chieuRong; }
            set { chieuRong = value; }
        }
        public HCN(double chieuDai, double chieuRong)
        {
            this.chieuDai = chieuDai;
            this.chieuRong = chieuRong;
        }
        public HCN() // Tra ve gia tri
        {
            this.chieuDai = 0;
            this.chieuRong = 0;
        }
        public double TinhChuVi() // Phuong thuc tinh chu vi
        {
            return (chieuDai + chieuRong) * 2;
        }
        public double TinhDienTich() // Phuong thuc tinh dien tich
        {
            return chieuDai * chieuRong;
        }
        public virtual void Xuat() // Phuong thuc xuat man hinh
        {
            Console.WriteLine($"Hinh chu nhat:" +
                $"\nChieu dai: {chieuDai}" +
                $"\nChieu rong: {chieuRong}" +
                $"\nChu vi: {TinhChuVi()}" +
                $"\nDientich: {TinhDienTich()}");
        }
    }
}
