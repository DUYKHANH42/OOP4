using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT5
{
    public class PhuongTienGT
    {
        private string Id;
        private string HangSX;
        private int NamSX;
        private double GiaBan;
        private string Mau;
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
        public virtual void Xuat()
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine($"ID: {Id} " +
                              $"Hang xe: {HangSX} " +
                              $"Nam san xuat: {NamSX} " +
                              $"Gia ban: {giaBan} " +
                              $"Mau: {Mau} ");
        }
    }
}
