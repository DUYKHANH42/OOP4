using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT5
{
    public class XeMay : PhuongTienGT
    {
        private int CongSuat;
        public XeMay() : base()
        {
            CongSuat = 0;
        }
        public XeMay(string id, string hangSX, int namSX, double giaBan, string mau, int congSuat) : base(id, hangSX, namSX, giaBan, mau)
        {
            CongSuat = congSuat;
        }
        public int congSuat
        {
            get { return CongSuat; }
            set { CongSuat = value; }
        }
        
        public override void Xuat()
        {  Console.WriteLine($"ID: {id} " +
            $"Hang xe: {hangSX} " +
            $"Nam san xuat: {namSX} " +
            $"Gia ban: {giaBan} " +
            $"Mau: {mau} "+
            $"Cong suat: {CongSuat}");

        }
    }
    }
    
    

