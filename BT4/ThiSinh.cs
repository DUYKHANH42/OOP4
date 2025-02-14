using System;

namespace BT4
{
    public class ThiSinh
    {
        private string soBaoDanh;
        private string hoTen;
        private string diaChi;
        private string uuTien;

        public string SoBaoDanh
        {
            get => soBaoDanh; set => soBaoDanh = value;
        }
        public string HoTen
        {
            get => hoTen; set => hoTen = value;
        }
        public string DiaChi
        {
            get => diaChi; set => diaChi = value;
        }
        public string UuTien
        {
            get => uuTien; set => uuTien = value;
        }
        public ThiSinh()
        {
            soBaoDanh = "";
            hoTen = "";
            diaChi = "";
            uuTien = "";
        }
        public ThiSinh(string soBaoDanh, string hoTen, string diaChi, string uuTien)
        {
            this.soBaoDanh = soBaoDanh;
            this.hoTen = hoTen;
            this.diaChi = diaChi;
            this.uuTien = uuTien;
        }
        public virtual string KhoiThi()
        {
            return "";
        }
        public virtual double DiemTB()
        {
            return 0;
        }
        public virtual void Xuat()
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.WriteLine($" So bao danh: {soBaoDanh} " +
                              $" Ho ten: {hoTen} " +
                              $" Dia chi: {diaChi}" +
                              $" Uu tien: {uuTien}" +
                              $" {KhoiThi()}" );



        }



    }
}
