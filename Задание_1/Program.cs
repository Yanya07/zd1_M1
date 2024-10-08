using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Задание_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int secretNumber = random.Next(1, 101); // Случайное число от 1 до 100 включительно
            Console.WriteLine("Угадай число от 1 до 100.");
            while (true)
            {
                Console.Write("Введите ваше число: ");
                string input = Console.ReadLine();
                if (!int.TryParse(input, out int userGuess))// Проверка, является ли ввод корректным числом
                {
                    Console.WriteLine("Пожалуйста, введите корректное число.");
                    continue;
                }
                if (userGuess == secretNumber)// Проверка, угадал ли пользователь
                {
                    Console.WriteLine($"Поздравляю! Вы угадали число {secretNumber}.");
                    break;
                }
                else if (userGuess > secretNumber)
                {
                    Console.WriteLine("Ваше число больше загаданного.");
                }
                else
                {
                    Console.WriteLine("Ваше число меньше загаданного.");
                }
            }
            Console.WriteLine("Нажмите Enter, чтобы закрыть программу.");
            Console.ReadLine();
        }
    }
}
