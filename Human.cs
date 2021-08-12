using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaffManager
{
    class Human
    {
        // Thuộc tính
        protected string Ten;
        protected int Tuoi;
        protected string GioiTinh;
        protected string NgaySinh;
        protected int LoaiDoiTuong; // Khach = 1 ; Staff = 2;

        // Phương thức
        public virtual int getLoaiDoiTuong()
        {
            return LoaiDoiTuong;
        }
        
        
        public Human() // Phương thức khởi tạo
        {
            Ten = "";
            Tuoi = 0;
            GioiTinh = "";
            NgaySinh = "";
        }
       public Human(string Ten, int Tuoi, string GioiTinh, string NgaySinh) // Phương thức khởi tạo
        { 
            this.Ten = Ten;
            this.Tuoi = Tuoi;
            this.GioiTinh = GioiTinh;
            this.NgaySinh = NgaySinh;
        }
        public virtual void NhapThongTin()
        {
            Console.WriteLine("--------------------------------");
            Console.WriteLine("Ten la: ");
            Ten = Console.ReadLine();
            Console.WriteLine("Tuoi la: ");
            Tuoi = int.Parse(Console.ReadLine());
            Console.WriteLine("Gioi tinh la: ");
            GioiTinh = (Console.ReadLine());
            Console.WriteLine("Ngay sinh la: ");
            NgaySinh = Console.ReadLine();
            
        }
        public virtual void XuatThongTin()
        {
            Console.WriteLine("--------------------------------");
            Console.WriteLine("Ten la: " + Ten);
            Console.WriteLine("Tuoi la: " + Tuoi);
            if(GioiTinh == "Nam" || GioiTinh == "Nu")
            {
                Console.WriteLine("Gioi tinh la: " + GioiTinh);
            }
            else
            {
                Console.WriteLine("Khong co gioi tinh nay");
            }
            Console.WriteLine("Ngay sinh la: " + NgaySinh);
        }
    }
}
