using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT3
{
    public class SinhVienBiz : SinhVien // Khai bao lop con
    {
        double marketing ; // bien rieng cua lop con
        double sale  ;
        public double Marketing // get;set
        {
            get { return marketing; }
            set { marketing = value; }
        }
        public double Sale
        {
            get { return sale; }
            set { sale = value; }
        }
        public SinhVienBiz() // tra ve co gia tri
        {
            marketing = 0;
            sale = 0;
        }
        public override double TinhDiem() // PT ke thua
        {;
            return (2 * marketing+sale) / 3;
        }

        public override string XepLoai()
        {
            return base.XepLoai();
        }
        public override void Xuat()
        {
            base.Xuat();
        }
    }
}

