// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

void ImputArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100, 1000);
    }
}

int SummEven(int[] array)
{
    int summ = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
            summ += 1;
    }
    return summ;
}

Console.Clear();
int[] array = new int[10];
ImputArray(array);
Console.WriteLine($"Массив: [{string.Join(", ", array)}]");
SummEven(array);
Console.WriteLine($"Количество четных чисел в массиве: [{SummEven(array)}]");


// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

void ImputArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 100);
    }
}

int SummElement(int[] array)
{
    int summ = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 != 0)
            summ = summ + array[i];
    }
    return summ;
}

Console.Clear();

int[] array = new int[10];

ImputArray(array);
Console.WriteLine($"Массив: [{string.Join(", ", array)}]");
SummElement(array);
Console.WriteLine($"Сумма элементов: [{SummElement(array)}]");


// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// Внутренние функции использовать нельзя(Max и Min)
// [3 7 22 2 78] -> 76 


void ImputArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Math.Round(new Random().NextDouble() * 10, 2);
    }
}

double DifferenceArray(double[] array)
{
    double Max = array[0];
    double Min = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (Max < array[i])
        {
            Max = array[i];
        }
        else if (Min > array[i])
        {
            Min = array[i];
        }
        
    }
return Max - Min;

}

Console.Clear();
double[] array = new double[5];
ImputArray(array);
Console.WriteLine($"Массив: [{string.Join(" , ", array)}]");
DifferenceArray(array);
Console.WriteLine($"Разница между максимальным и минимальным значением: [{DifferenceArray(array)}]");