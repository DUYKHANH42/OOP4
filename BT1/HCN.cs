using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT1
{
    public class HCN
    {
        private double chieuDai;
        private double chieuRong;
        public double ChieuDai
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
        public HCN() 
        {
            this.chieuDai = 0;
            this.chieuRong = 0;
        }
        public double TinhChuVi()
        {
            return (chieuDai + chieuRong) * 2;
        }
        public double TinhDienTich()
        {
            return chieuDai * chieuRong;
        }   
        public virtual void Xuat()
        {
            Console.WriteLine($"Hinh chu nhat:" +
                $"\nChieu dai: {chieuDai}" +
                $"\nChieu rong: {chieuRong}" +
                $"\nChu vi: {TinhChuVi()}"+
                $"\nDientich: {TinhDienTich()}");
        }
    }
}
