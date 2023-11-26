//Задайте массив из вещественных чисел с ненулевой дробной частью. Найдите разницу между максимальным и минимальным элементов массива.

int size = 10;
double[] array = new double[size];
double maxArray = array[0], minArray = array[0], diff;
for (int i = 0; i < array.Length; i++)
{
    array[i] = Math.Round((new Random().NextDouble() * new Random().Next(1001)), 2);
    if (array[i] > maxArray)
    {
        maxArray = array[i];
    }
    if (array[i] < minArray)
    {
        minArray = array[i];
    }
}
diff = maxArray - minArray;
Console.WriteLine($"Массив: [{string.Join("; ", array)}]");
Console.WriteLine($"разница между {maxArray} и {minArray}:  {diff}");

