using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class SinhVien
{
    public string MSSV { get; set; }
    public string HoTen { get; set; }
    public double DiemToan { get; set; }
    public double DiemLy { get; set; }
    public double DiemHoa { get; set; }

    public double DiemTrungBinh
    {
        get { return (DiemToan + DiemLy + DiemHoa) / 3; }
    }
}

class Program
{
    static List<SinhVien> danhSachSinhVien = new List<SinhVien>();

    static void Main(string[] args)
    {
        try
        {
            // a. Nhập số lượng sinh viên
            NhapSoLuongSinhVien();
            // b. Nhập thông tin sinh viên
            NhapThongTinSinhVien();
            // c. Tính điểm trung bình
            TinhDiemTrungBinh();
            // d. Hiển thị thông tin sinh viên
            HienThiThongTinSinhVien();
            // e. Hiển thị sinh viên đầu tiên có điểm trung bình > 9.5
            HienThiSinhVienDiemTrungBinhCaoHon(9.5);
            // g. Đếm số sinh viên có điểm trung bình lớn hơn 5.0
            int soSinhVienDiemTrungBinhHon5 = DemSoSinhVienDiemTrungBinhHon5();
            Console.WriteLine($"So sinh vien co diem trung binh lon hon 5.0: {soSinhVienDiemTrungBinhHon5}");
            // h. Sắp xếp danh sách sinh viên theo thứ tự điểm trung bình từ thấp đến cao
            SapXepSinhVienTheoDiemTrungBinh();
            HienThiThongTinSinhVien();
            // i. Sắp xếp sinh viên theo thứ tự alphabet của Họ tên sinh viên
            SapXepSinhVienTheoHoTen();
            HienThiThongTinSinhVien();
            // k. Ghi thông tin sinh viên vào file với tên file là tham số
            Console.Write("Nhap ten file de ghi thong tin sinh vien: ");
            string tenFile = Console.ReadLine();
            GhiThongTinSinhVienVaoFile(tenFile);
            Console.WriteLine("Da ghi thong tin sinh vien vao file.");
            // l. Đọc thông tin sinh viên từ một file đã ghi ở câu k
            Console.WriteLine("Doc thong tin sinh vien tu file:");
            DocThongTinSinhVienTuFile(tenFile);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Co loi xay ra: " + ex.Message);
        }
    }

    // a. Nhập số lượng sinh viên
    static void NhapSoLuongSinhVien()
    {
        try
        {
            Console.Write("Nhap so luong sinh vien: ");
            int soLuongSinhVien = int.Parse(Console.ReadLine());
            for (int i = 0; i < soLuongSinhVien; i++)
            {
                SinhVien sv = new SinhVien();
                danhSachSinhVien.Add(sv);
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Co loi xay ra khi nhap so luong sinh viên: " + ex.Message);
        }
    }

    // b. Nhập thông tin sinh viên
    static void NhapThongTinSinhVien()
    {
        for (int i = 0; i < danhSachSinhVien.Count; i++)
        {
            try
            {
                SinhVien sv = danhSachSinhVien[i];
                Console.WriteLine($"Nhap thong tin sinh vien thu {i + 1}:");
                Console.Write("MSSV: ");
                sv.MSSV = Console.ReadLine();
                Console.Write("Ho ten: ");
                sv.HoTen = Console.ReadLine();
                Console.Write("Diem Toan: ");
                sv.DiemToan = double.Parse(Console.ReadLine());
                Console.Write("Điem Ly: ");
                sv.DiemLy = double.Parse(Console.ReadLine());
                Console.Write("Diem Hoa: ");
                sv.DiemHoa = double.Parse(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine("Co loi xay ra khi nhap thong tin sinh vien: " + ex.Message);
                i--;
            }
        }
    }

    // c. Tính điểm trung bình
    static void TinhDiemTrungBinh()
    {
        foreach (var sv in danhSachSinhVien)
        {
            // Điểm trung bình được tính tự động trong thuộc tính DiemTrungBinh
        }
    }

    // d. Hiển thị thông tin sinh viên
    static void HienThiThongTinSinhVien()
    {
        Console.WriteLine("\nThong tin sinh vien:");
        foreach (var sv in danhSachSinhVien)
        {
            Console.WriteLine($"MSSV: {sv.MSSV}, Ho ten: {sv.HoTen}, Diem trung binh: {sv.DiemTrungBinh:F2}");
        }
    }

    // e. Hiển thị sinh viên đầu tiên có điểm trung bình > 9.5
    static void HienThiSinhVienDiemTrungBinhCaoHon(double diem)
    {
        foreach (var sv in danhSachSinhVien)
        {
            if (sv.DiemTrungBinh > diem)
            {
                Console.WriteLine($"\nSinh vien co diem trung binh > {diem}: MSSV: {sv.MSSV}, Ho ten: {sv.HoTen}, Diem trung binh: {sv.DiemTrungBinh:F2}");
                break;
            }
        }
    }

    // g. Đếm số sinh viên có điểm trung bình lớn hơn 5.0
    static int DemSoSinhVienDiemTrungBinhHon5()
    {
        int count = 0;
        foreach (var sv in danhSachSinhVien)
        {
            if (sv.DiemTrungBinh > 5.0)
            {
                count++;
            }
        }
        return count;
    }

    // h. Sắp xếp danh sách sinh viên theo thứ tự điểm trung bình từ thấp đến cao
    static void SapXepSinhVienTheoDiemTrungBinh()
    {
        danhSachSinhVien.Sort((sv1, sv2) => sv1.DiemTrungBinh.CompareTo(sv2.DiemTrungBinh));
        Console.WriteLine("\nDanh sach sinh vien da duoc sap xep theo diem trung binh tu thap den cao.");
    }

    // i. Sắp xếp sinh viên theo thứ tự alphabet của Họ tên sinh viên
    static void SapXepSinhVienTheoHoTen()
    {
        danhSachSinhVien.Sort((sv1, sv2) => string.Compare(sv1.HoTen, sv2.HoTen, StringComparison.Ordinal));
        Console.WriteLine("\nDanh sach sinh vien da duoc sap xep theo thu tu alphabet cua Ho ten.");
    }

    // k. Ghi thông tin sinh viên vào file với tên file là tham số
    static void GhiThongTinSinhVienVaoFile(string tenFile)
    {
        try
        {
            using (StreamWriter sw = new StreamWriter(tenFile))
            {
                foreach (var sv in danhSachSinhVien)
                {
                    sw.WriteLine($"{sv.MSSV},{sv.HoTen},{sv.DiemToan},{sv.DiemLy},{sv.DiemHoa},{sv.DiemTrungBinh:F2}");
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Co loi xay ra khi ghi thong tin sinh vien vao file: " + ex.Message);
        }
    }

    // l. Đọc thông tin sinh viên từ một file đã ghi ở câu k
    static void DocThongTinSinhVienTuFile(string tenFile)
    {
        try
        {
            using (StreamReader sr = new StreamReader(tenFile))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] data = line.Split(',');
                    SinhVien sv = new SinhVien
                    {
                        MSSV = data[0],
                        HoTen = data[1],
                        DiemToan = double.Parse(data[2]),
                        DiemLy = double.Parse(data[3]),
                        DiemHoa = double.Parse(data[4])
                    };
                    danhSachSinhVien.Add(sv);
                }
            }
            Console.WriteLine("\nThong tin sinh vien tu file:");
            HienThiThongTinSinhVien();
        }
        catch (Exception ex)
        {
            Console.WriteLine("Co loi xay ra khi doc thong tin sinh vien tu file: " + ex.Message);
        }
    }
}
