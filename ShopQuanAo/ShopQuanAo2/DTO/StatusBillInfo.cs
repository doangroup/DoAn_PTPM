using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShopQuanAo2.DTO
{
   public class StatusBillInfo
    {
        private int id;
       public StatusBillInfo(int id, string name)
        {
            this.id = Id;
            this.name = Name;
        }
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
       private string name;

       public string Name
       {
           get { return name; }
           set { name = value; }
       }
    }
}
