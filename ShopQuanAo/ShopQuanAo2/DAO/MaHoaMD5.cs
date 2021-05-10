using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;
namespace ShopQuanAo2.DAO
{
    public static class MaHoaMD5
    {
        public static string MD5Hash(string text)
        {

            MD5 md5 = new MD5CryptoServiceProvider();

            //Hash theo mã máy tính
            md5.ComputeHash(ASCIIEncoding.ASCII.GetBytes(text));
            // lấy ra mảng kiểu byte từ 1 cái chuỗi
            
            byte[] result = md5.Hash;// bảng băm 
            // mảng kết quả sau khi mã hóa nó
            StringBuilder strBuilder = new StringBuilder();
            for (int i = 0; i < result.Length; i++)
            {     
                strBuilder.Append(result[i].ToString("x2"));
            }

            return strBuilder.ToString();
        }  
    }
}
