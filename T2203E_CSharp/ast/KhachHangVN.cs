using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2203E_CSharp.bt
{
    internal class KhachHangVN : KhachHang
    {
        public string doiTuong { get; set; }
        public KhachHangVN(int Code, string FullName, string Date, int Quantity, string DoiTuong) : base(Code, FullName, Date, Quantity)
        {
            doiTuong= DoiTuong;
        }

        public  int Thanhtien()
        {
           if(quantity < 50)
            {
                return quantity * 1000;
            }else if(quantity < 100)
            {
                return (quantity - 50) * 1200 + 50 * 1000;
            }else if(quantity < 200)
            {
                return (quantity - 100) * 1500 + 50*1200 + 50*1000 ;
            }else
            {
                return (quantity - 200) * 2000 + 100 * 1500 + 50 * 1200 + 50 * 1000;
            }
        }
    }
}
