﻿using System;
using System.Collections.Generic;

namespace BT5
{
    public class QLPTGT 
    {
        public List<PhuongTienGT> ds = new List<PhuongTienGT>();
        public QLPTGT()
        {
            ds = new List<PhuongTienGT>();
        }
        public void Dulieucosan()
        {
            ds.Add(new XeTai("1", "Toyota", 2020, 1000000, "Trang", 1000));
            ds.Add(new XeMay("3", "Yamaha", 2020, 3000000, "Do", 100));
            ds.Add(new OTO("2", "Vinfast", 2020, 2000000, "Den", 4, "Dien"));
        }
        public void Clear()
        {
            Console.Clear();
        }
        public void AddPTGT()
        {
            Clear();
            Console.WriteLine("Nhap id:");
            string id = Console.ReadLine();
            if (ds.Exists(x => x.id == id))
            {
                Console.WriteLine("Id da ton tai");
                return;
            }
            Console.WriteLine("Nhap hang san xuat:");
            string hangSX = Console.ReadLine();
            Console.WriteLine("Nhap nam san xuat:");
            int namSX = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap gia ban:");
            double giaBan = double.Parse(Console.ReadLine());
            Console.WriteLine("Nhap mau:");
            string mau = Console.ReadLine();
            Console.WriteLine("Nhap loai phuong tien:(1: Xe Tai/2: Xe May/ 3: OTO");
            int PTGT = int.Parse(Console.ReadLine());
            QLPTGT pt = new QLPTGT();
            if (PTGT == 1)
            {
                Console.WriteLine("Nhap trong tai:");
                double trongTai = double.Parse(Console.ReadLine());
                ds.Add(new XeTai(id, hangSX, namSX, giaBan, mau, trongTai));
                Console.WriteLine("Them thanh cong");
            }
            else if (PTGT ==2)
            {
                Console.WriteLine("Nhap cong suat:");
                int congSuat = int.Parse(Console.ReadLine());
                ds.Add(new XeMay(id, hangSX, namSX, giaBan, mau, congSuat));
                Console.WriteLine("Them thanh cong");
            }
            else if (PTGT == 3)
            {
                Console.WriteLine("Nhap so cho ngoi:");
                int soChoNgoi = int.Parse(Console.ReadLine());
                Console.WriteLine("Nhap kieu dong co:");
                string kieuDongCo = Console.ReadLine();
                ds.Add(new OTO(id, hangSX, namSX, giaBan, mau, soChoNgoi, kieuDongCo));
                Console.WriteLine("Them thanh cong");
            }
            else
            {
                Console.WriteLine("Nhap sai loai phuong tien");
                return;
            }
        }
        public void RemovePTGT()
        {
            Clear();
            Console.WriteLine("Nhap id:");
            string id = Console.ReadLine();
            foreach (PhuongTienGT pt in ds)
            {
                if (pt.id == id)
                {
                    Console.WriteLine("Xoa Thanh Cong");
                    ds.Remove(pt);
                    break;
                }
                else
                {
                    Console.WriteLine("Khong tim thay id");
                    return;
                }
            }
        }
        public void TimPTGTTheoHang()
        {
            Clear();
            Console.WriteLine("Nhap hang xe:");
            string hangxe = Console.ReadLine();
            foreach (PhuongTienGT pt in ds)
            {
                if (pt.hangSX == hangxe)
                {
                    pt.Xuat();
                    return;
                }
            }

            Console.WriteLine("Khong tim thay hang xe");
        }
        public void TimPTGTTheoMau()
        {
            Clear();
            Console.WriteLine("Nhap mau:");
            string mau = Console.ReadLine();
            foreach (PhuongTienGT pt in ds)
            {
                if (pt.mau == mau)
                {
                    pt.Xuat();
                    return;
                };
            }
            Console.WriteLine("Khong tim thay mau");
        }
        public  void Xuat()
        {
            Clear();
            foreach (PhuongTienGT pt in ds)
            {
                pt.Xuat();
            }

        }
    }
}
