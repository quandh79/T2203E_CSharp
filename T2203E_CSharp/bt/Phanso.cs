using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2203E_CSharp.bt
{
    internal class Phanso
    {
        public int tuso;
        public int mauso;

        public int Tuso
        {
            get { return tuso; }
            set { this.tuso = value; }
        }
        public int Mauso
        {
            get { return mauso; }
            set { this.mauso = value; }
        }

        public void Print()
        {

            Console.WriteLine($"{tuso}/{mauso}");
        }

        public void Simplify()
        {
            int gcd = GCD(tuso, mauso);
            tuso /= gcd;
            mauso /= gcd;
        }
        private int GCD(int a, int b)
        {
            if (b == 0)
                return a;
            return GCD(b, a % b);
        }
        public void Invert()
        {
            int temp = tuso;
            tuso = mauso;
            mauso = temp;
        }

        public static Phanso Add(Phanso f1, Phanso f2)
        {
            int newNumerator = f1.tuso * f2.mauso + f1.mauso * f2.tuso;
            int newDenominator = f1.mauso * f2.mauso;
            Phanso result = new Phanso { tuso = newNumerator, mauso = newDenominator };
            result.Simplify();
            return result;
        }
        public static Phanso Subtract(Phanso f1, Phanso f2)
        {
            int newNumerator = f1.tuso * f2.mauso - f1.mauso * f2.tuso;
            int newDenominator = f1.mauso * f2.mauso;
            Phanso result = new Phanso { tuso = newNumerator, mauso = newDenominator };
            result.Simplify();
            return result;
        }

        public static Phanso Multiply(Phanso f1, Phanso f2)
        {
            int newNumerator = f1.tuso * f2.tuso;
            int newDenominator = f1.mauso * f2.mauso;
            Phanso result = new Phanso { tuso = newNumerator, mauso = newDenominator };
            result.Simplify();
            return result;
        }

        public static Phanso Divide(Phanso f1, Phanso f2)
        {
            int newNumerator = f1.tuso * f2.mauso;
            int newDenominator = f1.mauso * f2.tuso;
            Phanso result = new Phanso { tuso = newNumerator, mauso = newDenominator };
            result.Simplify();
            return result;
        }
    }
}
