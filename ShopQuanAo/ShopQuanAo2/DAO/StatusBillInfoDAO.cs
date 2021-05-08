using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ShopQuanAo2.DTO;
namespace ShopQuanAo2.DAO
{
    public class StatusBillInfoDAO : System.Collections.CollectionBase
    {
        public StatusBillInfo this[int index]
        {
            get { return (StatusBillInfo)(List[index]); }
            set { List[index] = value; }
        }

        public int Add(StatusBillInfo value)
        {
            return List.Add(value);
        }
    }
}
