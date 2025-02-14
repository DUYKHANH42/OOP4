using System;

namespace BT4
{
    class KhoiA : ThiSinh
    {
        private double Toan;
        private double Ly;
        private double Hoa;
        public double toan
        {
            get { return Toan; }
            set { Toan = value; }
        }
        public double ly
        {
            get { return Ly; }
            set { Ly = value; }
        }
        public double hoa
        {
            get { return Hoa; }
            set { Hoa = value; }
        }
        public KhoiA()
        {
            Toan = 0;
            Ly = 0;
            Hoa = 0;
        }
        public KhoiA(string soBaoDanh, string hoTen, string diaChi, string uuTien, double toan, double ly, double hoa)
        {
            this.SoBaoDanh = soBaoDanh;
            this.HoTen = hoTen;
            this.DiaChi = diaChi;
            this.UuTien = uuTien;
            this.Toan = toan;
            this.Ly = ly;
            this.Hoa = hoa;
        }
        public override double DiemTB()
        {
            return (Toan + Ly + Hoa) / 3;
        }
        public override string KhoiThi()
        {
            return "Khoi A";
        }
        public override void Xuat()
        {
            base.Xuat();
            Console.WriteLine($" Diem toan: {Toan}" +
                              $" Diem ly: {Ly}" +
                              $" Diem hoa: {Hoa}"+
                              $" DiemTb: {DiemTB()}");
            
        }

    }
}
