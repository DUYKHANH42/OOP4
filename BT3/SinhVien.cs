using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT3
{
    public class SinhVien
    {
        string hoTen;
        string NgangHoc;
        //public List<SinhVien> dsSinhVien;
        //public SinhVien()
        //{
        //    dsSinhVien = new List<SinhVien>();
        //}
        ////public void DulieuSan()
        ////{
        ////    dsSinhVien.Add(new SinhVienIT { HoTen = "Nguyen Van A", NganhHoc = "IT", Java = 5, Html = 6, Css = 7 });

        ////    dsSinhVien.Add(new SinhVienBiz { HoTen = "Nguyen Van E", NganhHoc = "Biz", Marketing = 10, Sale = 10 });
        ////}
        public string HoTen
        {
            get { return hoTen; }
            set { hoTen = value; }
        }
        public string NganhHoc
        {
            get { return NgangHoc; }
            set { NgangHoc = value; }
        }
        public SinhVien(string hoTen, string NganhHoc)
        {
            this.hoTen = hoTen;
            this.NgangHoc = NganhHoc;
        }
        public SinhVien()
        {
            this.hoTen = "";
            this.NgangHoc = "";
        }
        public virtual double TinhDiem()
        {
            return 0;
        }
        public virtual string XepLoai()
        {
            if (TinhDiem() < 5)
                return "Yeu";
            else if (TinhDiem() <= 6.5)
                return "Trung binh";
            else if (TinhDiem() <= 7.5)
                return "Kha";
            else if (TinhDiem() <= 9)
                return "Gioi";
            else
                return "Xuat sac";
        }
        public virtual void Xuat()
        {
            
            Console.WriteLine($"Ho va Ten: {hoTen}," +
                              $"\tNganh Hoc: {NganhHoc}" +
                              $"\tDiem: {TinhDiem()}" +
                              $"\tXep Loai: {XepLoai()}" );
            Console.BackgroundColor = ConsoleColor.Red;

        }
    }
}
