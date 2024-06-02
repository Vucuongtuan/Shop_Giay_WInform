using System;

public class DSKH
{
    public string MaKH { get; set; }
    public string TenKH { get; set; }
    public string SoDienThoai { get; set; }
    public string DiaChi { get; set; }
    public string Email { get; set; }
    public string GioiTinh { get; set; }
    //public string TK_KH { get; set; }
    //public string Pass { get; set; }
}

public class QLTK
{
    //User
    public string MaKH { get; set; }
    public string TenKH { get; set; }
    public string Pass { get; set; }
    public string SoDienThoai { get; set; }
    public string Email { get; set; }
    public string TK_KH { get; set; }
    public string PassKH { get; set; }

    //Admin
    public int MaNV { get; set; }
    public string TenNV { get; set; }
    public string Ten_TK { get; set; }
    public string PassNV { get; set; }
    public string SoDienThoaiNV { get; set; }
    public string EmailNV { get; set; }
    public string HinhAnh { get; set; }
    public DateTime NgaySinh { get; set; }

    //phan loại tk
    public string PhanLoaiTK { get; set; }
}

public class DSNV
{
    public int MaNV { get; set; }
    public string TenNV { get; set; }
    public string Ten_TK { get; set; }
    public string Pass { get; set; }
    public string SoDienThoai { get; set; }
    public DateTime NgaySinh { get; set; }
    public string Email { get; set; }
    public string HinhAnh { get; set; }
    public string GioiTinh { get; set; }
}

public class DSSP
{
    public int MaSP { get; set; }
    public string TenSP { get; set; }
    public string MoTa { get; set; }
    public string HinhAnh { get; set; }
    public string Gia { get; set; }
    public string LoaiSP { get; set; }
    public string TenLoaiSP { get; set; }
    ///

}
public class MuaHang { 
    public int MaHD { get; set; }
    public DateTime NgayDat  {get;set;}
    public string TongTien { get; set; }
    public int Soluong{get;set;}
    public string MaKH{get;set;}
    public int MaSP { get; set; }
}
public class Cbo
{
    public string MaLoaiSP { get; set; }
    public string TenLoaiSP { get; set; }


}
public class DSBAN
{
    public int MaSP { get; set; }
    public string TenSP { get; set; }
    public string MoTa { get; set; }
    public string HinhAnh { get; set; }
    public string Gia { get; set; }
    public string LoaiSP { get; set; }
    public string TenLoaiSP { get; set; }
    public string MaLoaiSP { get; set; }
}

public class DanhGia { 
    public int MaSP { get; set; }
    public string TenNguoiDG { get; set; }
    public string DanhGiaSP { get; set; }
    public string TenSP { get;set; }
    public string Gia { get; set; }
    public string HinhAnh { get; set; }
}
