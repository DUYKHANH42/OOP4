using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT4
{
    public class KhoiB : ThiSinh
    {
        private double Toan;
        private double Sinh;
        private double Hoa;
        public double toan
        {
            get { return Toan; }
            set { Toan = value; }
        }
        public double sinh
        {
            get { return Sinh; }
            set { Sinh = value; }
        }
        public double hoa
        {
            get { return Hoa; }
            set { Hoa = value; }
        }
        public KhoiB()
        {
            Toan = 0;
            Sinh = 0;
            Hoa = 0;
        }
        public KhoiB(string soBaoDanh, string hoTen, string diaChi, string uuTien, double toan, double sinh, double hoa)
        {
            this.SoBaoDanh = soBaoDanh;
            this.HoTen = hoTen;
            this.DiaChi = diaChi;
            this.UuTien = uuTien;
            this.Toan = toan;
            this.Sinh=sinh;
            this.Hoa = hoa;
        }
        public override double DiemTB()
        {
            return (Toan + Sinh + Hoa) / 3;
        }
        public override string KhoiThi()
        {
            return "Khoi B";
        }
        public override void Xuat()
        {
            base.Xuat();
            Console.WriteLine($" Diem toan: {Toan}" +
                             $" Diem sinh: {Sinh}" +
                             $" Diem hoa: {Hoa}"+
                              $" DiemTb: {DiemTB()}");

        }
    }
    }

