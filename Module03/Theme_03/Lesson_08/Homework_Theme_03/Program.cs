using System;
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

            Console.Write("Укажите количество игроков: ");
            string[] users = new string[Convert.ToInt32(Console.ReadLine())];

            // Получение никнеймов игроков
            for (int i = 0; i < users.Length; i++)
            {
                Console.Write($"Введите никнейм игрока {i + 1}: ");
                users[i] = Console.ReadLine();
            }

            // конечное случайное число от пользователя
            int getNumberEnd = 12;
            do
            {
                Console.Write("Укажите размер диапазона случайного числа(больше 12): ");
                getNumberEnd = Convert.ToInt32(Console.ReadLine());
                if (getNumberEnd < 12) Console.WriteLine("Число должно быть больше 12");
            } while (getNumberEnd < 12);

            // Генерация и вывод случайного числа
            Random rand = new Random();
            int getNumber = rand.Next(12, getNumberEnd);

            int userTry;
            string revenge = "";
            int userNumber = -1;
            string correntUser = "";

            while (true)
            {
                Console.WriteLine($"Число: {getNumber}");

                // переход к следующему игроку
                userNumber++;
                userNumber %= (users.Length);
                if(users.Length == 1)
                {
                    if (correntUser == "" || correntUser != users[userNumber])
                    {
                        correntUser = users[userNumber];
                    }
                    else
                    {
                        correntUser = "компьютер";
                    }
                }
                else
                {
                    correntUser = users[userNumber];
                }
                
                
                if(correntUser != "компьютер")
                {
                    // Ход игрока userNumber
                    do
                    {
                        Console.Write($"{correntUser} введите число от 1 до 4: ");
                        userTry = Convert.ToInt32(Console.ReadLine());
                        if (userTry < 1 || userTry > 4) Console.WriteLine("Некорректно");

                    } while (userTry < 1 || userTry > 4);
                }
                else
                {
                    Console.WriteLine("Ходит компьютер");
                    userTry = getNumber - 4 <= 0 ? getNumber : rand.Next(1, 5);
                    Console.WriteLine($"Компьютер ввел число {userTry}");
                }
                
                getNumber -= userTry;

                if (getNumber <= 0)
                {
                    Console.WriteLine($"{correntUser} победил. Может реванш(да|нет)?");
                    do
                    {
                        revenge = Console.ReadLine();
                        if (revenge != "да" && revenge != "нет") Console.WriteLine("Некорректно");
                    } while (revenge != "да" && revenge != "нет");
                    
                    if (revenge == "да")
                    {
                        getNumber = rand.Next(12, getNumberEnd);
                        revenge = "";
                        continue;
                    }
                    else if (revenge == "нет")
                    {
                        Console.WriteLine("Спасибо за игру!");
                        break;
                    }
                }
            }
            Console.ReadKey();
        }
    }
}
