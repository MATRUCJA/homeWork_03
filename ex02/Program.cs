//Задайте массив на 10 целых чисел. Напишите программу, которая определяет количество чётных чисел в массиве.

int size = 10;
int[] array = new int[size];

int countOfSearch = 0;
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next();
    if (array[i] % 2 == 0)
    {
        countOfSearch++;
    }
}
Console.WriteLine($"Массив: [{string.Join(", ", array)}]");
Console.WriteLine($"Количество четных элементов массива: {countOfSearch}");
