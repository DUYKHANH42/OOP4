using System;
using System.Collections.Generic;

namespace BT4
{
    public class TuyenSInh : ThiSinh
    {
        public List<ThiSinh> listTS = new List<ThiSinh>();
        public TuyenSInh()
        {
            listTS = new List<ThiSinh>();
        }
        public void Dulieusan()
        {
            listTS.Add(new KhoiA("1", "Nguyen Van A", "Ha Noi", "1", 10, 10, 10));
            listTS.Add(new KhoiB("3", "Nguyen Van C", "Ha Noi", "3", 10, 10, 10));
            listTS.Add(new KhoiC("5", "Nguyen Van E", "Ha Noi", "5", 10, 10, 10));
        }
        public void AddThiSinh()
        {
            Console.WriteLine("Nhap so bao danh thi sinh: ");
            string soBaoDanh = Console.ReadLine();
            Console.WriteLine("Nhap ho ten thi sinh: ");
            string hoTen = Console.ReadLine();
            Console.WriteLine("Nhap dia chi thi sinh: ");
            string diaChi = Console.ReadLine();
            Console.WriteLine("Nhap uu tien thi sinh: ");
            string uuTien = Console.ReadLine();
            Console.WriteLine("Nhap khoi thi: ");
            string khoi = Console.ReadLine();
            ThiSinh ts = null;
            if (khoi == "A")
            {
                Console.WriteLine("Nhap diem toan: ");
                double toan = double.Parse(Console.ReadLine());
                Console.WriteLine("Nhap diem ly: ");
                double ly = double.Parse(Console.ReadLine());
                Console.WriteLine("Nhap diem hoa: ");
                double hoa = double.Parse(Console.ReadLine());
                ts = new KhoiA(soBaoDanh, hoTen, diaChi, uuTien, toan, ly, hoa);
                Console.WriteLine("Them thi sinh thanh cong.");
            }
            else if (khoi == "B")
            {
                Console.WriteLine("Nhap diem toan: ");
                double toan = double.Parse(Console.ReadLine());
                Console.WriteLine("Nhap diem sinh: ");
                double sinh = double.Parse(Console.ReadLine());
                Console.WriteLine("Nhap diem hoa: ");
                double hoa = double.Parse(Console.ReadLine());
                ts = new KhoiB(soBaoDanh, hoTen, diaChi, uuTien, toan, sinh, hoa);
                Console.WriteLine("Them thi sinh thanh cong.");
            }
            else if (khoi == "C")
            {
                Console.WriteLine("Nhap diem van: ");
                double van = double.Parse(Console.ReadLine());
                Console.WriteLine("Nhap diem su: ");
                double su = double.Parse(Console.ReadLine());
                Console.WriteLine("Nhap diem dia: ");
                double dia = double.Parse(Console.ReadLine());
                ts = new KhoiC(soBaoDanh, hoTen, diaChi, uuTien, van, su, dia);
                Console.WriteLine("Them thi sinh thanh cong.");
            }
            else
            {
                Console.WriteLine("Khoi thi khong hop le");
                return;
            }
            listTS.Add(ts);
        }
        public void RemoveThiSinh(string soBaoDanh)
        {
            foreach (ThiSinh ts in listTS)
            {
                if (ts.SoBaoDanh == soBaoDanh)
                {
                    Console.WriteLine($"Da xoa thi sinh co so bao danh: {soBaoDanh} " );
                    listTS.Remove(ts);
                    return;
                }
            }
            Console.WriteLine("Khong tim thay thi sinh co so bao danh nay");
        }
        public override void Xuat()
        {
            foreach (ThiSinh ts in listTS)
            {
                ts.Xuat();
            }
        }
        public void TimKiem(string soBaoDanh)
        {
            foreach (ThiSinh ts in listTS)
            {
                if (ts.SoBaoDanh == soBaoDanh)
                {
                    ts.Xuat();
                    return;
                }
            }
            Console.WriteLine("Khong tim thay thi sinh co so bao danh nay");
        }


    }
}
