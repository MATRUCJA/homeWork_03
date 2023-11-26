//Задайте массив из вещественных чисел с ненулевой дробной частью. Найдите разницу между максимальным и минимальным элементов массива.

int size = 10;
double[] array = new double[size];

double diff;

for (int i = 0; i < array.Length; i++)
{
    array[i] = Math.Round((new Random().NextDouble() * new Random().Next(1001)), 2);  
}
double maxArray = array[0]; 
double minArray = array[0]; 

for (int i = 0; i < array.Length; i++)
{
    if (array[i] > maxArray)
    {
        maxArray = array[i];
    }
    if (array[i] < minArray)
    {
        minArray = array[i];
    }
}
diff = Math.Round((maxArray - minArray),2);

Console.WriteLine($"Массив: [{string.Join("; ", array)}]");
Console.WriteLine($"\nразница между максимальным {maxArray} и минимальным {minArray} элементами массива:  {diff}");

