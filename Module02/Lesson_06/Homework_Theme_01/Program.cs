﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_Theme_01
{
    class Program
    {
        static void Main(string[] args)
        {
            // Заказчик просит написать программу «Записная книжка». Оплата фиксированная - $ 120.

            // В данной программе, должна быть возможность изменения значений нескольких переменных для того,
            // чтобы персонифецировать вывод данных, под конкретного пользователя.

            // Для этого нужно: 
            // 1. Создать несколько переменных разных типов, в которых могут храниться данные
            //    - имя;
            //    - возраст;
            //    - рост;
            //    - баллы по трем предметам: история, математика, русский язык;

            // 2. Реализовать в системе автоматический подсчёт среднего балла по трем предметам, 
            //    указанным в пункте 1.

            // 3. Реализовать возможность печатки информации на консоли при помощи 
            //    - обычного вывода;
            //    - форматированного вывода;
            //    - использования интерполяции строк;

            // 4. Весь код должен быть откомментирован с использованием обычных и хml-комментариев

            // **
            // 5. В качестве бонусной части, за дополнительную оплату $50, заказчик просит реализовать 
            //    возможность вывода данных в центре консоли.

            // Данные ученика
            string firstName = "Жорик";
            byte age = 45;
            byte height = 195;
            byte scoresHistory = 95;
            byte scoresMath = 44;
            byte scoresRus = 81;

            // Подсчет среднего кол-ва баллов
            double scoresAvg = Convert.ToDouble(scoresHistory + scoresMath + scoresRus) / 3;

            string[] output = new string[] { $"Имя: {firstName}",
                $"Возраст: {age}",
                $"Рост: {height}",
                $"Кол-во баллов:",
                $"- История: {scoresHistory}",
                $"- Математика: {scoresMath}",
                $"- Русский язык: {scoresRus}",
                $"Средний балл: {scoresAvg:0.00}"
            };
            for (int i = 0; i < output.Length; i++)
            {
                Console.SetCursorPosition(Console.WindowWidth / 2 - output[i].Length / 2, Console.WindowHeight / 2 + i - output.Length / 2);
                Console.WriteLine(output[i]);
            }
            

            Console.ReadKey();

            

        }
    }
}
