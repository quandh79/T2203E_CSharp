using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace house.cm
{
    public  class House : IHouse
    {
        private string soNha;
        private string diaChi;
        private string loaiNha;
        public House()
        {
        }
        public House(string soNha, string diaChi, string loaiNha)
        {
            this.soNha = soNha;
            this.diaChi = diaChi;
            this.loaiNha = loaiNha;
        }

        public string SoNha
        {
            get { return soNha; }
            set { soNha = value; }
        }

        
        public string DiaChi
        {
            get { return diaChi; }
            set { diaChi = value; }
        }

       
        public string LoaiNha
        {
            get { return loaiNha; }
            set { loaiNha = value; }
        }

        public virtual void input()
        {
            Console.Write("Số nhà: ");
            soNha = Console.ReadLine();
            Console.Write("Địa chỉ: ");
            diaChi = Console.ReadLine();
            Console.Write("Loại nhà: ");
            loaiNha = Console.ReadLine();
        }

        public virtual void display()
        {
            Console.WriteLine("Số nhà: " + this.soNha);
            Console.WriteLine("Địa chỉ: " + this.diaChi);
            Console.WriteLine("Loại nhà: " + this.loaiNha);
        }

        
    }
        
}
