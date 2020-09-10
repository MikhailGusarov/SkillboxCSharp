﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_Theme_03
{
    class Program
    {
        static void Main(string[] args)
        {
            #region ТЗ
            // Написать игру, в которою могут играть два игрока.
            // При старте, игрокам предлагается ввести свои никнеймы.
            // Никнеймы хранятся до конца игры.
            // Программа загадывает случайное число gameNumber от 12 до 120 сообщая это число игрокам.
            // Игроки ходят по очереди(игра сообщает о ходе текущего игрока)
            // Игрок, ход которого указан вводит число userTry, которое может принимать значения 1, 2, 3 или 4,
            // введенное число вычитается из gameNumber
            // Новое значение gameNumber показывается игрокам на экране.
            // Выигрывает тот игрок, после чьего хода gameNumber обратилась в ноль.
            // Игра поздравляет победителя, предлагая сыграть реванш
            // 
            // * Бонус:
            // Подумать над возможностью реализации разных уровней сложности.
            // В качестве уровней сложности может выступать настраиваемое, в начале игры,
            // значение userTry, изменение диапазона gameNumber, или указание большего количества игроков (3, 4, 5...)

            // *** Сложный бонус
            // Подумать над возможностью реализации однопользовательской игры
            // т е игрок должен играть с компьютером


            // Демонстрация
            // Число: 12,
            // Ход User1: 3
            //
            // Число: 9
            // Ход User2: 4
            //
            // Число: 5
            // Ход User1: 2
            //
            // Число: 3
            // Ход User2: 3
            //
            // User2 победил!
            #endregion

            

            // Получение никнеймов игроков
            Console.Write("Введите никнейм первого игрока: ");
            string user1 = Console.ReadLine();
            Console.Write("Введите никнейм второго игрока: ");
            string user2 = Console.ReadLine();

            // Генерация и вывод случайного числа
            Random rand = new Random();
            int getNumber = rand.Next(12, 121);
            Console.WriteLine($"Число: {getNumber}");

            int userTry;
            string revenge = "";

            while (true)
            {
                // Ход игрока 1
                Console.Write($"{user1} введите число от 1 до 4: ");
                userTry = Convert.ToInt32(Console.ReadLine());

                getNumber -= userTry;

                if (getNumber <= 0)
                {
                    Console.WriteLine($"{user1} победил. Может реванш(да|нет)?");
                    revenge = Console.ReadLine();
                    if (revenge == "да")
                    {
                        getNumber = rand.Next(12, 121);
                        Console.WriteLine($"Число: {getNumber}");
                        revenge = "";
                        continue;
                    }
                    else if (revenge == "нет")
                    {
                        Console.WriteLine("Спасибо за игру!");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Неккорекное значение. Введите да или нет");
                    }
                }

                Console.WriteLine($"Число: {getNumber}");

                // ход игрока 2
                Console.Write($"{user2} введите число от 1 до 4: ");
                userTry = Convert.ToInt32(Console.ReadLine());

                getNumber -= userTry;

                if (getNumber <= 0)
                {
                    Console.WriteLine($"{user2} победил. Может реванш(да|нет)?");
                    revenge = Console.ReadLine();
                    if (revenge == "да")
                    {
                        getNumber = rand.Next(12, 121);
                        Console.WriteLine($"Число: {getNumber}");
                        revenge = "";
                        continue;
                    }
                    else if (revenge == "нет")
                    {
                        Console.WriteLine("Спасибо за игру!");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Неккорекное значение. Введите да или нет");
                    }
                }

                Console.WriteLine($"Число: {getNumber}");
            }
            Console.ReadKey();
        }
    }
}
