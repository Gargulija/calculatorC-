using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppKDA
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите выражение: ");
            string vir = Convert.ToString(Console.ReadLine());
            try
            {

                var calc = vir.Split(' ');

                double num1 = Convert.ToDouble(calc[0]);
                double num2 = Convert.ToDouble(calc[2]);

                switch (calc[1])
                {
                    case "+":
                        Console.Clear();
                        Console.WriteLine($"Результат: {num1 + num2}");
                        break;
                    case "-":
                        Console.Clear();
                        Console.WriteLine($"Результат: {num1 - num2}");
                        break;
                    case "/":
                        Console.Clear();
                        Console.WriteLine($"Результат: {num1 / num2}");
                        break;
                    case "*":
                        Console.Clear();
                        Console.WriteLine($"Результат: {num1 * num2}");
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Нужен знак");
                        Console.ReadKey();
                        return;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();
        }
    }
}
