// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int Numb(string message)
{
    Console.WriteLine(message);
    int n = Convert.ToInt32(Console.ReadLine());
    return n;
}

void ArrayRandom(int[,] arg)
{
    for (int i = 0; i < arg.GetLength(0); i++)
    {
        for (int j = 0; j < arg.GetLength(1); j++)
        {
            arg[i, j] = new Random().Next(1, 10);
        }
    }
}

void PrintArray(int[,] arg)
{
    for (int i = 0; i < arg.GetLength(0); i++)
    {
        for (int j = 0; j < arg.GetLength(1); j++)
        {
            Console.Write($"{arg[i, j]} ");
        }
        Console.WriteLine();
    }
}

void Average(int[,] arg)
{
    Console.Write("Среднее арифметическое каждого столбца: ");
    for (int j = 0; j < arg.GetLength(1); j++)
    {
        double result = 0;
        for (int i = 0; i < arg.GetLength(0); i++)
        {
            result += arg[i, j];
        }
        Console.Write($"{result / arg.GetLength(0):F2} ");
    }
}

Console.Clear();
int rows = Numb("Введите количество строк вашего массива: ");
int columns = Numb("Введите количество столбцов вашего массива: ");
int[,] array = new int[rows, columns];
ArrayRandom(array);
PrintArray(array);
Average(array);





