using System;
using System.Collections.Generic;

namespace BT3
{
    public class QLSinhVien : SinhVien
    {
        public List<SinhVien> dsSinhVien;
        public  QLSinhVien()
        {
            dsSinhVien = new List<SinhVien>();
        }
        public  void DulieuSan()
        {
            dsSinhVien.Add(new SinhVienIT { HoTen = "Nguyen Van A", NganhHoc = "IT", Java = 5, Html = 6, Css = 7 });

            dsSinhVien.Add(new SinhVienBiz { HoTen = "Nguyen Van E", NganhHoc = "Biz", Marketing = 10, Sale = 10 });
        }
        public void NhapSinhVien()
        {
            Console.WriteLine("Nhap ten sinh vien: ");
            string hoTen = Console.ReadLine();
            Console.WriteLine("Nhap nganh hoc: ");
            string nganhHoc = Console.ReadLine();
            SinhVien sv = null;
            if (nganhHoc == "IT")
            {
                sv = new SinhVienIT();
                Console.WriteLine("Nhap diem Java: ");
                ((SinhVienIT)sv).Java = double.Parse(Console.ReadLine());
                Console.WriteLine("Nhap diem Html: ");
                ((SinhVienIT)sv).Html = double.Parse(Console.ReadLine());
                Console.WriteLine("Nhap diem Css: ");
                ((SinhVienIT)sv).Css = double.Parse(Console.ReadLine());
                Console.WriteLine("Them sinh vien moi thanh cong");
            }
            else if (nganhHoc == "Biz")
            {
                sv = new SinhVienBiz();
                Console.WriteLine("Nhap diem Marketing: ");
                ((SinhVienBiz)sv).Marketing = double.Parse(Console.ReadLine());
                Console.WriteLine("Nhap diem Sale: ");
                ((SinhVienBiz)sv).Sale = double.Parse(Console.ReadLine());
                Console.WriteLine("Them sinh vien moi thanh cong");
            }
            else
            {

                Console.WriteLine("sinh vien khong hop le");
                return;
            }
            sv.HoTen = hoTen;
            sv.NganhHoc = nganhHoc;
            dsSinhVien.Add(sv);
        }
        //public override void Xuat()
        //{
        //    Console.WriteLine("{0,-15} {1,-15} {2,-15} {3,-15}}",
        //        "Ho va ten", "Nganh", "Diem", "Xep Loai");

        //    foreach (SinhVien sv in dsSinhVien)
        //    {
        //        Console.WriteLine("{0,-15} {1,-15} {2,-15} {3,-15}}",
        //           sv.HoTen, sv.NganhHoc, sv.TinhDiem(), sv.XepLoai());


        //    }
        //}

        public override void Xuat()
        {
            foreach (SinhVien sv in dsSinhVien)
            {
                sv.Xuat();

            }
        }
        public void XuatSinhVienGioi()
        {
            foreach (SinhVien sv in dsSinhVien)
            {
                if (sv.TinhDiem() >= 8)
                {
                    sv.Xuat();
                }
            }
        }
        public void SapXepTheoDiem()
        {
            dsSinhVien.Sort((sv1, sv2) => sv2.TinhDiem().CompareTo(sv1.TinhDiem()));
            Xuat();
        }

    }
}
