using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2203E_CSharp.bt
{
    internal abstract class KhachHang
    {
        public int code { get; set; }
        public string fullName { get; set; }
        public string date { get; set; }
        public int quantity { get; set; }
       

        public KhachHang(int Code, string FullName, string Date, int Quantity)
        {
            code= Code;
            fullName= FullName;
            date= Date;
            quantity=Quantity;
        }
        
    }
}
