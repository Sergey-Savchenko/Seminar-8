// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

int [,] CreateArray(int n){
int[,] array = new int[n, n];
int row = 0;
int col = 0;
int diferx = 1;
int difery = 0;
int steps = n;
int count = 0;
int twostep = 2;
 
            for (int i = 0; i < n*n; i++) {
                array[row, col] = i + 1;
                steps = steps - 1;
              if (steps == 0) {
                if (twostep == 2){
                    count++;
                    twostep = 0;
                }
                steps = n - count;
                int temp = diferx;
                diferx = -difery;
                difery = temp;
                twostep++;
              }
 
              col = col + diferx;
              row = row + difery;
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

Console.Write("Введите количество рядов и столбцов массива: ");
int m = Convert.ToInt32(Console.ReadLine());
int [,] matrix = CreateArray(m);
ShowArray(matrix);