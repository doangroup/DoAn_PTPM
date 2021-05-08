﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using ShopQuanAo2.DTO;
namespace ShopQuanAo2.DAO
{
   public class BillInfoDAO
    {
        DataProvider dp = new DataProvider();

        public List<BillInfo> loadBillInfo()
        {
            List<BillInfo> lstBillInfo = new List<BillInfo>();
            string sqlBillInfo = "select * from ChiTietHD";
            DataTable dt = dp.ExcuteQuery(sqlBillInfo);
            foreach (DataRow item in dt.Rows)
            {
                BillInfo billInfo = new BillInfo(item);
                lstBillInfo.Add(billInfo);
            }
            return lstBillInfo;
        }
        public List<BillInfo> findBillInfo(int maHD)
        {
            List<BillInfo> lstBillInfo = new List<BillInfo>();
            string sqlBillInfo = "select * from ChiTietHD where MaHD = " + maHD;
            DataTable dt = dp.ExcuteQuery(sqlBillInfo);
            foreach (DataRow item in dt.Rows)
            {
                BillInfo billInfo = new BillInfo(item);
                lstBillInfo.Add(billInfo);
            }
            return lstBillInfo;
        }
        
        public bool deleteBillInfo(int maHD)
        {

            string sqlDelete = "delete from ChiTietHD where MaHD = " + maHD;
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
        public bool addBillInfo(int maHD, int soLuong, double thanhTien, int tinhTrang)
        {

            string sqlAdd = "insert into ChiTietHD values (" + maHD + "," + soLuong + "," + thanhTien + "," + tinhTrang + ")";
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
        public bool repairBillInfo(int maHD, int soLuong, double thanhTien, int tinhTrang)
        {
            string sqlAdd = "update ChiTietHD set SoLuong = " + soLuong + ",ThanhTien = " + thanhTien + ",TinhTrang = " + tinhTrang + " where MaHD = " + maHD;
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
        public bool checkPrimarykey(int maHD)
        {
            string sqlCheck = "select * from ChiTietHD where MaHD = " + maHD;
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