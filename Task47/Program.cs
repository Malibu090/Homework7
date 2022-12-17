// Задача 47. Задайте двумерный массив размером m x n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

const int leftRange = 0;
const int rightRange = 100;

void OutputArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write("{0}\t", array[i, j]); // (array[i, j] + "\t")
        }
        Console.WriteLine();
    }
}

double[,] CreateArrayWithRealNumbers(int rows, int columns, int leftRange, int rightRange)
{
    double[,] array = new double[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = Math.Round(new Random().Next(leftRange, rightRange) + new Random().NextDouble(), 2);

        }
    }
    return array;
}

int EnterNumber(string str)
{
    Console.Write(str);
    int number = int.Parse(Console.ReadLine());
    return number;
}

// ввод чисел m и n
// int m = 3;
// int n = 4;
int m = EnterNumber("Input number of rows: ");
int n = EnterNumber("Input number of columns: ");

// создаем массив и заполняем его

double[,] matrix = CreateArrayWithRealNumbers(m, n, leftRange, rightRange);

// выводим массив

OutputArray(matrix);