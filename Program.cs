namespace Решение_квадратного_уравнения
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Решение квадратного уравнения");
            Console.WriteLine("Ax^2+Bx+C=0");
            Console.Write("Введите значение A: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите значение B: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите значение C: ");
            int c = Convert.ToInt32(Console.ReadLine());
            int d = b * b - 4 * a * c;
            Console.Write("Дискрименант квадратного уравнения D=");
            Console.WriteLine(d);
            double f1 = Math.Sqrt(d);


            if (d > 0)
            {
                double X1 = (-b - f1) / 2 * a;
                double X2 = (-b + f1) / 2 * a;
                Console.Write("X1 = ");
                Console.WriteLine(X1);
                Console.Write("X2 = ");
                Console.WriteLine(X2);
            }
            else if (d == 0)
            {
                double X1 = (-b - f1) / 2 * a;
                Console.Write("X1 = ");
                Console.WriteLine(X1);

            }
            else
            {
                Console.WriteLine("Корней нет");
            }
        }
    }
}
