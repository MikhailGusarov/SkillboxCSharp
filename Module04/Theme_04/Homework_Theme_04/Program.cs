using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_Theme_04
{
    class Program
    {
        static void Main(string[] args)
        {
            #region ТЗ 1
            // Задание 1.
            // Заказчик просит вас написать приложение по учёту финансов
            // и продемонстрировать его работу.
            // Суть задачи в следующем: 
            // Руководство фирмы по 12 месяцам ведет учет расходов и поступлений средств. 
            // За год получены два массива – расходов и поступлений.
            // Определить прибыли по месяцам
            // Количество месяцев с положительной прибылью.
            // Добавить возможность вывода трех худших показателей по месяцам, с худшей прибылью, 
            // если есть несколько месяцев, в некоторых худшая прибыль совпала - вывести их все.
            // Организовать дружелюбный интерфейс взаимодействия и вывода данных на экран

            // Пример
            //       
            // Месяц      Доход, тыс. руб.  Расход, тыс. руб.     Прибыль, тыс. руб.
            //     1              100 000             80 000                 20 000
            //     2              120 000             90 000                 30 000
            //     3               80 000             70 000                 10 000
            //     4               70 000             70 000                      0
            //     5              100 000             80 000                 20 000
            //     6              200 000            120 000                 80 000
            //     7              130 000            140 000                -10 000
            //     8              150 000             65 000                 85 000
            //     9              190 000             90 000                100 000
            //    10              110 000             70 000                 40 000
            //    11              150 000            120 000                 30 000
            //    12              100 000             80 000                 20 000
            // 
            // Худшая прибыль в месяцах: 7, 4, 1, 5, 12
            // Месяцев с положительной прибылью: 10
            #endregion
            #region Решение 1
            //int[] income = new int[12];
            //int[] expence = new int[12];
            //int[] profit = new int[12];
            //Random rand = new Random();
            //Console.WriteLine("Месяц      Доход, тыс. руб.  Расход, тыс. руб.     Прибыль, тыс. руб.");
            //for (int i = 0; i < income.Length; i++)
            //{
            //    income[i] = rand.Next(6, 30) * 10000;
            //    expence[i] = rand.Next(6, 20) * 10000;
            //    profit[i] = income[i] - expence[i];
            //    Console.WriteLine($"{i + 1,5} {income[i], 21} {expence[i],18} {profit[i],22}");
            //}
            //int positiveMonth = 0;
            //foreach (int profitMonth in profit)
            //{
            //    positiveMonth += profitMonth > 0 ? 1 : 0; 
            //}
            //Console.WriteLine($"Месяцев с положительной прибылью: {positiveMonth}");

            //string fallProfit = "";
            //int[] profitCopy = new int[12];
            //profit.CopyTo(profitCopy, 0);
            //for (int i = 0; i < 3; i++)
            //{
            //    int minimal = profitCopy.Min();
            //    for (int j = 0; j < profitCopy.Length; j++)
            //    {
            //        if(profitCopy[j] == minimal)
            //        {
            //            fallProfit += Convert.ToString(j + 1) + ", ";
            //            profitCopy[j] = int.MaxValue;
            //        }
            //    }
            //}
            //fallProfit = fallProfit.Substring(0, fallProfit.Length - 2);
            //Console.WriteLine($"Худшая прибыль в месяцах: {fallProfit}");
            //Console.ReadKey();
            #endregion




            #region ТЗ 2
            // * Задание 2
            // Заказчику требуется приложение строящее первых N строк треугольника паскаля. N < 25
            // 
            // При N = 9. Треугольник выглядит следующим образом:
            //                                 1
            //                             1       1
            //                         1       2       1
            //                     1       3       3       1
            //                 1       4       6       4       1
            //             1       5      10      10       5       1
            //         1       6      15      20      15       6       1
            //     1       7      21      35      35       21      7       1
            //   1     8      28      56      70      56       28     8       1
            //                                                              
            //                                                              
            // Простое решение:                                                             
            // 1
            // 1       1
            // 1       2       1
            // 1       3       3       1
            // 1       4       6       4       1
            // 1       5      10      10       5       1
            // 1       6      15      20      15       6       1
            // 1       7      21      35      35       21      7       1
            // 
            // Справка: https://ru.wikipedia.org/wiki/Треугольник_Паскаля


            #endregion

            #region Решение 2

            //int N = 25;
            //int[][] pascalTriangle = new int[N][];

            //pascalTriangle[0] = new int[1] { 1 };
            //Console.WriteLine($"{1,8}");

            //for (int i = 1; i < N; i++)
            //{
            //    pascalTriangle[i] = new int[i + 1];
            //    for (int j = 0; j < pascalTriangle[i].Length; j++)
            //    {
            //        if (j == 0 || j == pascalTriangle[i].Length - 1)
            //        {
            //            pascalTriangle[i][j] = 1;
            //        }
            //        else
            //        {
            //            pascalTriangle[i][j] = pascalTriangle[i-1][j-1] + pascalTriangle[i - 1][j];
            //        }
            //        Console.Write($"{pascalTriangle[i][j],8}");
            //    }
            //    Console.WriteLine();
            //}


            //Console.ReadKey();
            #endregion

            #region ТЗ 3.1
            // 
            // * Задание 3.1
            // Заказчику требуется приложение позволяющщее умножать математическую матрицу на число
            // Справка https://ru.wikipedia.org/wiki/Матрица_(математика)
            // Справка https://ru.wikipedia.org/wiki/Матрица_(математика)#Умножение_матрицы_на_число
            // Добавить возможность ввода количество строк и столцов матрицы и число,
            // на которое будет производиться умножение.
            // Матрицы заполняются автоматически. 
            // Если по введённым пользователем данным действие произвести невозможно - сообщить об этом
            //
            // Пример
            //
            //      |  1  3  5  |   |  5  15  25  |
            //  5 х |  4  5  7  | = | 20  25  35  |
            //      |  5  3  1  |   | 25  15   5  |
            //
            #endregion
            #region Решение 3.1
            //Console.Write("Введите кол-во строк матрицы: ");
            //int lenghtMatrix = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Введите кол-во столбцов матрицы: ");
            //int widthMatrix = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Введите число: ");
            //int number = Convert.ToInt32(Console.ReadLine());

            //Random rand = new Random();

            //int[,] matrix = new int[lenghtMatrix, widthMatrix];
            //int[,] resultMatrix = new int[lenghtMatrix, widthMatrix];
            //for (int i = 0; i < lenghtMatrix; i++)
            //{
            //    if (i == lenghtMatrix / 2)
            //    {
            //        Console.Write($"{number,4} X |");
            //    }
            //    else
            //    {
            //        Console.Write("       |");
            //    }
            //    for(int j = 0; j < widthMatrix; j++)
            //    {
            //        matrix[i, j] = rand.Next(1, 9);
            //        Console.Write($"{matrix[i, j]} ");
            //    }
            //    if (i == lenghtMatrix / 2)
            //    {
            //        Console.Write("| = |");
            //    }
            //    else
            //    {
            //        Console.Write("|   |");
            //    }
            //    for (int j = 0; j < widthMatrix; j++)
            //    {
            //        resultMatrix[i, j] = matrix[i, j] * number;
            //        Console.Write($"{resultMatrix[i, j], 3} ");
            //    }
            //    Console.WriteLine("|");
            //}
            //Console.ReadKey();
            #endregion
            #region ТЗ 3.2
            //
            // ** Задание 3.2
            // Заказчику требуется приложение позволяющщее складывать и вычитать математические матрицы
            // Справка https://ru.wikipedia.org/wiki/Матрица_(математика)
            // Справка https://ru.wikipedia.org/wiki/Матрица_(математика)#Сложение_матриц
            // Добавить возможность ввода количество строк и столцов матрицы.
            // Матрицы заполняются автоматически
            // Если по введённым пользователем данным действие произвести невозможно - сообщить об этом
            //
            // Пример
            //  |  1  3  5  |   |  1  3  4  |   |  2   6   9  |
            //  |  4  5  7  | + |  2  5  6  | = |  6  10  13  |
            //  |  5  3  1  |   |  3  6  7  |   |  8   9   8  |
            //  
            //  
            //  |  1  3  5  |   |  1  3  4  |   |  0   0   1  |
            //  |  4  5  7  | - |  2  5  6  | = |  2   0   1  |
            //  |  5  3  1  |   |  3  6  7  |   |  2  -3  -6  |
            //

            #endregion
            #region Решение 3.2
            //Console.Write("Введите кол-во строк матрицы: ");
            //int lenghtMatrix = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Введите кол-во столбцов матрицы: ");
            //int widthMatrix = Convert.ToInt32(Console.ReadLine());

            //Random rand = new Random();

            //int[,] matrix1 = new int[lenghtMatrix, widthMatrix];
            //int[,] matrix2 = new int[lenghtMatrix, widthMatrix];
            //int[,] resultMatrixPlus = new int[lenghtMatrix, widthMatrix];
            //int[,] resultMatrixMinus = new int[lenghtMatrix, widthMatrix];
            //for (int i = 0; i < lenghtMatrix; i++)
            //{
            //    string stringMatrix1 = "| ";
            //    string stringMatrix2 = "| ";
            //    string stringMatrixPlus = "| ";
            //    for (int j = 0; j < widthMatrix; j++)
            //    {
            //        matrix1[i, j] = rand.Next(1, 9);
            //        matrix2[i, j] = rand.Next(1, 9);
            //        resultMatrixPlus[i, j] = matrix1[i, j] + matrix2[i, j];
            //        resultMatrixMinus[i, j] = matrix1[i, j] - matrix2[i, j];

            //        stringMatrix1 += $"{matrix1[i, j],3} ";
            //        stringMatrix2 += $"{matrix2[i, j],3} ";
            //        stringMatrixPlus += $"{resultMatrixMinus[i, j],3} ";
            //    }
            //    stringMatrix1 += "| ";
            //    stringMatrix2 += "| ";
            //    stringMatrixPlus += "| ";

            //    if(i == lenghtMatrix / 2)
            //    {
            //        Console.WriteLine($"{stringMatrix1} + {stringMatrix2} = {stringMatrixPlus}");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"{stringMatrix1}   {stringMatrix2}   {stringMatrixPlus}");
            //    }
            //}
            //Console.WriteLine();

            //for (int i = 0; i < lenghtMatrix; i++)
            //{
            //    string stringMatrix1 = "| ";
            //    string stringMatrix2 = "| ";
            //    string stringMatrixMinus = "| ";
            //    for (int j = 0; j < widthMatrix; j++)
            //    {

            //        stringMatrix1 += $"{matrix1[i, j],3} ";
            //        stringMatrix2 += $"{matrix2[i, j],3} ";
            //        stringMatrixMinus += $"{resultMatrixMinus[i, j], 3} ";
            //    }
            //    stringMatrix1 += "| ";
            //    stringMatrix2 += "| ";
            //    stringMatrixMinus += "| ";

            //    if (i == lenghtMatrix / 2)
            //    {
            //        Console.WriteLine($"{stringMatrix1} - {stringMatrix2} = {stringMatrixMinus}");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"{stringMatrix1}   {stringMatrix2}   {stringMatrixMinus}");
            //    }
            //}


            //Console.ReadKey();


            #endregion

            #region ТЗ 3.3
            // *** Задание 3.3
            // Заказчику требуется приложение позволяющщее перемножать математические матрицы
            // Справка https://ru.wikipedia.org/wiki/Матрица_(математика)
            // Справка https://ru.wikipedia.org/wiki/Матрица_(математика)#Умножение_матриц
            // Добавить возможность ввода количество строк и столцов матрицы.
            // Матрицы заполняются автоматически
            // Если по введённым пользователем данным действие произвести нельзя - сообщить об этом
            //  
            //  |  1  3  5  |   |  1  3  4  |   | 22  48  57  |
            //  |  4  5  7  | х |  2  5  6  | = | 35  79  95  |
            //  |  5  3  1  |   |  3  6  7  |   | 14  36  45  |
            //
            //  
            //                  | 4 |   
            //  |  1  2  3  | х | 5 | = | 32 |
            //                  | 6 |  
            //

            #endregion
            #region Решение 3.3

            Console.Write("Введите кол-во строк матрицы №1: ");
            int lenght1Matrix = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите кол-во столбцов матрицы №1: ");
            int width1Matrix = Convert.ToInt32(Console.ReadLine());
            int lenght2Matrix = width1Matrix;
            Console.Write("Введите кол-во столбцов матрицы №2: ");
            int width2Matrix = Convert.ToInt32(Console.ReadLine());

            Random rand = new Random();

            int[,] matrix1 = new int[lenght1Matrix, width1Matrix];
            int[,] matrix2 = new int[lenght2Matrix, width2Matrix];
            int[,] resultMatrix = new int[lenght1Matrix, width2Matrix];

            for (int i = 0; i < lenght1Matrix; i++)
            {
                Console.Write("| ");
                for (int j = 0; j < width1Matrix; j++)
                {
                    matrix1[i, j] = rand.Next(1, 4);
                    Console.Write($"{matrix1[i, j]} ");
                }
                Console.WriteLine("| ");
            }
            Console.WriteLine("");
            Console.WriteLine("     X         ");
            Console.WriteLine("");
            for (int i = 0; i < lenght2Matrix; i++)
            {
                Console.Write("| ");
                for (int j = 0; j < width2Matrix; j++)
                {
                    matrix2[i, j] = rand.Next(1, 4);
                    Console.Write($"{matrix2[i, j]} ");
                }
                Console.WriteLine("| ");
            }

            Console.WriteLine("");
            Console.WriteLine("     =         ");
            Console.WriteLine("");

            int sum = 0;
            for (int i = 0; i < lenght1Matrix; i++)
            {
                Console.Write("| ");
                for (int j = 0; j < width2Matrix; j++)
                {
                    sum = 0;
                    for(int k = 0; k < width1Matrix; k++)
                    {
                        sum += matrix1[i, k] * matrix2[k, j];
                    }
                    resultMatrix[i, j] = sum;
                    Console.Write($"{resultMatrix[i, j]} ");
                }
                Console.WriteLine("| ");
            }
            Console.ReadKey();

            #endregion
        }


    }
}
