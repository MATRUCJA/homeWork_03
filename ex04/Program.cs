/*Дано натуральное число в диапазоне от 1 до 100 000. Создайте массив, состоящий из цифр этого числа. 
Старший разряд числа должен располагаться на 0-м индексе массива, младший – на последнем. Размер 
массива должен быть равен количеству цифр.*/


using System.ComponentModel;

int number=new Random().Next(1,100001);
int inputNumber=number;
int size=0;


while (number>0)
{
    number/=10;
    size++;
}

int[] array = new int[size];
Console.WriteLine($"Размер массива: {size}");
Console.WriteLine($"Исходное число: {inputNumber}");
for (int i=array.Length-1; i>=0; i--)
{
    array[i]=inputNumber%10;
    inputNumber/=10;
}

Console.WriteLine($"Массив: [{string.Join(", ", array)}]");