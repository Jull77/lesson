// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

Console.WriteLine("Введите целые числа через запятую: ");
int[] arr = StringToNum(Console.ReadLine());
PrintArray(arr); 
int res = 0; 

for (int i = 0; i < arr.Length; i++)
{
    if (arr[i] > 0)
    {
        res++;
    }
}
Console.WriteLine();
Console.WriteLine($"Количество чисел больше 0 => {res}");

int[] StringToNum(string input)
{
    int count = 1;
    for (int i = 0; i < input.Length; i++)
    {
        if (input[i] == ',')
        {
            count++;
        }
    }

    int[] arr = new int [count];
    int index = 0;

    for (int i = 0; i < input.Length; i++)
    {
        string temp = "";

        while (input [i] != ',')
        {
        if(i != input.Length - 1)
        {
            temp += input [i].ToString();
            i++;
        }
        else
        {
            temp += input [i].ToString();
            break;
        }
        }
        arr[index] = Convert.ToInt32(temp);
        index++;
    }
    return arr;
}


void PrintArray(int[] arr)
{
    Console.Write("Введенные числа: [ ");
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + " ");
    }
    Console.Write("]");
}

