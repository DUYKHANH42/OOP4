    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT3
{
    public class SinhVienIT : SinhVien // Khai bao lop con
    {
       private double java; // bien rieng cua lop con
        private double css  ;
        private double html ;
        public double Java // get;set
        {
            get { return java; }
            set { java = value; }
        }
        public double Css
        {
            get { return css; }
            set { css = value; }
        }
        public double Html
        {
            get { return html; }
            set { html = value; }
        }
        public SinhVienIT() // tra ve co gia tri
        {
            java = 0;
            css = 0;
            html = 0;
        }
        public override double TinhDiem() // PT ke thua
        {
            return (2 * java + html + css) / 4;
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
