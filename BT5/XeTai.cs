using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT5
{
    public class XeTai : PhuongTienGT
    {
        private double TrongTai;
        public XeTai() : base()
        {
            TrongTai = 0;
        }
        public XeTai(string id, string hangSX, int namSX, double giaBan, string mau, double trongTai) : base(id, hangSX, namSX, giaBan, mau)
        {
            TrongTai = trongTai;
        }
        public double trongTai
        {
            get { return TrongTai; }
            set { TrongTai = value; }
        }
        
        public override void Xuat()
        {
            Console.WriteLine($"ID: {id} " +
            $"Hang xe: {hangSX} " +
            $"Nam san xuat: {namSX} " +
            $"Gia ban: {giaBan} " +
            $"Mau: {mau} " +
            $"Trong tai: {TrongTai}");
        }


    }
}
