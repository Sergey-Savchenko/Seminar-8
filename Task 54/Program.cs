// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

int [,] CreateArray(int rows, int cols, int min, int max)
{
    int [,] array = new int [rows,cols];
    for(int i=0; i<rows; i++)
    {
        for(int j=0; j<cols; j++)
        {
            array[i,j] = new Random().Next(min,max+1);
        }
    }
    return array;
}

void ShowArray(int [,] array)
{
    for(int i=0; i<array.GetLength(0); i++)
    {
        for(int j=0; j<array.GetLength(1); j++)
        {
            Console.Write($"{array[i,j]} ");
        }
        Console.WriteLine();
    }
}

int [,] CountArray(int [,] array)
{
    for(int i=0; i<array.GetLength(0); i++)
    {
        for(int j=0; j<array.GetLength(1)-1; j++)
        {
            for(int z=j+1; z<array.GetLength(1); z++)
            {
                if (array[i,j] < array[i,z])
                {
                int tmp = array[i,j];
                array[i,j]=array[i,z];
                array[i,z] = tmp;
                }

            }
           
        }
    }
    return array;
}

Console.Write("Введите количество рядов массива: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int [,] array = CreateArray(m,n,0,9);
ShowArray(array);
int [,] newarray = CountArray(array);
Console.WriteLine("Упорядоченный массив: ");
ShowArray(newarray);
