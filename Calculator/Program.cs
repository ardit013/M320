namespace Calculator
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int a = 12;
            int b = 18;
            int ggt = MyMath.calc_ggt(a, b);
            Console.WriteLine($"Calc_ggt({a}, {b}) = {ggt}");
            Console.WriteLine($"Calc_kgv({a}, {b}) = {MyMath.calc_kgv(a, b)}");
        }
    }
}
