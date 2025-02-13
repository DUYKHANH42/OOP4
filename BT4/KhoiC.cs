using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT4
{
    public class KhoiC: ThiSinh
    {
        private double Van;
        private double Su;
        private double Dia;
        public double van
        {
            get { return Van; }
            set { Van = value; }
        }
        public double su
        {
            get { return Su; }
            set { Su = value; }
        }
        public double dia
        {
            get { return Dia; }
            set { Dia = value; }
        }
        public KhoiC()
        {
            Van = 0;
            Su = 0;
            Dia = 0;
        }
        public KhoiC(string soBaoDanh, string hoTen, string diaChi, string uuTien, double van, double su, double dia)
        {
            this.SoBaoDanh = soBaoDanh;
            this.HoTen = hoTen;
            this.DiaChi = diaChi;
            this.UuTien = uuTien;
            this.Van = van;
            this.Su = su;
            this.Dia = dia;
        }
        public override double DiemTB()
        {
            return (Van + Su + Dia) / 3;
        }
        public override string KhoiThi()
        {
           return "Khoi C";
        }
        public override void Xuat()
        {
            base.Xuat();
        }
    }
}
