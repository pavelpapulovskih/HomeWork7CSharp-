// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.



Console.WriteLine("Введите количество строк");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов");
int cols = Convert.ToInt32(Console.ReadLine());
int [,] array = new int [rows,cols];
FillArray(array);
PrintArray(array);
MiddleSum(array);

void FillArray(int[,] array)
{
    for (int i =0; i<array.GetLength(0);i++)
        for (int j =0; j<array.GetLength(1);j++)
            array[i,j] = new Random().Next(1,10);
}

void PrintArray(int[,] array)
{
    for (int i =0; i<array.GetLength(0);i++)
        {
        for (int j =0; j<array.GetLength(1);j++)
            Console.Write($"{array[i,j]}\t") ;
        Console.WriteLine();
        }       
}

void MiddleSum(int[,] array)
{
      double[] averages = new double[cols];
        for (int j = 0; j < cols; j++)
        {
            int sum = 0;
            for (int i = 0; i < rows; i++)
            {
                sum += array[i, j];
            }
            averages[j] = (double)sum / rows;
        }
        Console.WriteLine("Средние арифметические:");
        for (int j = 0; j < cols; j++)
        {
            Console.WriteLine($"Столбец {j}: {Math.Round(averages[j])}");
        }
    }




