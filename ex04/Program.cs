/*Дано натуральное число в диапазоне от 1 до 100 000. Создайте массив, состоящий из цифр этого числа. 
Старший разряд числа должен располагаться на 0-м индексе массива, младший – на последнем. Размер 
массива должен быть равен количеству цифр.*/


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