using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите несколько чисел через пробел:");
        string input = Console.ReadLine();

        string[] numbers = input.Split(' ');
        int sum = 0;

        foreach (string number in numbers)
        {
            if (int.TryParse(number, out int num))
            {
                sum += num;
            }
            else
            {
                Console.WriteLine($"Некорректный ввод: '{number}' не является числом.");
                return;
            }
        }

        Console.WriteLine($"Сумма введенных чисел: {sum}");

        Console.ReadLine(); // Чтобы консольное окно не закрылось сразу после выполнения программы

        Console.WriteLine("Введите ваше имя и фамилию:");
        string fullName = Console.ReadLine();

        Console.WriteLine($"Приветствую тебя - {fullName}");

        Console.ReadLine(); // Чтобы консольное окно не закрылось сразу после выполнения программы
    }
}

