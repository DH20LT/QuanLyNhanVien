using System;
using System.Text;

namespace StaffManager
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;
            Console.Title = "Phần Mềm Quản Lý Nhân Sự";
            int i = 0;
            
            int iHuman = 1; // Lượng người
            Human[] listHuman = new Human[50];
            do
            {
                Console.Clear();
                Console.WriteLine("1. Thêm nhân viên");
                Console.WriteLine("2. Thêm khách hàng");
                Console.WriteLine("3. Hiện tất cả danh sách nhân viên");
                Console.WriteLine("4. Hiện tất cả danh sách khách hàng ");
                Console.WriteLine("5. Hiện tất cả danh sách");
                Console.WriteLine("6. Thống kê khách hàng");
                Console.WriteLine("7. Thoát");
                Console.Write("Nhập chức năng bạn muốn sự dụng: ");
                int ThuTu;
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
                            Console.ReadKey();
                            break;
                        }
                    case 4: //Hiện Cus
                        {
                            for (ThuTu = 1; ThuTu < iHuman; ThuTu++)

                            { if (listHuman[ThuTu].getLoaiDoiTuong() == 1)
                                {
                                    listHuman[ThuTu].XuatThongTin();
                                }
                            }
                            Console.ReadKey();
                            break;
                        }
                    case 5: //Hiện tất cả
                        {
                            for (ThuTu = 1; ThuTu < iHuman; ThuTu++)
                            {
                                listHuman[ThuTu].XuatThongTin();
                            }
                            Console.ReadKey();
                            break;
                        }
                    case 6: //Thống kê khách hàng
                        {
                            // count how many customers in the list
                            int CustomerCount = 0;
                            for (ThuTu = 1; ThuTu < iHuman; ThuTu++)
                            {
                                if (listHuman[ThuTu].getLoaiDoiTuong() == 1)
                                {
                                    CustomerCount++;
                                }
                            }
                            Console.WriteLine("Có {0} khách hàng trong danh sách", CustomerCount);
                            Console.ReadKey();
                            break;
                        }
                    default:
                        break;
                }
                i++;
                Console.Write("------------------------------");
            }while (true);
        }
    }
}
