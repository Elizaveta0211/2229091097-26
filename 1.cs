using System;

class Program
{
    static void Main()
    {
        Random random = new Random(); // Создает генератор случайных чисел
        int secretNumber = random.Next(1, 101); // Число от 1 до 100

        Console.WriteLine($"Я загадал число от 1 до 100. Попробуй угадать!");
        Console.ReadLine();
        Console.WriteLine($"А нет, я его тебе сразу скажу: {secretNumber}!");
        Console.ReadLine();
    }
}