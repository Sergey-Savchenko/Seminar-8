// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

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

int [,] CountArray(int [,] array1, int [,] array2)
{
    int [,] countarray = new int [array1.GetLength(0),array1.GetLength(1)];
    for(int i=0; i<array1.GetLength(0); i++)
    {
        for(int j=0; j<array1.GetLength(1); j++)
        {
            countarray[i,j] = array1[i,0]*array2[0,j] + array1[i,1]*array2[1,j];
        }
    }
    return countarray;
}

Console.Write("Введите количество рядов и столбцов массива: ");
int m = Convert.ToInt32(Console.ReadLine());
int [,] array1 = CreateArray(m,m,0,5);
Console.WriteLine("Первый массив: ");
ShowArray(array1);
int [,] array2 = CreateArray(m,m,0,5);
Console.WriteLine("Второй массив: ");
ShowArray(array2);
int [,] countarray = CountArray(array1,array2);
Console.WriteLine("Результирующая матрица: ");
ShowArray(countarray);