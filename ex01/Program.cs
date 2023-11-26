//Задайте одномерный массив из 10 целых чисел от 1 до 100. 
//Найдите количество элементов массива, значения которых лежат в отрезке [20,90].

int size = 10;
int[] array = new int[size];

int numberOfSearch = 0;
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(1, 101);
    if (array[i] >= 20 && array[i] <= 90)
    {
        numberOfSearch++;
    }
}
Console.WriteLine($"Массив: [{string.Join(", ", array)}]");
Console.WriteLine($"количество элементов из заданного отрезка: {numberOfSearch}");
