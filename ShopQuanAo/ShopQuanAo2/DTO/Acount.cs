using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace ShopQuanAo2.DTO
{
    public class Acount
    {
        string userName, passWord;
        int type;
        public Acount()
        {

        }
        //public Acount(string user,string pass,int _type)
        //{
        //    this.UserName = user;
        //    this.PassWord = pass;
        //    this.Type = _type;
        //}
        public Acount(string user, int _type, string pass = null)
        {
            this.UserName = user;
            this.PassWord = pass;
            this.Type = _type;
        }
        public Acount(DataRow row)
        {
            this.UserName = row[0].ToString();
            this.PassWord = row[1].ToString();
            this.Type = (int)row[2];
        }
        public int Type
        {
            get { return type; }
            set { type = value; }
        }

        public string UserName
        {
            get { return userName; }
            set { userName = value; }
        }

        public string PassWord
        {
            get { return passWord; }
            set { passWord = value; }
        }
    }
}
