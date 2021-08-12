using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaffManager
{
    class Staff:Human
    {
        string MaNV;
        string BangCap;
        
        //Method
        public void setMaNV(string MaNV)
        {
            this.MaNV = MaNV;
        }
        public string getMaNV()
        {
            return MaNV;
        }
        public void setBangCap(string BangCap)
        {
            this.BangCap = BangCap;
        }
        public string getBangCap()
        {
            return BangCap;
        }
        public override int getLoaiDoiTuong()
        {
            return LoaiDoiTuong;
        }

        public Staff() : base()
        {
            MaNV = "";
            BangCap = "";
            LoaiDoiTuong = 2;
        }
        public Staff(string Ten, int Tuoi, string GioiTinh, string NgaySinh,
            string MaNV, string BangCap) 
            : base(Ten, Tuoi, GioiTinh, NgaySinh)          
        {
            this.MaNV = MaNV;
            this.BangCap = BangCap;
            LoaiDoiTuong = 2;
        }

        public override void NhapThongTin()
        {
            base.NhapThongTin();
            Console.Write("Nhap ma nhan vien: ");
            MaNV = Console.ReadLine();
            Console.Write("Bang Cap: ");
            BangCap = Console.ReadLine();
        }
        public override void XuatThongTin()
        {
            base.XuatThongTin();
            Console.WriteLine("Ma so nhan vien: " + MaNV);
            Console.WriteLine("Bang Cap: "  + BangCap);
        }
    }
}
