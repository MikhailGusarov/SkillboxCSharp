using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_005
{
    class Program
    {
        /// <summary>
        /// Генерация двумерного массива случайными числами от 1 до 9
        /// </summary>
        /// <param name="lenght">Кол-во строк массива</param>
        /// <param name="width">Кол-во столбцов массива</param>
        /// <returns>двумерный массив случайных целых числел </returns>
        static int[,] GenerateMatrix(int lenght, int width)
        {
            Random rand = new Random();

            int[,] matrix = new int[lenght, width];
            for(int i = 0; i < lenght; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    matrix[i, j] = rand.Next(1, 9);
                }
            }
            return matrix;
        }
        /// <summary>
        /// Умножение числа на двумерный массив
        /// </summary>
        /// <param name="Number">Числовой множитель</param>
        /// <param name="matrix">Двумерный массив</param>
        /// <returns>Результирующий двумерный массив</returns>
        static int[,] MultiplicationNumberWithMatrix(int Number, int[,] matrix)
        {

            int[,] result = new int[matrix.GetLength(0), matrix.GetLength(1)];
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    result[i, j] = matrix[i, j] * Number;
                }
            }
            return result;
        }


        static void Main(string[] args)
        {

            // Домашнее задание
            // Требуется написать несколько методов
            //
            #region ТЗ 1
            // Задание 1.
            // Воспользовавшись решением задания 3 четвертого модуля
            // 1.1. Создать метод, принимающий число и матрицу, возвращающий матрицу умноженную на число
            // 1.2. Создать метод, принимающий две матрицу, возвращающий их сумму
            // 1.3. Создать метод, принимающий две матрицу, возвращающий их произведение
            #endregion

            #region Решение 1

            #region Решение 1.1
            Console.Write("Введите кол-во строк матрицы: ");
            int lenghtMatrix = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите кол-во столбцов матрицы: ");
            int widthMatrix = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите число: ");
            int number = Convert.ToInt32(Console.ReadLine());


            int[,] matrix = GenerateMatrix(lenghtMatrix, widthMatrix);
            int[,] resultMatrix = MultiplicationNumberWithMatrix(number, matrix);
            
            // Вывод на экран
            for (int i = 0; i < lenghtMatrix; i++)
            {
                if (i == lenghtMatrix / 2)
                {
                    Console.Write($"{number,4} X |");
                }
                else
                {
                    Console.Write("       |");
                }
                for (int j = 0; j < widthMatrix; j++)
                {
                    Console.Write($"{matrix[i, j]} ");
                }
                if (i == lenghtMatrix / 2)
                {
                    Console.Write("| = |");
                }
                else
                {
                    Console.Write("|   |");
                }
                for (int j = 0; j < widthMatrix; j++)
                {
                    Console.Write($"{resultMatrix[i, j],3} ");
                }
                Console.WriteLine("|");
            }
            Console.ReadKey();
            #endregion
            #region ТЗ 1.2
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
            #region Решение 1.2
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

            #region ТЗ 1.3
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
            #region Решение 1.3

            //Console.Write("Введите кол-во строк матрицы №1: ");
            //int lenght1Matrix = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Введите кол-во столбцов матрицы №1: ");
            //int width1Matrix = Convert.ToInt32(Console.ReadLine());
            //int lenght2Matrix = width1Matrix;
            //Console.Write("Введите кол-во столбцов матрицы №2: ");
            //int width2Matrix = Convert.ToInt32(Console.ReadLine());

            //Random rand = new Random();

            //int[,] matrix1 = new int[lenght1Matrix, width1Matrix];
            //int[,] matrix2 = new int[lenght2Matrix, width2Matrix];
            //int[,] resultMatrix = new int[lenght1Matrix, width2Matrix];

            //for (int i = 0; i < lenght1Matrix; i++)
            //{
            //    Console.Write("| ");
            //    for (int j = 0; j < width1Matrix; j++)
            //    {
            //        matrix1[i, j] = rand.Next(1, 4);
            //        Console.Write($"{matrix1[i, j]} ");
            //    }
            //    Console.WriteLine("| ");
            //}
            //Console.WriteLine("");
            //Console.WriteLine("     X         ");
            //Console.WriteLine("");
            //for (int i = 0; i < lenght2Matrix; i++)
            //{
            //    Console.Write("| ");
            //    for (int j = 0; j < width2Matrix; j++)
            //    {
            //        matrix2[i, j] = rand.Next(1, 4);
            //        Console.Write($"{matrix2[i, j]} ");
            //    }
            //    Console.WriteLine("| ");
            //}

            //Console.WriteLine("");
            //Console.WriteLine("     =         ");
            //Console.WriteLine("");

            //int sum = 0;
            //for (int i = 0; i < lenght1Matrix; i++)
            //{
            //    Console.Write("| ");
            //    for (int j = 0; j < width2Matrix; j++)
            //    {
            //        sum = 0;
            //        for (int k = 0; k < width1Matrix; k++)
            //        {
            //            sum += matrix1[i, k] * matrix2[k, j];
            //        }
            //        resultMatrix[i, j] = sum;
            //        Console.Write($"{resultMatrix[i, j]} ");
            //    }
            //    Console.WriteLine("| ");
            //}
            //Console.ReadKey();

            #endregion
        }




        #endregion
        #region ТЗ 2
        //
        // Задание 2.
        // 1. Создать метод, принимающий  текст и возвращающий слово, содержащее минимальное количество букв
        // 2.* Создать метод, принимающий  текст и возвращающий слово(слова) с максимальным количеством букв 
        // Примечание: слова в тексте могут быть разделены символами (пробелом, точкой, запятой) 
        // Пример: Текст: "A ББ ВВВ ГГГГ ДДДД  ДД ЕЕ ЖЖ ЗЗЗ"
        // 1. Ответ: А
        // 2. ГГГГ, ДДДД
        #endregion
        #region Решение 2
        #endregion
        #region ТЗ 3
        //
        // Задание 3. Создать метод, принимающий текст. 
        // Результатом работы метода должен быть новый текст, в котором
        // удалены все кратные рядом стоящие символы, оставив по одному 
        // Пример: ПППОООГГГООООДДДААА >>> ПОГОДА
        // Пример: Ххххоооорррооошшшиий деееннннь >>> хороший день
        // 
        #endregion
        #region Решение 3
        #endregion
        #region ТЗ 4
        // Задание 4. Написать метод принимающий некоторое количесво чисел, выяснить
        // является заданная последовательность элементами арифметической или геометрической прогрессии
        // 
        // Примечание
        //             http://ru.wikipedia.org/wiki/Арифметическая_прогрессия
        //             http://ru.wikipedia.org/wiki/Геометрическая_прогрессия
        //
        #endregion
        #region Решение 4
        #endregion
        #region ТЗ 5
        // *Задание 5
        // Вычислить, используя рекурсию, функцию Аккермана:
        // A(2, 5), A(1, 2)
        // A(n, m) = m + 1, если n = 0,
        //         = A(n - 1, 1), если n <> 0, m = 0,
        //         = A(n - 1, A(n, m - 1)), если n> 0, m > 0.
        // 
        // Весь код должен быть откоммментирован
        #endregion
    }
}

