using System;

namespace BT5
{
    public class OTO : PhuongTienGT
    {
        private int SoChoNgoi;
        private string KieuDongCo;
        public int soChoNgoi
        {
            get { return SoChoNgoi; }
            set { SoChoNgoi = value; }
        }
        public string kieuDongCo
        {
            get { return KieuDongCo; }
            set { KieuDongCo = value; }
        }
        public OTO() : base()
        {
            SoChoNgoi = 0;
            KieuDongCo = "";
        }
        public OTO(string id, string hangSX, int namSX, double giaBan, string mau, int soChoNgoi, string kieuDongCo) : base(id, hangSX, namSX, giaBan, mau)
        {
            SoChoNgoi = soChoNgoi;
            KieuDongCo = kieuDongCo;
        }
        public override void Xuat()
        {
            base.Xuat();
            Console.WriteLine($"So cho ngoi: {SoChoNgoi}  " +
                              $"Kieu dong co: {KieuDongCo} ");
        }
    }

}

