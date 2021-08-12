using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace StaffManager
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;
            Console.Title = "Phần Mề Quản Lý Nhân Sự";
            int i = 0;
            
            int iHuman = 1;
            Human[] listHuman = new Human[50];
            Console.WriteLine("1. Thêm nhân viên");
            Console.WriteLine("2. Thêm khách hàng");
            Console.WriteLine("3. Hiện tất cả danh sách nhân viên");
            Console.WriteLine("4. Hiện tất cả danh sách khách hàng ");
            Console.WriteLine("5. Hiện tất cả danh sách");
            Console.WriteLine("6. Thống kê khách hàng");
            Console.WriteLine("7. Thoát");
            Console.Write("Nhập chức năng bạn muốn sự dụng: ");

            while (i < 50)
            {
                int ThuTu = 1;
                int ChucNang = int.Parse(Console.ReadLine());
                switch (ChucNang)
                {
                    case 1: // Thêm nhân viên
                        {
                            listHuman[iHuman] = new Staff();
                            listHuman[iHuman].NhapThongTin();
                            iHuman++;
                            break;
                        }
                    case 2: // Thêm khách hàng
                        {
                            listHuman[iHuman] = new Customer();
                            listHuman[iHuman].NhapThongTin();
                            iHuman++;
                            break;
                        }
                    case 3: // Hiện Staff
                        {
                            for (ThuTu = 1; ThuTu < iHuman; ThuTu++)

                            {
                                if (listHuman[ThuTu].getLoaiDoiTuong() == 2)
                                {
                                    listHuman[ThuTu].XuatThongTin();
                                }
                            }
                            break;
                        }
                    case 4: //Hiện Cus
                        {
                            for (ThuTu = 1; ThuTu < iHuman; ThuTu++)

                            {   if (listHuman[ThuTu].getLoaiDoiTuong() == 1)
                                {
                                    listHuman[ThuTu].XuatThongTin();
                                }
                            }
                            break;
                        }
                    case 5: //Hiện tất cả
                        {
                            while (ThuTu < iHuman)
                            {
                                listHuman[ThuTu].XuatThongTin();
                                ThuTu++;
                            }
                            break;
                        }
                    case 6: //Thống kê khách hàng
                        {
                            int TongKhach = 0;
                            while (ThuTu < iHuman && listHuman[ThuTu].getLoaiDoiTuong() == 1)
                            {
                                TongKhach++;
                            }
                            Console.WriteLine(TongKhach);
                            break;
                        }
                    default:
                        break;
                }
                i++;
                Console.Write("------------------------------");
            }
            Console.ReadKey();
        }
    }
}
