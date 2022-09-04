// Задача 60. ...Сформируйте трёхмерный массив 
// из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, 
// добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)


Console.WriteLine($"Введите размер трехмерного массива X x Y x Z:");
Console.WriteLine("Введите X: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите Y: ");
int y = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите Z: ");
int z = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

int[,,] matrix3 = new int[x, y, z];
CreateMatrix3Rnd(matrix3);
PrintMatrix3(matrix3);

void PrintMatrix3(int[,,] matrix3)
{
    for (int i = 0; i < matrix3.GetLength(0); i++)
    {
        for (int j = 0; j < matrix3.GetLength(1); j++)
        {
            for (int k = 0; k < matrix3.GetLength(2); k++)
            {
                Console.Write($"{matrix3[i, j, k]}({i},{j},{k}); ");
            }
            Console.WriteLine();
        }
    }
}


void CreateMatrix3Rnd(int[,,] matrix3)
{
    int[] temp = new int[matrix3.GetLength(0) * matrix3.GetLength(1) * matrix3.GetLength(2)];
    int number;
    for (int i = 0; i < temp.GetLength(0); i++)
    {
        temp[i] = new Random().Next(10, 100);
        if (i >= 1)
        {
            for (int j = 0; j < i; j++) // поиск совпадений
            {
                while (temp[i] == temp[j])
                {
                    temp[i] = new Random().Next(10, 100);
                    j = 0;
                    number = temp[i]; // подходит элемент, берем
                }
                number = temp[i];
            }
        }
    }
    int count = 0;
    for (int x = 0; x < matrix3.GetLength(0); x++)
    {
        for (int y = 0; y < matrix3.GetLength(1); y++)
        {
            for (int z = 0; z < matrix3.GetLength(2); z++)
            {
                matrix3[x, y, z] = temp[count];
                count++;
            }
        }
    }
}