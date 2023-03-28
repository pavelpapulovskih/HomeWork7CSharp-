// Задача 50. Напишите программу, которая на вход принимает значение элемента в 
// двумерном массиве, и возвращает позицию этого элемента или же указание, 
// что такого элемента нет.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 17 -> такого числа в массиве нет


Console.WriteLine("Введите количество строк");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов");
int cols = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите элемент который нужно найти в масиве.");
int element = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[rows, cols];
FillArray(array);
PrintArray(array);
SerchArray(array);

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = new Random().Next(1, 10);
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write($"{array[i, j],3}\t");
        Console.WriteLine();
    }
}

bool SerchArray(int[,] array)
{
    bool found = false;
        int row = 0, col = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                if (array[i, j] == element)
                {
                    found = true;
                    row = i;
                    col = j;
                    break;
                }
            }
            if (found) break;
        }

        if (found)
        {
            Console.WriteLine($"Значение найдено в позиции ({row}, {col})");
            return true;
        }
        else
        {
            Console.WriteLine("Значение не найдено");
            return false;
        }

        Console.ReadLine();
    }





