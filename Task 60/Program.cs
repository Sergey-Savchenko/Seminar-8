// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

int [,,] CreateArray(int x, int y, int z, int min, int max)
{
    int [,,] array = new int [x,y,z];
    int [] checkarray = new int [x*y*z];
    int count = 0;
    for(int i=0; i<x; i++)
    {
        for(int j=0; j<y; j++)
        {
            Found:
            for(int k=0; k<z; k++)
            {
                array [i,j,k] = new Random().Next(min,max+1);
                for(int check=0; check<x*y*z; check++)
                {
                    if (array[i,j,k] == checkarray[check]){
                        k--;
                        count--;
                        goto Found;
                    }
                }
                checkarray [count] = array [i,j,k];
                count++;
            }
        }
    }
    return array;
}

void ShowArray(int [,,] array)
{
    for(int k=0; k<array.GetLength(2); k++)
    {
        for(int i=0; i<array.GetLength(0); i++)
        {
            for(int j=0; j<array.GetLength(1); j++)
            {
                Console.Write($"{array[i,j,k]}({i},{j},{k}) ");
            }
            Console.WriteLine();
        }
    }
}

int [,,] array = CreateArray(2,2,2,10,100);
ShowArray(array);