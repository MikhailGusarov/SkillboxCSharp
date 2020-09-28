using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Example_005
{
    class Program
    {
        #region Решение 1
        /// <summary>
        /// Генерация двумерного массива случайными числами от 1 до 9
        /// </summary>
        /// <param name="lenght">Кол-во строк массива</param>
        /// <param name="width">Кол-во столбцов массива</param>
        /// <returns>двумерный массив случайных целых числел </returns>
        static int[,] GenerateMatrix(int lenght, int width, Random rand)
        {
            
            int[,] matrix = new int[lenght, width];
            for (int i = 0; i < lenght; i++)
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
        /// <summary>
        /// Суммирование двух двумерных матриц
        /// </summary>
        /// <param name="matrix1">первая матрица</param>
        /// <param name="matrix2">вторая матрица</param>
        /// <returns>результат сложения двух матриц</returns>
        static int[,] SumMatrix(int[,] matrix1, int[,] matrix2)
        {

            int[,] result = new int[matrix1.GetLength(0), matrix1.GetLength(1)];
            for (int i = 0; i < matrix1.GetLength(0); i++)
            {
                for (int j = 0; j < matrix1.GetLength(1); j++)
                {
                    result[i, j] = matrix1[i, j] + matrix2[i, j];
                }
            }
            return result;
        }
        /// <summary>
        /// Вычитание двух двумерных матриц
        /// </summary>
        /// <param name="matrix1">первая матрица</param>
        /// <param name="matrix2">вторая матрица</param>
        /// <returns>результат вычитания двух матриц</returns>
        static int[,] SubTractionMatrix(int[,] matrix1, int[,] matrix2)
        {

            int[,] result = new int[matrix1.GetLength(0), matrix1.GetLength(1)];
            for (int i = 0; i < matrix1.GetLength(0); i++)
            {
                for (int j = 0; j < matrix1.GetLength(1); j++)
                {
                    result[i, j] = matrix1[i, j] - matrix2[i, j];
                }
            }
            return result;
        }
        /// <summary>
        /// Умножение матриц
        /// </summary>
        /// <param name="matrix1">Первая матрица</param>
        /// <param name="matrix2">Вторая матрица</param>
        /// <returns>Результирующая матрица</returns>
        static int[,] MultiplicationMatrix(int[,] matrix1, int[,] matrix2)
        {

            int[,] result = new int[matrix1.GetLength(0), matrix2.GetLength(1)];
            int sum = 0;
            for (int i = 0; i < matrix1.GetLength(0); i++)
            {
                for (int j = 0; j < matrix2.GetLength(1); j++)
                {
                    sum = 0;
                    for (int k = 0; k < matrix1.GetLength(1); k++)
                    {
                        sum += matrix1[i, k] * matrix2[k, j];
                    }
                    result[i, j] = sum;
                }
            }
            return result;
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

        /// <summary>
        /// метод, принимающий текст и возвращающий слово, содержащее минимальное количество букв
        /// </summary>
        /// <param name="words">исходное слово</param>
        /// <returns>минимальное слово</returns>
        static string minWord(string words)
        {
            string result = words;
            string word = "";
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i] == ' ' || words[i] == '.' || words[i] == ',')
                {
                    if (word.Length < result.Length && word != "")
                    {
                        result = word;

                    }
                    word = "";
                }
                else
                {
                    word += words[i];
                }
            }
            return result;
        }

        /// <summary>
        /// метод, принимающий текст и возвращающий слова, содержащее максимальное количество букв
        /// </summary>
        /// <param name="words">исходное слово</param>
        /// <returns>максимальные слова</returns>
        static string maxWords(string words)
        {
            string result = "";
            string resultWord = "";
            string word = "";
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i] == ' ' || words[i] == '.' || words[i] == ',')
                {
                    if (word.Length > resultWord.Length && word != "")
                    {
                        result = word;
                        resultWord = word;

                    }
                    else if (word.Length == resultWord.Length)
                    {
                        result += " " + word;
                    }
                    word = "";
                }
                else
                {
                    word += words[i];
                }
            }
            return result;
        }

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

        /// <summary>
        /// Метод удаляет дублирующие символы идущие подряд
        /// </summary>
        /// <param name="startWord">Исходное слово</param>
        /// <returns>Получивщееся слово</returns>
        static string deleteDublicateSymbols(string startWord)
        {
            string result = Convert.ToString(startWord[0]);
            for (int i = 1; i < startWord.Length; i++)
            {
                if (startWord.ToUpper()[i] == startWord.ToUpper()[i - 1])
                {
                    continue;
                }
                else
                {
                    result += startWord[i];
                }
            }
            return result;
        }

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

        /// <summary>
        /// Проверка на арифметическую прогрессию
        /// </summary>
        /// <param name="args">список чисел</param>
        /// <returns>да или нет</returns>
        static bool IsArithmeticProgression(params int[] args)
        {
            int d = args[1] - args[0];
            for (int i = 2; i < args.Length; i++)
            {
                if (args[i] != args[0] + i * d)
                {
                    return false;
                }
            }
            return true;
        }
        /// <summary>
        /// Проверка на геометрическую прогрессию
        /// </summary>
        /// <param name="args">список чисел</param>
        /// <returns>да или нет</returns>
        static bool IsAGeometricProgression(params int[] args)
        {
            int q = args[1] / args[0];
            for (int i = 2; i < args.Length; i++)
            {
                if (args[i] != args[i - 1] * q)
                {
                    return false;
                }
            }
            return true;
        }

        /// <summary>
        /// Проверка на прогрессию
        /// </summary>
        /// <param name="args">список чисел</param>
        /// <returns>да или нет</returns>
        static bool IsProgression(params int[] args)
        {
            return IsArithmeticProgression(args) || IsAGeometricProgression(args);
        }

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
        #region Решение 5

        /// <summary>
        /// Функция Аккермана
        /// </summary>
        /// <param name="n"></param>
        /// <param name="m"></param>
        /// <returns></returns>
        static int Ackermann(int n, int m)
        {
            if (n == 0)
            {
                return m + 1;
            }
            else if (n != 0 && m == 0)
            {
                return Ackermann(n - 1, 1);
            }
            else
            {
                return Ackermann(n - 1, Ackermann(n, m - 1));
            }

        }

        #endregion
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
            //Console.Write("Введите кол-во строк матрицы: ");
            //int lenghtMatrix = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Введите кол-во столбцов матрицы: ");
            //int widthMatrix = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Введите число: ");
            //int number = Convert.ToInt32(Console.ReadLine());
            //Random rand = new Random();

            //int[,] matrix = GenerateMatrix(lenghtMatrix, widthMatrix, rand);
            //int[,] resultMatrix = MultiplicationNumberWithMatrix(number, matrix);

            //// Вывод на экран
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
            //    for (int j = 0; j < widthMatrix; j++)
            //    {
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
            //        Console.Write($"{resultMatrix[i, j],3} ");
            //    }
            //    Console.WriteLine("|");
            //}
            //Console.ReadKey();
            #endregion
            #region Решение 1.2
            //Console.Write("Введите кол-во строк матрицы: ");
            //int lenghtMatrix = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Введите кол-во столбцов матрицы: ");
            //int widthMatrix = Convert.ToInt32(Console.ReadLine());

            //Random rand = new Random();

            //int[,] matrix1 = GenerateMatrix(lenghtMatrix, widthMatrix, rand);
            //int[,] matrix2 = GenerateMatrix(lenghtMatrix, widthMatrix, rand);
            //int[,] resultMatrixPlus = SumMatrix(matrix1, matrix2);
            //int[,] resultMatrixMinus = SubTractionMatrix(matrix1, matrix2);

            //// Вывод на экран суммирования матриц
            //for (int i = 0; i < lenghtMatrix; i++)
            //{
            //    string stringMatrix1 = "| ";
            //    string stringMatrix2 = "| ";
            //    string stringMatrixPlus = "| ";
            //    for (int j = 0; j < widthMatrix; j++)
            //    {
            //        stringMatrix1 += $"{matrix1[i, j],3} ";
            //        stringMatrix2 += $"{matrix2[i, j],3} ";
            //        stringMatrixPlus += $"{resultMatrixPlus[i, j],3} ";
            //    }
            //    stringMatrix1 += "| ";
            //    stringMatrix2 += "| ";
            //    stringMatrixPlus += "| ";

            //    if (i == lenghtMatrix / 2)
            //    {
            //        Console.WriteLine($"{stringMatrix1} + {stringMatrix2} = {stringMatrixPlus}");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"{stringMatrix1}   {stringMatrix2}   {stringMatrixPlus}");
            //    }
            //}
            //Console.WriteLine();
            ////Вывод на экран вычитание матриц
            //for (int i = 0; i < lenghtMatrix; i++)
            //{
            //    string stringMatrix1 = "| ";
            //    string stringMatrix2 = "| ";
            //    string stringMatrixMinus = "| ";
            //    for (int j = 0; j < widthMatrix; j++)
            //    {

            //        stringMatrix1 += $"{matrix1[i, j],3} ";
            //        stringMatrix2 += $"{matrix2[i, j],3} ";
            //        stringMatrixMinus += $"{resultMatrixMinus[i, j],3} ";
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
            #region Решение 1.3

            //Console.Write("Введите кол-во строк матрицы №1: ");
            //int lenght1Matrix = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Введите кол-во столбцов матрицы №1: ");
            //int width1Matrix = Convert.ToInt32(Console.ReadLine());
            //int lenght2Matrix = width1Matrix;
            //Console.Write("Введите кол-во столбцов матрицы №2: ");
            //int width2Matrix = Convert.ToInt32(Console.ReadLine());

            //Random rand = new Random();

            //int[,] matrix1 = GenerateMatrix(lenght1Matrix, width1Matrix, rand);
            //int[,] matrix2 = GenerateMatrix(lenght2Matrix, width2Matrix, rand);
            //int[,] resultMatrix = MultiplicationMatrix(matrix1, matrix2);

            //for (int i = 0; i < lenght1Matrix; i++)
            //{
            //    Console.Write("| ");
            //    for (int j = 0; j < width1Matrix; j++)
            //    {
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
            //        Console.Write($"{matrix2[i, j]} ");
            //    }
            //    Console.WriteLine("| ");
            //}

            //Console.WriteLine("");
            //Console.WriteLine("     =         ");
            //Console.WriteLine("");

            //for (int i = 0; i < lenght1Matrix; i++)
            //{
            //    Console.Write("| ");
            //    for (int j = 0; j < width2Matrix; j++)
            //    {
            //        Console.Write($"{resultMatrix[i, j]} ");
            //    }
            //    Console.WriteLine("| ");
            //}
            //Console.ReadKey();

            #endregion
            #endregion
            #region Решение 2

            //Console.WriteLine($"1. Ответ: {minWord("A ББ ВВВ ГГГГ ДДДД  ДД ЕЕ ЖЖ ЗЗЗ")}"); // Задание 2.1
            //Console.WriteLine($"2. Ответ: {maxWords("A ББ ВВВ ГГГГ ДДДД  ДД ЕЕ ЖЖ ЗЗЗ")}"); // Задание 2.2
            //Console.ReadKey();
            #endregion
            #region Решение 3
            //string startWord = "ПППОООГГГООООДДДААА";
            //string endWord = deleteDublicateSymbols(startWord);
            //Console.WriteLine($"{startWord} >>> {endWord}");

            //startWord = "Ххххоооорррооошшшиий деееннннь";
            //endWord = deleteDublicateSymbols(startWord);
            //Console.WriteLine($"{startWord} >>> {endWord}");

            //Console.ReadKey();

            #endregion
            #region Решение 4

            //Console.WriteLine(IsProgression(2, 4, 8, 16, 32));
            //Console.ReadKey();

            #endregion
            #region Решение 5
            Console.WriteLine(Ackermann(2, 3));
            Console.ReadKey();
            #endregion

        }
    }
}

