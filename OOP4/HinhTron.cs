using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP4
{
    public class HinhTron
    {
        
        private double banKinh;

        public HinhTron(double banKinh)
        {
            this.banKinh = banKinh;
        }
        public HinhTron()
        {
            banKinh = 1;
        }
            public double BanKinh
        {
            get { return banKinh; }
            set { banKinh = value; }
        }
        public double TinhChuVi()
        {
            return 2 * Math.PI * banKinh;
        }
        public virtual double TinhDienTich()
        {
            return Math.PI * banKinh * 2;
        }
    }
    public class HinhTru : HinhTron
    {
        private double chieucao;
        public HinhTru(double banKinh, double chieucao) : base(banKinh)
        {
            this.chieucao=chieucao;
        }
        public double chieuCao
        {
            get { return chieucao; }
            set { chieucao = value; }
        }
        public double TinhTheTich()
        {
            return base.TinhDienTich() * chieucao;
        }

        public override double TinhDienTich()
        {
            return (2*base.TinhChuVi())+(base.TinhChuVi()+chieucao);
        }

    }
}
