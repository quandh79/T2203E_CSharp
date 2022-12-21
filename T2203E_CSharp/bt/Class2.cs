public class Fraction
{
    // Thuộc tính: Tử số và mẫu số
    private int numerator;
    private int denominator;

    // Properties cho Tử số và Mẫu số
    public int Numerator
    {
        get { return numerator; }
        set { numerator = value; }
    }

    public int Denominator
    {
        get { return denominator; }
        set { denominator = value; }
    }

    // Phương thức nhập phân số
    public void Input()
    {
        Console.Write("Nhap tu so: ");
        numerator = int.Parse(Console.ReadLine());
        Console.Write("Nhap mau so: ");
        denominator = int.Parse(Console.ReadLine());
    }

    // Phương thức in phân số
    public void Print()
    {
        Console.WriteLine("{0}/{1}", numerator, denominator);
    }

    // Phương thức rút gọn phân số
    public void Simplify()
    {
        int gcd = GCD(numerator, denominator);
        numerator /= gcd;
        denominator /= gcd;
    }

    // Phương thức tìm ước chung lớn nhất
    private int GCD(int a, int b)
    {
        if (b == 0)
        {
            return a;
        }
        return GCD(b, a % b);
    }

    // Phương thức nghịch đảo phân số
    public void Invert()
    {
        int temp = numerator;
        numerator = denominator;
        denominator = temp;
    }

    // Phương thức cộng hai phân số
    public Fraction Add(Fraction f)
    {
        Fraction result = new Fraction();
        result.numerator = numerator * f.denominator + f.numerator * denominator;
        result.denominator = denominator * f.denominator;
        result.Simplify();
        return result;
    }

    // Phương thức trừ hai phân số
    public Fraction Sub(Fraction f)
    {
        Fraction result = new Fraction();
        result.numerator = numerator * f.denominator - f
