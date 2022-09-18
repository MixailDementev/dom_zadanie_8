// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки
// с наименьшей суммой элементов: 1 строка.
Console.Write("Еnter the number of rows in the array: ");
int rows = int.Parse(Console.ReadLine());
Console.Write("Еnter the number of columns in the array: ");
int columns = int.Parse(Console.ReadLine());
System.Console.WriteLine();

int[,] array = EnterArray(rows, columns);
int[,] EnterArray(int rows, int columns)
{
    int[,] result = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            result[i, j] = new Random().Next(10);
        }
    }
    return result;
}

void PrintArray(int[,] array)
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

void SmallestRowSum(int[,] array)
{
    int minRowSum = int.MaxValue, indexMinRow = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum += array[i, j];
        }
        if (sum < minRowSum)
        {
            minRowSum = sum;
            indexMinRow = i;
        }
        Console.WriteLine($"sum of row elements = {sum}");
    }
    Console.WriteLine($"row with the minimum sum of elements - {indexMinRow}");
    return;
}
PrintArray(array);
Console.WriteLine();
SmallestRowSum(array);
