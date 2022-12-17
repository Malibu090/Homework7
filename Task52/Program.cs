// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

const int leftRange = 1;
const int rightRange = 10;
// const int rows = 3;
// const int columns = 4;

// ввод размера массива
int rows = EnterNumber("Input number of rows: ");
int columns = EnterNumber("Input number of columns: ");

void OutputArithmeticMeanColumn(int[,] matrix)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        double sum = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            sum += matrix[i, j];
        }
        double arg = Math.Round(sum / matrix.GetLength(0), 2);

        Console.Write(arg + "|");
    }
}

void OutputArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

int[,] CreateArrayIntegerNumbers(int rows, int columns, int leftRange, int rightRange)
{
    int[,] array = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = new Random().Next(leftRange, rightRange);
            // array[i, j] = new Random().Next(0, 10);
        }
    }
    return array;
}

int EnterNumber(string str)
{
    Console.WriteLine(str);
    int number = int.Parse(Console.ReadLine());
    return number;
}
// создать двумерный массив из целых чисел

int[,] matrix = CreateArrayIntegerNumbers(rows, columns, leftRange, rightRange);

// Вывести массив в консоль
Console.WriteLine();
OutputArray(matrix);

// вычислить и вывести среднее арифметическое каждого столбца
Console.WriteLine();
OutputArithmeticMeanColumn(matrix);
