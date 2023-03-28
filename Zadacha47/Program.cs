// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

int Numb(string message)
{
    Console.WriteLine(message);
    int n = Convert.ToInt32(Console.ReadLine());
    return n;
}

void ArrayRandom(double[,] arg)
{
    for (int i = 0; i < arg.GetLength(0); i++)
    {
        for (int j = 0; j < arg.GetLength(1); j++)
        {
            arg[i, j] = Math.Round(new Random().Next(-10, 11) + new Random().NextDouble(),2);
        }
    }
}

void PrintArray(double[,] arg)
{
    for (int i = 0; i < arg.GetLength(0); i++)
    {
        for (int j = 0; j < arg.GetLength(1); j++)
        {
            Console.Write($"{arg[i,j]} ");
        }
        Console.WriteLine();
    }
}

Console.Clear();
int rows = Numb("Введите количество строк вашего массива");
int columns = Numb("Введите количество столбцов вашего массива");
double[,] array = new double[rows, columns];
ArrayRandom(array);
PrintArray(array);
