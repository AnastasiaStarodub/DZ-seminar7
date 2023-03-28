// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
//и возвращает значение этого элемента или же указание, что такого элемента нет.
//Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

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

Console.Clear();
int rows = new Random().Next(1, 6);
int columns = new Random().Next(1, 6);
int[,] array = new int[rows, columns];
ArrayRandom(array);
PrintArray(array);

int i = Numb("Введите строку вашего элемента: ");
int j = Numb("Введите столбец вашего элемента: ");
if (i <= rows+1 && j <= columns+1) 
        Console.WriteLine($"Ваше число {array[i-1,j-1]}");
else
    Console.WriteLine($"Такой позиции в данном массиве нет");