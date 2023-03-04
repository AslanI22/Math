// See https://aka.ms/new-console-template for more information
namespace Kalkulator
{
    class Bazar
    {
        static void Main(string[] args)
        {
            Console.Write("Введите первое число: ");
            double x = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите дейсвие: ");
            char z = Convert.ToChar(Console.ReadLine());

            if ((z != '+') && (z != '-') && (z != '*') && (z != '/'))
            {
                Console.Write("Неправильно введено действие.");
                return;
            }
            Console.Write("Введите второе число: ");
            double y = Convert.ToInt32(Console.ReadLine());

            switch (z)
            {
                case '+':
                    Console.WriteLine($"Результат: {x} + {y} = " + (x + y));
                    break;
                case '-':
                    Console.WriteLine($"Результат: {x} - {y} = " + (x - y));
                    break;
                case '*':
                    Console.WriteLine($"Результат: {x} * {y} = " + (x * y));
                    break;
                case '/':
                    if ((z == '/') && (y == 0))
                    {
                        Console.WriteLine("Ошибка, на ноль делить нельзя.");
                        return;
                    }
                    Console.WriteLine($"Результат: {x} / {y} = " + (x / y));
                    break;

            }
        }
    }
}

