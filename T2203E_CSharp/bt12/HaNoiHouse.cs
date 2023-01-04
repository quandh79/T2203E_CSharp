using house.cm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using house.cm;

namespace house.hanoi
{
    public class HaNoiHouse : House
    {
        private String tenQuan;

        public HaNoiHouse() { }
        public HaNoiHouse(string soNha, string diaChi, string loaiNha, string tenQuan) : base(soNha, diaChi, loaiNha)
        {
            this.tenQuan = tenQuan;
        }
        public string TenQuan
        {
            get { return tenQuan; }
            set { tenQuan = value; }
        }
        public override void input()
        {
            base.input();
            Console.WriteLine("Nhập tên quận: ");
            this.tenQuan = Console.ReadLine();


        }
        public override void display()
        {
            base.display();
            Console.WriteLine("Tên quận: " + this.tenQuan);
        }
    }
}
