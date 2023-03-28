// Задача HARD SORT необязательная. Считается за три обязательных
// Задайте двумерный массив из целых чисел. 
// Количество строк и столбцов задается с клавиатуры. 
// Отсортировать элементы по возрастанию слева направо и сверху вниз.

// Например, задан массив:
// 1 4 7 2
// 5 9 10 3

// После сортировки
// 1 2 3 4
// 5 7 9 10





Console.WriteLine("Введите количество строк");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов");
int cols = Convert.ToInt32(Console.ReadLine());
int [,] array = new int [rows,cols];
FillArray(array);
PrintArray(array);
Console.WriteLine();
SortArray(array);



void FillArray(int[,] array)
{
    for (int i =0; i<array.GetLength(0);i++)
        for (int j =0; j<array.GetLength(1);j++)
            array[i,j] = new Random().Next(-30,31);
}

void PrintArray(int[,] array)
{
    for (int i =0; i<array.GetLength(0);i++)
        {
        for (int j =0; j<array.GetLength(1);j++)
            Console.Write($"{array[i,j],3}\t") ;
        Console.WriteLine();
        }       
}

void SortArray(int[,] array)
{
 for (int i = 0; i < rows; i++)
        for (int j = 0; j < cols; j++)
            for (int k = 0; k < rows; k++)
                for (int l = 0; l < cols; l++)
                    if (array[i, j] < array[k, l])
                    {
                        int temp = array[i, j];
                        array[i, j] = array[k, l];
                        array[k, l] = temp;
                    }
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            Console.Write($"{array[i,j],3}\t");
        }
        Console.WriteLine();
    }
}



