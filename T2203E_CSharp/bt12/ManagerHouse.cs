using house.cm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace house.hanoi
{
    internal class ManagerHouse
    {
        private List<House> listHouse;

        public ManagerHouse()
        {
            this.listHouse = new List<House>();
        }

        public void addHouse(House house)
        {
            this.listHouse.Add(house);
        }

        public void inputHouse()
        {
            Console.WriteLine("Nhập số lượng ngôi nhà: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                HaNoiHouse house = new HaNoiHouse();
                house.input();
                this.listHouse.Add(house);
            }
        }

        public void displayHouse()
        {
            Console.WriteLine("Thông tin ngôi nhà: ");
            for (int i = 0; i < this.listHouse.Count; i++)
            {
                Console.WriteLine((i + 1) + ".");
                this.listHouse[i].display();
            }
        }

        public void sortHouse()
        {
            this.listHouse = this.listHouse.OrderBy(house => house.DiaChi).ToList();
        }

        public void searchHouse(string diaChi)
        {
            var result = this.listHouse.Where(house => house.DiaChi == diaChi);
            Console.WriteLine("Kết quả tìm kiếm: ");
            foreach (var house in result)
            {
                house.display();
            }
        }

        public void menu()
        {
            while (true)
            {
                Console.WriteLine("--- Chức năng quản lý ngôi nhà tại Hà Nội ---");
                Console.WriteLine("1. Nhập thông tin n ngôi nhà ở Hà Nội");
                Console.WriteLine("2. Hiển thị thông tin của n ngôi nhà đó");
                Console.WriteLine("3. Sắp xếp theo trường địa chỉ và hiển thị thông tin sau khi sắp xếp");
                Console.WriteLine("4. Tìm kiếm nhà theo địa chỉ nhập vào");
                Console.WriteLine("5. Thoát");
                Console.WriteLine("Chọn chức năng: ");
                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        this.inputHouse();
                        break;
                    case 2:
                        this.displayHouse();
                        break;
                    case 3:
                        this.sortHouse();
                        this.displayHouse();
                        break;
                    case 4:
                        Console.WriteLine("Nhập địa chỉ cần tìm kiếm: ");
                        string diaChi = Console.ReadLine();
                        this.searchHouse(diaChi);
                        break;
                    case 5:
                        return;
                }
            }
        }

    }
}
