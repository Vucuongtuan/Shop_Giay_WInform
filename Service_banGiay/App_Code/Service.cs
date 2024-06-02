using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Services;

[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
// To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
// [System.Web.Script.Services.ScriptService]

public class Service : System.Web.Services.WebService
{
    public Service () {

        //Uncomment the following line if using designed components 
        //InitializeComponent(); 
    }

    [WebMethod]
    public string HelloWorld() {
        return "Hello World";
    }
    //public string LayPassAccountKH(string sodienthoai) {
    //    string connectionString = "Shop_GiayConnectionString";
    //    using (Data data = new Data(connectionString)) {
    //        var query = from KhachHang in data.KhachHang
    //                    join AccountKH in data.AccountKH on KhachHang.SoDienThoai equals AccountKH.SoDienThoai
    //                    where KhachHang.SoDienThoai == sodienthoai
    //                    select AccountKH.Pass;
    //        return query.FirstOrDefault();
    //    }
    //}
    //public class DSKH
    //{
    //    public string MaKH { get; set; }
    //    public string TenKH { get; set; }
    //    public int SoDienThoai { get; set; }
    //    public string DiaChi { get; set; }
    //    public string Email { get; set; }
    //}

    SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Shop_GiayConnectionString"].ToString());

    //Dangnhap

    //[WebMethod]
    //public List<QLTK> GetLogin(string TK, string Pass)
    //{
    //    List<QLTK> Qltk = new List<QLTK>();
    //    using (conn)
    //    {
    //        string loginUser_query = "SELECT KhachHang.MaKH, KhachHang.TenKH, AccountKH.MaKH, AccountKH.Pass FROM AccountKH JOIN KhachHang ON AccountKH.MaKH = KhachHang.MaKH WHERE AccountKH.MaKH = @MaKH AND AccountKH.Pass = @Password";
    //        SqlCommand command_Kh = new SqlCommand(loginUser_query, conn);
    //        command_Kh.Parameters.AddWithValue("@MaKH", TK);
    //        command_Kh.Parameters.AddWithValue("@Password", Pass);
    //        string loginAdmin_query = "SELECT NhanVien.MaNV, NhanVien.TenNV, AccountAdmin.Ten_TK, AccountAdmin.Pass FROM AccountAdmin JOIN NhanVien ON AccountAdmin.MaNV = NhanVien.MaNV WHERE AccountAdmin.Ten_TK = @TK AND AccountAdmin.Pass = @Password";
    //        SqlCommand command_admin = new SqlCommand(loginAdmin_query, conn);
    //        command_admin.Parameters.AddWithValue("@TK", TK);
    //        command_admin.Parameters.AddWithValue("@Password", Pass);
    //        conn.Open();
    //        using (SqlDataReader reader_KH = command_Kh.ExecuteReader())
    //        {
    //            if (reader_KH.HasRows)
    //            {
    //                while (reader_KH.Read())
    //                {
    //                    QLTK user = new QLTK();

    //                    user.TenKH = reader_KH.GetString(1);
    //                    user.TK_KH = reader_KH.GetString(2);
    //                    user.PassKH = reader_KH.GetString(3);
    //                    user.PhanLoaiTk = "User";
    //                    Qltk.Add(user);
    //                }
    //            }
    //        }
    //        using (SqlDataReader reader_admin = command_admin.ExecuteReader())
    //        {
    //            if (reader_admin.HasRows)
    //            {
    //                while (reader_admin.Read())
    //                {
    //                    QLTK admin = new QLTK();
    //                    admin.MaNV = reader_admin.GetInt32(0);
    //                    admin.TenNV = reader_admin.GetString(1);
    //                    admin.Ten_TK = reader_admin.GetString(2);
    //                    admin.PassNV = reader_admin.GetString(3);
    //                    admin.PhanLoaiTk = "Admin";
    //                    Qltk.Add(admin);
    //                }
    //            }
    //        }

    //    }
    //    return Qltk;
    //}


    //DangNhap
    [WebMethod]
    public List<QLTK> GetLoginAdmin(string TK, string Pass) {
        List<QLTK> Qltk = new List<QLTK>();
        using (conn)
        {
            string loginAdmin_query = "SELECT NhanVien.MaNV, NhanVien.TenNV, AccountAdmin.Ten_TK, AccountAdmin.Pass FROM AccountAdmin JOIN NhanVien ON AccountAdmin.MaNV = NhanVien.MaNV WHERE AccountAdmin.Ten_TK = @TK AND AccountAdmin.Pass = @Password";
            SqlCommand command_admin = new SqlCommand(loginAdmin_query, conn);
            command_admin.Parameters.AddWithValue("@TK", TK);
            command_admin.Parameters.AddWithValue("@Password", Pass);

            conn.Open();
            using (SqlDataReader reader_admin = command_admin.ExecuteReader())
            {
                if (reader_admin.HasRows)
                {
                    while (reader_admin.Read())
                    {
                        QLTK admin = new QLTK();
                        admin.MaNV = reader_admin.GetInt32(0);
                        admin.TenNV = reader_admin.GetString(1);
                        admin.Ten_TK = reader_admin.GetString(2);
                        admin.PassNV = reader_admin.GetString(3);
                        admin.PhanLoaiTK = "Admin";
                   
                        Qltk.Add(admin);
                    }
                }
            }
        }
        return Qltk;
    }
    [WebMethod]
    public List<QLTK> GetLoginKH(string TK, string Pass)
    {
        List<QLTK> Qltk = new List<QLTK>();
        using (conn)
        {
            string loginUser_query = "SELECT KhachHang.MaKH, KhachHang.TenKH, AccountKH.MaKH, AccountKH.Pass FROM AccountKH JOIN KhachHang ON AccountKH.MaKH = KhachHang.MaKH WHERE AccountKH.MaKH = @MaKH AND AccountKH.Pass = @Password";
            SqlCommand command_Kh = new SqlCommand(loginUser_query, conn);
            command_Kh.Parameters.AddWithValue("@MaKH", TK);
            command_Kh.Parameters.AddWithValue("@Password", Pass);
            conn.Open();
            using (SqlDataReader reader_KH = command_Kh.ExecuteReader())
            {
                if (reader_KH.HasRows)
                {
                    while (reader_KH.Read())
                    {
                        QLTK user = new QLTK();
                        user.MaKH = reader_KH.GetString(0);
                        user.TenKH = reader_KH.GetString(1);
                        user.TK_KH = reader_KH.GetString(2);
                        user.PassKH = reader_KH.GetString(3);
                        user.PhanLoaiTK = "User";
                        Qltk.Add(user);
                    }
                }
            }

        }
        return Qltk;
    }

    //KhachHang
    [WebMethod]
    public List<DSKH> GetDSKH()
    {
        List<DSKH> DanhSachKH = new List<DSKH>();

        using (conn)
        {
            conn.Open();
            //string query = "Select * From KhachHang Join AccountKH On KhachHang.MaKH = AccountKH.MaKH ";
            string query = "Select * From KhachHang";
            SqlCommand command_XuatKH = new SqlCommand(query, conn);
            using (SqlDataReader reader = command_XuatKH.ExecuteReader())
            {
                while (reader.Read())
                {
                    DSKH ds = new DSKH();
                    ds.MaKH = reader["MaKH"].ToString();
                    ds.TenKH = reader["TenKH"].ToString();
                    ds.SoDienThoai = reader["SoDienThoai"].ToString();
                    ds.DiaChi = reader["DiaChi"].ToString();
                    ds.Email = reader["Email"].ToString();
                    ds.GioiTinh = reader["GioiTinh"].ToString();
                    //ds.TK_KH = reader["TK_KH"].ToString();
                    //ds.Pass = reader["Pass"].ToString();
                    DanhSachKH.Add(ds);
                }
            }
        }
        return DanhSachKH;

    }
    [WebMethod]
    public List<DSKH> GetTimKiemKH(string tenKH)
    {
        List<DSKH> dsTimKiem = new List<DSKH>();
        using (conn)
        {
            string timkiem_query = "Select * From KhachHang Where TenKH Like '%' + @TenKH +'%'";
            SqlCommand command = new SqlCommand(timkiem_query, conn);
            command.Parameters.AddWithValue("@TenKH", tenKH);
            conn.Open();
            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    DSKH ds = new DSKH();
                    ds.MaKH = reader["MaKH"].ToString();
                    ds.TenKH = reader["TenKH"].ToString();
                    ds.SoDienThoai = reader["SoDienThoai"].ToString();
                    ds.DiaChi = reader["DiaChi"].ToString();
                    ds.Email = reader["Email"].ToString();
                    ds.GioiTinh = reader["GioiTinh"].ToString();
                    dsTimKiem.Add(ds);
                }
            }
            conn.Close();
        }
        return dsTimKiem;
    }
    [WebMethod]
    public List<DSKH> GetThemKH(string MaKH,string TenKH, string SoDienThoai, string DiaChi, string Email, string GioiTinh)
    {
        List<DSKH> dsthemKH = new List<DSKH>();
        using (conn)
        {
            conn.Open();
            string themKH_query = "Insert into KhachHang (MaKH,TenKH,SoDienThoai,DiaChi,Email,GioiTinh) Values(@MaKH ,@TenKH,@SoDienThoai,@DiaChi,@Email,@GioiTinh)";
            SqlCommand command_themKH = new SqlCommand(@themKH_query, conn);
            command_themKH.Parameters.AddWithValue("@MaKH", MaKH);
            command_themKH.Parameters.AddWithValue("@TenKH", TenKH);
            command_themKH.Parameters.AddWithValue("@SoDienThoai", SoDienThoai);
            command_themKH.Parameters.AddWithValue("@DiaChi", DiaChi);
            command_themKH.Parameters.AddWithValue("@Email", Email);
            command_themKH.Parameters.AddWithValue("@GioiTinh", GioiTinh);
            command_themKH.ExecuteNonQuery();
            conn.Close();
        }
        return dsthemKH;
    }

    [WebMethod]
    public List<QLTK> ThemTKKH(string MaKH, string Pass)
    {
        List<QLTK> themTKKH = new List<QLTK>();
        using (conn)
        {
            conn.Open();
            string themTKKH_query = "Insert into AccountKH (MaKH,Pass) Values(@MaKH, @Pass)";
            SqlCommand command_themTKKH = new SqlCommand(themTKKH_query, conn);
            command_themTKKH.Parameters.AddWithValue("@MaKH", MaKH);
            command_themTKKH.Parameters.AddWithValue("@Pass", Pass);
            command_themTKKH.ExecuteNonQuery();
            conn.Close();
        }
        return themTKKH;
    }

    [WebMethod]
    public List<DSKH> GetXoaKH(String MaKH)
    {
        List<DSKH> dsXoaKH = new List<DSKH>();
        using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Shop_GiayConnectionString"].ToString()))
        {
            conn.Open();
            string xoaAccountKHQuery = "DELETE FROM AccountKH WHERE MaKH = @MaKH";
            SqlCommand xoaAccountKHCommand = new SqlCommand(xoaAccountKHQuery, conn);
            xoaAccountKHCommand.Parameters.AddWithValue("@MaKH", MaKH);
             xoaAccountKHCommand.ExecuteNonQuery();

            string xoaKhachHangQuery = "DELETE FROM KhachHang WHERE MaKH = @MaKH";
            SqlCommand xoaKhachHangCommand = new SqlCommand(xoaKhachHangQuery, conn);
            xoaKhachHangCommand.Parameters.AddWithValue("@MaKH", MaKH);
            xoaKhachHangCommand.ExecuteNonQuery();
            conn.Close();
        }
        return dsXoaKH;

    }

    [WebMethod]
    public List<DSKH> GetSuaKH(string MaKH, string TenKH, string SoDienThoai, string DiaChi, string Email, string GioiTinh)
    {
        List<DSKH> dsSuaKH = new List<DSKH>();
        using (conn)
        {
            conn.Open();
            string suaKH_query = "Update KhachHang Set TenKH = @TenKH , SoDienThoai = @SoDienThoai , DiaChi = @DiaChi , Email = @Email , GioiTinh = @GioiTinh Where MaKH = @MaKH";
            SqlCommand command = new SqlCommand(suaKH_query, conn);
            command.Parameters.AddWithValue("@MaKH", MaKH);
            command.Parameters.AddWithValue("@TenKH", TenKH);
            command.Parameters.AddWithValue("@SoDienThoai", SoDienThoai);
            command.Parameters.AddWithValue("@DiaChi", DiaChi);
            command.Parameters.AddWithValue("@Email", Email);
            command.Parameters.AddWithValue("@GioiTinh", GioiTinh);
            command.ExecuteNonQuery();
            conn.Close();
        }
        return dsSuaKH;
    }


    //Danh Sach Nhan Vien
    [WebMethod]
    public List<DSNV> GetDSNV()
    {
        List<DSNV> DanhSachNV = new List<DSNV>();

        using (conn)
        {
            conn.Open();
            string query = "Select * From NhanVien Join AccountAdmin On NhanVien.MaNV = AccountAdmin.MaNV ";
            SqlCommand command_XuatNV = new SqlCommand(query, conn);
            using (SqlDataReader reader = command_XuatNV.ExecuteReader())
            {
                while (reader.Read())
                {
                    DSNV ds = new DSNV();
                    ds.MaNV = Convert.ToInt32(reader["MaNV"]);
                    ds.TenNV = reader["TenNV"].ToString();
                    ds.SoDienThoai = reader["SoDienThoai"].ToString();
                    ds.Email = reader["Email"].ToString();
                    ds.GioiTinh = reader["GioiTinh"].ToString();
                    ds.NgaySinh = (DateTime)reader["NgaySinh"];
                    ds.HinhAnh = reader["HinhAnh"].ToString();
                    ds.Ten_TK = reader["Ten_TK"].ToString();
                    ds.Pass = reader["Pass"].ToString();
                    DanhSachNV.Add(ds);
                }
            }
            conn.Close();
        }
        return DanhSachNV;

    }
    [WebMethod]
    public List<DSNV> GetThemNV(string TenNV, string SoDienThoai, string Ten_TK, string Pass, string Email, string GioiTinh, string HinhAnh, DateTime NgaySinh)
    {
        List<DSNV> dsthemNV = new List<DSNV>();
        using (conn)
        {
            conn.Open();
            string themKH_query = "Insert into NhanVien (TenNV,SoDienThoai,Hinhanh,NgaySinh,Email,GioiTinh)  Values(@TenNV,@SoDienThoai,@Hinhanh,@NgaySinh,@Email,@GioiTinh);SELECT SCOPE_IDENTITY()";
            SqlCommand command_themNV = new SqlCommand(@themKH_query, conn);
            command_themNV.Parameters.AddWithValue("@TenNV", TenNV);
            command_themNV.Parameters.AddWithValue("@SoDienThoai", SoDienThoai);
            command_themNV.Parameters.AddWithValue("@Email", Email);
            command_themNV.Parameters.AddWithValue("@GioiTinh", GioiTinh);
            command_themNV.Parameters.AddWithValue("@HinhAnh",HinhAnh);
            command_themNV.Parameters.AddWithValue("@NgaySinh", NgaySinh);
            int MaNV = Convert.ToInt32(command_themNV.ExecuteScalar());

            string themAdmin_query = "INSERT INTO AccountAdmin (MaNV,Ten_TK, Pass) VALUES (@MaNV,@Ten_TK, @Pass)";
            SqlCommand command_themAdmin = new SqlCommand(themAdmin_query, conn);
            command_themAdmin.Parameters.AddWithValue("@MaNV", MaNV);
            command_themAdmin.Parameters.AddWithValue("@Ten_TK", Ten_TK);
            command_themAdmin.Parameters.AddWithValue("@Pass", Pass);
            command_themAdmin.ExecuteNonQuery();
            conn.Close();
            dsthemNV = GetDSNV();
        }
        return dsthemNV;
    }
    [WebMethod]
    public List<DSNV> GetXoaNV(int MaNV)
    {
        List<DSNV> dsXoaNV = new List<DSNV>();
        using (conn)
        {
            conn.Open();
            string xoaAccountNVQuery = "DELETE FROM AccountAdmin WHERE MaNV = @MaNV";
            SqlCommand xoaAccountNVCommand = new SqlCommand(xoaAccountNVQuery, conn);
            xoaAccountNVCommand.Parameters.AddWithValue("@MaNV", MaNV);
            xoaAccountNVCommand.ExecuteNonQuery();

            string xoaNVQuery = "DELETE FROM NhanVien WHERE MaNV = @MaNV";
            SqlCommand xoaNVCommand = new SqlCommand(xoaNVQuery, conn);
            xoaNVCommand.Parameters.AddWithValue("@MaNV", MaNV);
            xoaNVCommand.ExecuteNonQuery();
            conn.Close();
        }
        return dsXoaNV;

    }
    [WebMethod]
    public List<DSNV> GetSuaNV(int MaNV, string TenNV, string SoDienThoai, string Ten_TK, string Pass, string Email, string GioiTinh, string HinhAnh, DateTime NgaySinh)
    {
        List<DSNV> dsSuaNV = new List<DSNV>();
        using (conn)
        {
            conn.Open();
            string suaNV_query = "Update NhanVien Set TenNV = @TenNV , SoDienThoai = @SoDienThoai, Email = @Email , GioiTinh = @GioiTinh,HinhAnh = @HinhAnh ,NgaySinh = @NgaySinh Where MaNV = @MaNV";
            SqlCommand commandSuaNV = new SqlCommand(suaNV_query, conn);
            commandSuaNV.Parameters.AddWithValue("@MaNV", MaNV);
            commandSuaNV.Parameters.AddWithValue("@TenNV", TenNV);
            commandSuaNV.Parameters.AddWithValue("@SoDienThoai", SoDienThoai);
            commandSuaNV.Parameters.AddWithValue("@NgaySinh", NgaySinh);
            commandSuaNV.Parameters.AddWithValue("@Email", Email);
            commandSuaNV.Parameters.AddWithValue("@HinhAnh",  HinhAnh);
            commandSuaNV.Parameters.AddWithValue("@GioiTinh", GioiTinh);
            commandSuaNV.ExecuteNonQuery();

            string SuaAdmin_query = "Update AccountAdmin Set Ten_TK = @Ten_TK , Pass = @Pass Where MaNV = @MaNV";
            SqlCommand command_SuaAdmin = new SqlCommand(SuaAdmin_query, conn);
            command_SuaAdmin.Parameters.AddWithValue("@MaNV", MaNV);
            command_SuaAdmin.Parameters.AddWithValue("@Ten_TK", Ten_TK);
            command_SuaAdmin.Parameters.AddWithValue("@Pass", Pass);
            command_SuaAdmin.ExecuteNonQuery();
            conn.Close();
        }
        return dsSuaNV;
    }
    [WebMethod]
    public List<DSNV> GetTimKiemNV(string TenNV)
    {
        List<DSNV> dsTimKiemNV = new List<DSNV>();
        using (conn)
        {
            string timkiemNV_query = "select * , AccountAdmin.Ten_TK,AccountAdmin.Pass from NhanVien Inner Join AccountAdmin On NhanVien.MaNV = AccountAdmin.MaNV Where TenNV Like '%' + @TenNV +'%';";
            SqlCommand command_TKNV = new SqlCommand(timkiemNV_query, conn);
            command_TKNV.Parameters.AddWithValue("@TenNV", TenNV);
            conn.Open();
            using (SqlDataReader reader = command_TKNV.ExecuteReader())
            {
                while (reader.Read())
                {
                    DSNV dsNV = new DSNV();
                    dsNV.MaNV = Convert.ToInt32(reader["MaNV"]);
                    dsNV.TenNV = reader["TenNV"].ToString();
                    dsNV.Ten_TK = reader["Ten_TK"].ToString();
                    dsNV.Pass = reader["Pass"].ToString();
                    dsNV.SoDienThoai = reader["SoDienThoai"].ToString();
                    dsNV.NgaySinh = (DateTime)reader["NgaySinh"];
                    dsNV.Email = reader["Email"].ToString();
                    dsNV.HinhAnh = reader["HinhAnh"].ToString();
                    dsNV.GioiTinh = reader["GioiTinh"].ToString();
                    dsTimKiemNV.Add(dsNV);
                }
            }
            conn.Close();
        }
        return dsTimKiemNV;
    }


    //Phan SP
    [WebMethod]
    public List<DSSP> GetDSSP()
    {
        List<DSSP> DanhSachSP = new List<DSSP>();

    
            if(conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            string query_DSSP = "Select * From SanPham Join LoaiSP On SanPham.LoaiSP = LoaiSP.MaLoaiSP ";
            SqlCommand command_XuatSP = new SqlCommand(query_DSSP, conn);
        using (SqlDataReader readerDSSP = command_XuatSP.ExecuteReader())
        {
            while (readerDSSP.Read())
            {
                DSSP dsSP = new DSSP();
                dsSP.MaSP = Convert.ToInt32(readerDSSP["MaSP"]);
                dsSP.TenSP = readerDSSP["TenSP"].ToString();
                dsSP.MoTa = readerDSSP["MoTa"].ToString();
                dsSP.Gia = readerDSSP["Gia"].ToString();
                dsSP.LoaiSP = readerDSSP["LoaiSP"].ToString();
                dsSP.TenLoaiSP = readerDSSP["TenLoaiSP"].ToString();
                dsSP.HinhAnh = readerDSSP["HinhAnh"].ToString();

                DanhSachSP.Add(dsSP);
            }
        }
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
        

        return DanhSachSP;

    }
    [WebMethod]
    public List<DSSP> GetThemSP(string TenSP, string MoTa,string HinhAnh, string Gia, string LoaiSP)
    {
        List<DSSP> dsthemSP = new List<DSSP>();
        using (conn)
        {
            conn.Open();
            string themSP_query = "Insert into SanPham (TenSP,MoTa,HinhAnh,Gia,LoaiSP) Values(@TenSP,@MoTa,@HinhAnh,@Gia,@LoaiSP)";
            SqlCommand command_themSP = new SqlCommand(themSP_query, conn);

            command_themSP.Parameters.AddWithValue("@TenSP", TenSP);
            command_themSP.Parameters.AddWithValue("@MoTa", MoTa);
            command_themSP.Parameters.AddWithValue("@Gia", Gia);
            command_themSP.Parameters.AddWithValue("@LoaiSP", LoaiSP);
            command_themSP.Parameters.AddWithValue("@HinhAnh",HinhAnh);


            command_themSP.ExecuteNonQuery();

            conn.Close();
        }
        return dsthemSP;
    }
    [WebMethod]
    public List<DSSP> GetXoaSP(int MaSP)
    {
        List<DSSP> dsXoaNV = new List<DSSP>();
        using (conn)
        {
            conn.Open();
            string xoaSPQuery = "DELETE FROM SanPham WHERE MaSP = @MaSP";
            SqlCommand xoaSPCommand = new SqlCommand(xoaSPQuery, conn);
            xoaSPCommand.Parameters.AddWithValue("@MaSP", MaSP);
            xoaSPCommand.ExecuteNonQuery();
            conn.Close();
        }
        return dsXoaNV;

    }
    [WebMethod]
    public List<DSSP> GetSuaSP(int MaSP, string TenSP, string Mota, string HinhAnh, string Gia, string LoaiSP)
    {
        List<DSSP> dsSuaSP = new List<DSSP>();
        using (conn)
        {
            conn.Open();
            string suaSP_query = "Update SanPHam Set TenSP = @TenSP , Mota = @Mota, HinhAnh = @HinhAnh , Gia = @Gia,LoaiSP = @LoaiSP Where MaSP = @MaSP";
            SqlCommand commandSuaSP = new SqlCommand(suaSP_query, conn);
            commandSuaSP.Parameters.AddWithValue("@MaSP", MaSP);
            commandSuaSP.Parameters.AddWithValue("@TenSP", TenSP);
            commandSuaSP.Parameters.AddWithValue("@Mota", Mota);
            commandSuaSP.Parameters.AddWithValue("@HinhAnh", HinhAnh);
            commandSuaSP.Parameters.AddWithValue("@Gia", Gia);
            commandSuaSP.Parameters.AddWithValue("@LoaiSP", LoaiSP);
            commandSuaSP.ExecuteNonQuery();

        }
        return dsSuaSP;
    }
    [WebMethod]
    public List<DSSP> GetTimKiemSP(string TenSP)
    {
        List<DSSP> dsTimKiemSP = new List<DSSP>();
        using (conn)
        {
            string timkiemSP_query = "select * , LoaiSP.TenLoaiSP,LoaiSP.MaLoaiSP from SanPham Inner Join LoaiSP On SanPham.LoaiSP = LoaiSP.MaLoaiSP Where TenSP Like '%' + @TenSP +'%';";
            SqlCommand command_TKSP = new SqlCommand(timkiemSP_query, conn);
            command_TKSP.Parameters.AddWithValue("@TenSP", TenSP);
            conn.Open();
            using (SqlDataReader reader = command_TKSP.ExecuteReader())
            {
                while (reader.Read())
                {
                    DSSP dsSP = new DSSP();
                    dsSP.MaSP = Convert.ToInt32(reader["MaSP"]);
                    dsSP.TenSP = reader["TenSP"].ToString();
                    dsSP.MoTa = reader["MoTa"].ToString();
                    dsSP.HinhAnh = reader["HinhAnh"].ToString();
                    dsSP.Gia = reader["Gia"].ToString();
                    dsSP.LoaiSP = reader["LoaiSP"].ToString();
                    dsTimKiemSP.Add(dsSP);
                }
            }
            conn.Close();
        }
        return dsTimKiemSP;
    }
    
    
    //Home
    [WebMethod]
    public List<DSBAN> GetDSBAN()
    {
        List<DSBAN> DanhSachBan = new List<DSBAN>();

        using (conn)
        {
            conn.Open();
            string query_DSBan = "Select * From SanPham Join LoaiSP On SanPham.LoaiSP = LoaiSP.MaLoaiSP ";
            SqlCommand command_XuatSPBan = new SqlCommand(query_DSBan, conn);
            using (SqlDataReader readerDSBan = command_XuatSPBan.ExecuteReader())
            {
                while (readerDSBan.Read())
                {
                    DSBAN dsBan = new DSBAN();
                    dsBan.MaSP = Convert.ToInt32(readerDSBan["MaSP"]);
                    dsBan.TenSP = readerDSBan["TenSP"].ToString();
                    dsBan.MoTa = readerDSBan["MoTa"].ToString();
                    dsBan.Gia = readerDSBan["Gia"].ToString();
                    dsBan.LoaiSP = readerDSBan["LoaiSP"].ToString();
                    dsBan.HinhAnh = readerDSBan["HinhAnh"].ToString();
                    dsBan.TenLoaiSP = readerDSBan["TenLoaiSP"].ToString();
                    dsBan.MaLoaiSP = readerDSBan["MaLoaiSP"].ToString();
                    DanhSachBan.Add(dsBan);
                }
            }
            conn.Close();
        }
        return DanhSachBan;

    }
     
    [WebMethod]
    public List<DSBAN> GetTimKiemSPBan(string TenSP)
    {
        List<DSBAN> dsTimKiemSPBan = new List<DSBAN>();
        using (conn)
        {
            string timkiemSPBan_query = "select * , LoaiSP.TenLoaiSP,LoaiSP.MaLoaiSP from SanPham Inner Join LoaiSP On SanPham.LoaiSP = LoaiSP.MaLoaiSP Where TenSP Like '%' + @TenSP +'%';";
            SqlCommand command_TKSPBan = new SqlCommand(timkiemSPBan_query, conn);
            command_TKSPBan.Parameters.AddWithValue("@TenSP", TenSP);
            conn.Open();
            using (SqlDataReader reader = command_TKSPBan.ExecuteReader())
            {
                while (reader.Read())
                {
                    DSBAN dsSPBan = new DSBAN();
                    dsSPBan.MaSP = Convert.ToInt32(reader["MaSP"]);
                    dsSPBan.TenSP = reader["TenSP"].ToString();
                    dsSPBan.MoTa = reader["MoTa"].ToString();
                    dsSPBan.HinhAnh = reader["HinhAnh"].ToString();
                    dsSPBan.Gia = reader["Gia"].ToString();
                    dsSPBan.LoaiSP = reader["LoaiSP"].ToString();
                    dsSPBan.TenLoaiSP = reader["TenLoaiSP"].ToString();
                    dsSPBan.MaLoaiSP = reader["MaLoaiSP"].ToString();
                    dsTimKiemSPBan.Add(dsSPBan);
                }
            }
            conn.Close();
        }
        return dsTimKiemSPBan;
    }


    // cbo
    [WebMethod]
    public List<Cbo> GetLoaiSPCBO() {
         List<Cbo> ret = new List<Cbo>();
        using (conn)
        {
            conn.Open();
            string query_DSBan = "Select * From LoaiSP";
            SqlCommand command_XuatSPBan = new SqlCommand(query_DSBan, conn);
            using (SqlDataReader readerDSBan = command_XuatSPBan.ExecuteReader())
            {
                while (readerDSBan.Read())
                {
                    Cbo dsspcb = new Cbo();
                    dsspcb.MaLoaiSP = readerDSBan["MaLoaiSP"].ToString();
                    dsspcb.TenLoaiSP = readerDSBan["TenLoaiSP"].ToString();
                    ret.Add(dsspcb);
                }
            }
            conn.Close();
        }
        return ret;
    }



    //Danh gia
    [WebMethod]
    public List<DanhGia> GetDanhGia() {
        List<DanhGia> DanhSachDG = new List<DanhGia>();


        using (conn)
        {
            conn.Open();
            string query_DSSP = "Select *,SanPham.HinhAnh From DanhGia Join SanPham On SanPham.MaSP = DanhGia.MaSP ";
        SqlCommand command_XuatSP = new SqlCommand(query_DSSP, conn);
        using (SqlDataReader readerDSSP = command_XuatSP.ExecuteReader())
        {
            while (readerDSSP.Read())
            {
                DanhGia dsDG = new DanhGia();
                dsDG.MaSP = Convert.ToInt32(readerDSSP["MaSP"]);
                dsDG.TenNguoiDG = readerDSSP["TenNguoiDG"].ToString();
                dsDG.DanhGiaSP = readerDSSP["DanhGiaSP"].ToString();
                dsDG.TenSP = readerDSSP["TenSP"].ToString();
                dsDG.Gia = readerDSSP["Gia"].ToString();
                    dsDG.HinhAnh = readerDSSP["HinhAnh"].ToString();
                    DanhSachDG.Add(dsDG);
            }
        }

        }
        conn.Close();

        return DanhSachDG;
    }

    [WebMethod]
    public List<DanhGia> GetThemDG(int MaSP,string TenNguoiDG,string DanhGiaSP)
    {
        List<DanhGia> ThemDG = new List<DanhGia>();
        using (conn) {
            conn.Open();
            string themDG_query = "Insert into DanhGia(MaSP,TenNguoiDG,DanhGiaSP) Values (@MaSP,@TenNguoiDG,@DanhGiaSP)";
            SqlCommand cm_ThemDG = new SqlCommand(themDG_query, conn);
            cm_ThemDG.Parameters.AddWithValue("@TenNguoiDG", TenNguoiDG);
            cm_ThemDG.Parameters.AddWithValue("@DanhGiaSP", TenNguoiDG);
            cm_ThemDG.Parameters.AddWithValue("@MaSP", MaSP);
            cm_ThemDG.ExecuteNonQuery();

            conn.Close();
        }
        
            return ThemDG;
    }
    [WebMethod]
    public List<MuaHang> GetMua(DateTime NgayDat, string TongTien,int Soluong,string MaKH,int MaSP)
    {
        List<MuaHang> mua = new List<MuaHang>();

        using (conn)
        {
            conn.Open();
            string query_mua = "Insert into HoaDon(NgayDat,TongTien,Soluong,MaKH,MaSP) Values (@NgayDat,@TongTien,@Soluong,@MaKH,@MaSP)";
            SqlCommand command_Mua = new SqlCommand(query_mua, conn);
            command_Mua.Parameters.AddWithValue("@NgayDat",NgayDat);
            command_Mua.Parameters.AddWithValue("@TongTien",TongTien);
            command_Mua.Parameters.AddWithValue("@Soluong",Soluong);
            command_Mua.Parameters.AddWithValue("@MaKH",MaKH);
            command_Mua.Parameters.AddWithValue("@MaSP",MaSP);
            command_Mua.ExecuteNonQuery();
            conn.Close();
        }

        return mua;
        }

    
}


