using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2207A
{
    class SinhVien
    {
        public int id;
        public string ten;
        public string gioiTinh;
        public int tuoi;
        public double diemToan;
        public double diemLy;
        public double diemHoa;
        public double diemTrungBinh;
        public string hocLuc;

    }
    internal class Program
    {
        static List<SinhVien> danhSachSinhVien = new List<SinhVien>();

        static void Main(string[] args)
        {
            bool tiepTuc = true;
            while (tiepTuc)
            {
                Console.WriteLine("Chon mot chuc nang:");
                Console.WriteLine("1. Them sinh vien.");
                Console.WriteLine("2. Cap nhat thong tin sinh vien boi ID.");
                Console.WriteLine("3. Xoa sinh vien boi ID.");
                Console.WriteLine("4. Tim kiem sinh vien theo ten.");
                Console.WriteLine("5. Sap xep sinh vien theo diem trung binh (GPA).");
                Console.WriteLine("6. Sap xep sinh vien theo ten.");
                Console.WriteLine("7. Sap xep sinh vien theo ID.");
                Console.WriteLine("8. Hien thi danh sach sinh vien.");
                Console.WriteLine("9. Thoat chuong trinh.");
                Console.Write("Nhap lua chon cua ban: ");

                int luaChon = int.Parse(Console.ReadLine());
                Console.WriteLine();

                switch (luaChon)
                {
                    case 1:
                        ThemSinhVien();
                        break;
                    case 2:
                        CapNhatThongTinSinhVien();
                        break;
                    case 3:
                        XoaSinhVien();
                        break;
                    case 4:
                        TimKiemSinhVienTheoTen();
                        break;
                    case 5:
                        SapXepSinhVienTheoDTB();
                        break;
                    case 6:
                        SapXepSinhVienTheoTen();
                        break;
                    case 7:
                        SapXepSinhVienTheoID();
                        break;
                    case 8:
                        //HienThiDanhSachSinhVien();
                        break;
                    case 9:
                        break;
                    default:
                        Console.WriteLine("Lua chon khong hop le, vui long chon lai !");
                        break;
                }

                Console.WriteLine();
            }
        }

        static void ThemSinhVien()
        {
            SinhVien sv = new SinhVien();

            Console.Write("Nhap ID: ");
            sv.id = int.Parse(Console.ReadLine());

            Console.Write("Nhap ten: ");
            sv.ten = Console.ReadLine();

            Console.Write("Nhap gioi tinh: ");
            sv.gioiTinh = Console.ReadLine();

            Console.Write("Nhap tuoi: ");
            sv.tuoi = int.Parse(Console.ReadLine());

            Console.Write("Nhap diem toan: ");
            sv.diemToan = double.Parse(Console.ReadLine());

            Console.Write("Nhap diem ly: ");
            sv.diemLy = double.Parse(Console.ReadLine());
            Console.Write("Nhap diem hoa: ");
            sv.diemHoa = double.Parse(Console.ReadLine());

            sv.diemTrungBinh = (sv.diemToan + sv.diemLy + sv.diemHoa) / 3;

            if (sv.diemTrungBinh >= 8)
            {
                sv.hocLuc = "Gioi";
            }
            else if (sv.diemTrungBinh >= 6.5)
            {
                sv.hocLuc = "Kha";
            }
            else if (sv.diemTrungBinh >= 5)
            {
                sv.hocLuc = "Trung Binh";
            }
            else
            {
                sv.hocLuc = "Yeu";
            }

            danhSachSinhVien.Add(sv);

            Console.WriteLine("Da them sinh vien thanh cong.");
        }

        static void CapNhatThongTinSinhVien()
        {
            Console.Write("Nhap ID cua sinh vien can cap nhat: ");
            int id = int.Parse(Console.ReadLine());

            SinhVien sv = danhSachSinhVien.Find(s => s.id == id);

            if (sv == null)
            {
                Console.WriteLine("Khong tim thay sinh vien co ID la {0}.", id);
            }
            else
            {
                Console.WriteLine("Thong tin cua sinh vien la:");
                HienThiThongTinSinhVien(sv);

                Console.Write("Nhap ten moi: ");
                sv.ten = Console.ReadLine();

                Console.Write("Nhap gioi tinh moi: ");
                sv.gioiTinh = Console.ReadLine();

                Console.Write("Nhap tuoi moi: ");
                sv.tuoi = int.Parse(Console.ReadLine());

                Console.Write("Nhap diem toan moi: ");
                sv.diemToan = double.Parse(Console.ReadLine());

                Console.Write("Nhap diem ly moi: ");
                sv.diemLy = double.Parse(Console.ReadLine());

                Console.Write("Nhap diem hoa moi: ");
                sv.diemHoa = double.Parse(Console.ReadLine());

                sv.diemTrungBinh = (sv.diemToan + sv.diemLy + sv.diemHoa) / 3;

                if (sv.diemTrungBinh >= 8)
                {
                    sv.hocLuc = "Gioi";
                }
                else if (sv.diemTrungBinh >= 6.5)
                {
                    sv.hocLuc = "Kha";
                }
                else if (sv.diemTrungBinh >= 5)
                {
                    sv.hocLuc = "Trung Binh";
                }
                else
                {
                    sv.hocLuc = "Yeu";
                }

                Console.WriteLine("Da cap nhat thong tin cua sinh vien co ID la {0}.", id);
            }
        }

        static void XoaSinhVien()
        {
            Console.Write("Nhap ID cua sinh vien can xoa: ");
            int id = int.Parse(Console.ReadLine());

            SinhVien sv = danhSachSinhVien.Find(s => s.id == id);

            if (sv == null)
            {
                Console.WriteLine("Khong tim thay sinh vien co ID la {0}.", id);
            }
            else
            {
                danhSachSinhVien.Remove(sv);
                Console.WriteLine("Da xoa sinh vien co ID la {0}.", id);
            }
        }

        static void TimKiemSinhVienTheoTen()
        {
            Console.Write("Nhap ten cua sinh vien can tim kiem : ");
            string ten = Console.ReadLine();
            List<SinhVien> danhSachKetQua = danhSachSinhVien.FindAll(s => s.ten.ToLower().Contains(ten.ToLower()));

            if (danhSachKetQua.Count == 0)
            {
                Console.WriteLine("Khong tim thay sinh vien nao co ten la {0}.", ten);
            }
            else
            {
                Console.WriteLine("Ket qua tim kiem:");
                HienThiDanhSachSinhVien(danhSachKetQua);
            }
        }

        static void SapXepSinhVienTheoDTB()
        {
            danhSachSinhVien.Sort(delegate (SinhVien s1, SinhVien s2)
            {
                return s2.diemTrungBinh.CompareTo(s1.diemTrungBinh);
            });

            Console.WriteLine("Da sap xep danh sach sinh vien theo diem trung binh.");
            HienThiDanhSachSinhVien(danhSachSinhVien);
        }

        static void SapXepSinhVienTheoTen()
        {
            danhSachSinhVien.Sort(delegate (SinhVien s1, SinhVien s2)
            {
                return s1.ten.CompareTo(s2.ten);
            });

            Console.WriteLine("Da sap xep danh sach sinh vien theo ten.");
            HienThiDanhSachSinhVien(danhSachSinhVien);
        }

        static void SapXepSinhVienTheoID()
        {
            danhSachSinhVien.Sort(delegate (SinhVien s1, SinhVien s2)
            {
                return s1.id.CompareTo(s2.id);
            });

            Console.WriteLine("Da sap xep danh sach sinh vien theo ID.");
            HienThiDanhSachSinhVien(danhSachSinhVien);
        }

        static void HienThiDanhSachSinhVien(List<SinhVien> danhSach)
        {
            Console.WriteLine("Danh sach sinh vien : ");

            foreach (SinhVien sv in danhSach)
            {
                HienThiThongTinSinhVien(sv);
            }
        }

        static void HienThiThongTinSinhVien(SinhVien sv)
        {
            Console.WriteLine("Thong tin sinh vien : ", sv.id, sv.ten, sv.gioiTinh, sv.tuoi, sv.diemToan, sv.diemLy, sv.diemHoa, sv.hocLuc);
        }


        
    }
}