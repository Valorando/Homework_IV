/*Допустим, у вас есть массив чисел размером N, где N больше 1000000. Вам необходимо написать программу на C#, которая будет выполнять следующие действия:

Отсортировать массив по возрастанию.
Удалить из массива все числа, которые являются палиндромами (то есть числа, которые читаются одинаково как слева направо, так и справа налево).
Найти сумму элементов массива, которые делятся на 3 без остатка.
Найти наименьшее и наибольшее число в массиве.
Найти среднее арифметическое всех элементов массива.*/

using Microsoft.VisualBasic.FileIO;
using System.Linq;

Console.WriteLine("Обычный массив: ");
int[] arr = new int[20] { 2788682, 2497797, 2297698, 2429414, 2234566, 2514146, 2620696, 2762711, 2108945, 2033769, 2492837, 2396172, 2700385, 2158190, 2366765, 2465199, 2392457, 2387110, 2557713, 2671968 };

for (int i = 0; i < arr.Length; i++)
{
    Console.WriteLine(arr[i]);
}

Console.WriteLine();
Console.WriteLine();

void Sort()
{
    Console.WriteLine("Отсортированый в порядке возрастания массив: ");
    int temp;
    for (int i = 0; i < arr.Length - 1; i++)
    {
        for (int j = i + 1; j < arr.Length; j++)
        {
            if (arr[i] > arr[j])
            {
                temp = arr[i];
                arr[i] = arr[j];
                arr[j] = temp;
            }
        }
    }

    for (int i = 0; i < arr.Length; i++)
    {
        Console.WriteLine(arr[i]);
    }
}

Sort();

Console.WriteLine();
Console.WriteLine();
void Palindrome()
{
    
}

Palindrome();

Console.WriteLine();
Console.WriteLine();
void Summ()
{
    int sum = 0;
    for (int i = 0; i < arr.Length; ++i)
    {
        if (arr[i] % 3 == 0)
        {
            sum += arr[i];
            
        }
    }
    Console.WriteLine($"Сумма чисел которые делятся на 3 без остатка: {sum}");
}

Summ();

Console.WriteLine();
Console.WriteLine();

void MinMax()
{
    int Min;
    Min = arr.Min();
    int Max;
    Max = arr.Max();
    Console.WriteLine($"Максимальный элемент: {Min}  Минимальный элемент: {Max}");
}

MinMax();

Console.WriteLine();
Console.WriteLine();
void AVG()
{
    int avg;
    avg = (int)arr.Average();
    Console.WriteLine($"Cреднее арифметическое: {avg}");
}

AVG();
