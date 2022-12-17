// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
//  и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет
const int leftRange = 0;
const int rightRange = 10;
const int rows = 3;
const int columns = 4;

// ввод размера массива
// int rows = EnterNumber("Input number of rows: ");
// int columns = EnterNumber("Input number of columns: ");

// ввод индексов элемента i и j
int firstIndex = EnterNumber("Input first index: ");
int secondIndex = EnterNumber("Input second index: ");

void OutputFindElementValue(int[,] array)
{
    if (firstIndex < rows & secondIndex < columns)
    {
        Console.WriteLine($"Element value[{firstIndex},{secondIndex}]: " + array[firstIndex, secondIndex]);
    }
    else
    {
        Console.WriteLine($"[{firstIndex},{secondIndex}] -> no such element");
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

int[,] CreateArrayWithRandomNumbers(int rows, int columns, int leftRange, int rightRange)
{
    int[,] array = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = new Random().Next(leftRange, rightRange);
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

// задаем двумерный массив

int[,] matrix = CreateArrayWithRandomNumbers(rows, columns, leftRange, rightRange);

// Выводим массив

OutputArray(matrix);

// выводим значение введенного элемента или указание, что его нет

OutputFindElementValue(matrix);