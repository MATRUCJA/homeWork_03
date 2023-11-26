//Задайте массив на 10 целых чисел. Напишите программу, которая определяет количество чётных чисел в массиве.

int size = 10;
int[] array = new int[size];

int numberOfSearch = 0;
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(1, 101);
    if (array[i] % 2 == 0)
    {
        numberOfSearch++;
    }
}
Console.WriteLine($"Массив: [{string.Join(", ", array)}]");
Console.WriteLine($"Количество четных элементов массива: {numberOfSearch}");
