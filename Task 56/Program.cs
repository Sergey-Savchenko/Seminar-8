// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

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

void Count(int [,] array)
{
    int [] countarray = new int [array.GetLength(1)+1];
    for(int i=0; i<array.GetLength(0); i++)
    {
        for(int j=0; j<array.GetLength(1); j++)
        {
            countarray[i] = countarray[i] + array[i,j];
        }
        Console.WriteLine($"Сумма элементов {i+1} строки: {countarray[i]}");
    }
    int min = 0;
    for(int i=0; i<array.GetLength(0)-1; i++)
    {
        if(countarray[i+1]<countarray[i])
        {
            min = i+1;
        }
    }
    Console.WriteLine($"Строка с минимальной суммой: {min+1}");
}

Console.Write("Введите количество рядов и столбцов массива: ");
int m = Convert.ToInt32(Console.ReadLine());
int [,] array = CreateArray(m,m,0,9);
ShowArray(array);
Count(array);
