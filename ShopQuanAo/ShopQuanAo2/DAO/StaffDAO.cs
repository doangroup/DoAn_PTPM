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
        public bool addStaff(int maNV, string tenNV, string gioiTinh, string diaChi, int sDT, string ngaySinh,string tenDN,int loaiTK)
        {
            string sqlAdd = "insert into NhanVien values (" + maNV + ",N'" + tenNV + "',N'" + gioiTinh + "',N'" + diaChi + "','" + sDT + "'," + ngaySinh + ",'"+tenDN+"','c4ca4238a0b923820dcc509a6f75849b',"+loaiTK+")";
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
        public bool addStaff2(int maNV, string tenNV, string gioiTinh, string diaChi, int sDT, string ngaySinh, string tenDN,string matKhau, int loaiTK)
        {
            string sqlAdd = "insert into NhanVien values (" + maNV + ",N'" + tenNV + "',N'" + gioiTinh + "',N'" + diaChi + "','" + sDT + "'," + ngaySinh + ",'" + tenDN + "','" + matKhau + "'," + loaiTK + ")";
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
            string sqlAdd = "update NhanVien set TenNV = N'" + tenNV + "', GioiTinh = N'" + gioiTinh + "',DiaChi =N'" + diaChi + "', SDT = '" + sDT + "',NgaySinh = " + ngaySinh + ", LoaiTK = " + loaiTK + " where MaNV = " + maNV;
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
        public bool checkPrimarykey(int maNV)
        {
            string sqlCheck = "select * from NhanVien where MaNV = " + maNV;
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
    }

}
