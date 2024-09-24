using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите первое число:");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Введите второе число:");
        double num2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Выберите операцию:");
        Console.WriteLine("1. Сложение");
        Console.WriteLine("2. Вычитание");
        Console.WriteLine("3. Умножение");
        Console.WriteLine("4. Деление");

        int choice = Convert.ToInt32(Console.ReadLine());
        double result = 0;

        switch (choice)
        {
            case 1:
                result = num1 + num2;
                Console.WriteLine($"Результат сложения: {result}");
                break;
            case 2:
                result = num1 - num2;
                Console.WriteLine($"Результат вычитания: {result}");
                break;
            case 3:
                result = num1 * num2;
                Console.WriteLine($"Результат умножения: {result}");
                break;
            case 4:
                if (num2 != 0)
                {
                    result = num1 / num2;
                    Console.WriteLine($"Результат деления: {result}");
                }
                else
                {
                    Console.WriteLine("Ошибка: Деление на ноль невозможно.");
                }
                break;
            default:
                Console.WriteLine("Неверный выбор операции.");
                break;
        }
    }
}
