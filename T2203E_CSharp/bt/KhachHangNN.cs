using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2203E_CSharp.bt
{
    internal class KhachHangNN : KhachHang
    {
        public string quocTich;
        public KhachHangNN(int Code, string FullName, string Date, int Quantity, string quocTich) : base(Code, FullName, Date, Quantity)
        {
            this.quocTich = quocTich;
        }
        public int ThanhTien()
        {
            return quantity * 2000;
        }
    }
}
