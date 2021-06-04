using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ShopQuanAo2.DTO;
using System.Data;
using System.Data.SqlClient;
namespace ShopQuanAo2.DAO
{
    public class StaffDAO
    {
        DataProvider dp = new DataProvider();
        public StaffDAO() { }
        public bool login(string userName, string passWord)
        {

            string sqlAcount = "select TenDN, MatKhau, LoaiTK from NhanVien where TenDN = '" + userName + "' and MatKhau = '" + passWord + "'";
            DataTable dt = dp.ExcuteQuery(sqlAcount);
            if (dt.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public Staff getAcountByUsername(string ten)
        {
            DataTable data = dp.ExcuteQuery("select * from NhanVien where TenDN = '" + ten + "'");
            foreach (DataRow item in data.Rows)
            {
                return new Staff(item);
            }
            return null;
        }
        public List<Staff> loadStaff()
        {
            List<Staff> lstStaff = new List<Staff>();
            string sqlStaff = "select * from NhanVien";
            DataTable dt = dp.ExcuteQuery(sqlStaff);
            foreach (DataRow item in dt.Rows)
            {
                Staff st = new Staff(item);
                lstStaff.Add(st);
            }
            return lstStaff;
        }
        public List<Staff> findStaff(string tenNV)
        {
            List<Staff> lstStaff = new List<Staff>();
            string sqlStaff = "select * from NhanVien where TenNV = N'" + tenNV + "'";
            DataTable dt = dp.ExcuteQuery(sqlStaff);
            foreach (DataRow item in dt.Rows)
            {
                Staff st = new Staff(item);
                lstStaff.Add(st);
            }
            return lstStaff;
        }
        public bool deleteStaff(int maNV)
        {

            string sqlDelete = "delete from NhanVien where MaNV = " + maNV;
            int rs = dp.ExcuteNonQuery(sqlDelete);
            if (rs > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool addStaff(string tenNV, string gioiTinh, string diaChi, int sDT, string ngaySinh,string tenDN,int loaiTK)
        {
            string sqlAdd = "insert into NhanVien values (N'" + tenNV + "',N'" + gioiTinh + "',N'" + diaChi + "','" + sDT + "','" + ngaySinh + "','"+tenDN+"','c4ca4238a0b923820dcc509a6f75849b',"+loaiTK+")";
            int rs = dp.ExcuteNonQuery(sqlAdd);
            if (rs > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool addStaff2(string tenNV, string gioiTinh, string diaChi, int sDT, string ngaySinh, string tenDN,string matKhau, int loaiTK)
        {
            string sqlAdd = "insert into NhanVien values (N'" + tenNV + "',N'" + gioiTinh + "',N'" + diaChi + "','" + sDT + "','" + ngaySinh + "','" + tenDN + "','" + matKhau + "'," + loaiTK + ")";
            int rs = dp.ExcuteNonQuery(sqlAdd);
            if (rs > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool repairStaff(int maNV, string tenNV, string gioiTinh, string diaChi, int sDT, string ngaySinh,int loaiTK)
        {
            string sqlAdd = "update NhanVien set TenNV = N'" + tenNV + "', GioiTinh = N'" + gioiTinh + "',DiaChi =N'" + diaChi + "', SDT = '" + sDT + "',NgaySinh = '" + ngaySinh + "', LoaiTK = " + loaiTK + " where MaNV = " + maNV;
            int rs = dp.ExcuteNonQuery(sqlAdd);
            if (rs > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        
        public bool checkPrimarykey(string tenNV)
        {
            string sqlCheck = "select * from NhanVien where TenNV = N'" + tenNV + "'";
            DataTable rs = dp.ExcuteQuery(sqlCheck);
            if (rs.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool checkPassword(string userName, string passWord)
        {
            string sqlCheck = "select * from NhanVien where TenDN = '" + userName + "' and MatKhau = '" + passWord + "'";
            DataTable rs = dp.ExcuteQuery(sqlCheck);
            if (rs.Rows.Count > 0)
            {
                return true;
                // nếu = true thì đối mật khẩu
            }
            else
            {
                return false;
                //sai mật khẩu cũ
            }
        }
        public bool repairPassAccount(string tenDN, string password)
        {
            string sqlAdd = "update NhanVien set MatKhau = '" + password + "' where TenDN = '" + tenDN + "'";
            int rs = dp.ExcuteNonQuery(sqlAdd);
            if (rs > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }

}
