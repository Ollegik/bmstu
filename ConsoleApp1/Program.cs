using System;

namespace ConsoleApp1
{
    class Program
    {
        static int Main(string[] args)
        {
            Console.Title="Козинов Олег, ИУ5-35Б";
            string first;double a,b,c;
            first = Console.ReadLine();
            bool result = double.TryParse(first, out a);
            while (result != true)
            {
                Console.WriteLine("Ошибка, попробуйте еще раз");
                first = Console.ReadLine();
                result = double.TryParse(first, out a);
            }
            first = Console.ReadLine();
            result = double.TryParse(first, out b);
            while (result != true)
            {
                Console.WriteLine("Ошибка, попробуйте еще раз");
                first = Console.ReadLine();
                result = double.TryParse(first, out b);
            }
            first = Console.ReadLine();
            result = double.TryParse(first, out c);
            while (result != true)
            {
                Console.WriteLine("Ошибка, попробуйте еще раз");
                first = Console.ReadLine();
                result = double.TryParse(first, out c);
            }

            double discrim=Math.Pow(b,2)-4*a*c;
            if (discrim < 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Корней нет");
                Console.ResetColor();
                return 0;
            }
            if (discrim > 0)
            {
                double q1, q2;
                double x1 = Math.Sqrt((-b + Math.Sqrt(discrim)) / (2 * a));
                double x2 = -Math.Sqrt((-b + Math.Sqrt(discrim)) / (2 * a));
                double x3 = -Math.Sqrt((-b - Math.Sqrt(discrim)) / (2 * a));
                double x4 = Math.Sqrt((-b - Math.Sqrt(discrim)) / (2 * a));
                Console.WriteLine("Корни уравнения:");
                if ((x1 == 0) || (x2 == 0) || (x3 == 0) || (x4 == 0))
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("0");
                    Console.ResetColor();
                }
                double[] mass = new double[4] { x1, x2, x3, x4 };
                for (int i = 0; i < 3; i++)
                {
                    if (mass[i] > 0)
                    {
                        q1 = Math.Sqrt(mass[i]);
                        q2 = -Math.Sqrt(mass[i]);
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write("{0} {1} ", q1, q2);
                        Console.ResetColor();
                    }


                }

                return 0;
            }
            if (discrim==0)
            {
                double x1, q1, q2;
                x1 = (-b) / (2 * a);
                if (x1 > 0)
                {
                    q1 = Math.Sqrt(x1);
                    q2 = -Math.Sqrt(x1);
                    Console.WriteLine("Корни уравнения:");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("{0} {1} ", q1, q2);
                    Console.ResetColor();
                    return 0;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Корней нет");
                    Console.ResetColor();
                    return 0;
                }
            }
            return 0;
        }
        
    }
}
