using System;

namespace BT5
{
     abstract public class PhuongTienGT
    {
        private string Id;
        private string HangSX;
        private int NamSX;
        private double GiaBan;
        private string Mau;
        public PhuongTienGT()
        {
            Id = "";
            HangSX = "";
            NamSX = 0;
            GiaBan = 0;
            Mau = "";
        }
        public PhuongTienGT(string id, string hangSX, int namSX, double giaBan, string mau)
        {
            Id = id;
            HangSX = hangSX;
            NamSX = namSX;
            GiaBan = giaBan;
            Mau = mau;
        }
        public string id
        {
            get { return Id; }
            set { Id = value; }
        }
        public string hangSX
        {
            get { return HangSX; }
            set { HangSX = value; }
        }
        public int namSX
        {
            get { return NamSX; }
            set { NamSX = value; }
        }
        public double giaBan
        {
            get { return GiaBan; }
            set { GiaBan = value; }
        }
        public string mau
        {
            get { return Mau; }
            set { Mau = value; }
        }

        abstract public void Xuat();
        //{
        //    Console.WriteLine($"ID: {Id} " +
        //                      $"Hang xe: {HangSX} " +
        //                      $"Nam san xuat: {NamSX} " +
        //                      $"Gia ban: {giaBan} " +
        //                      $"Mau: {Mau} ");
        //}
    }
}
