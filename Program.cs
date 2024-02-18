//первая часть программы
using System;

Console.Write("Введите количество элементов массива: ");
int size = Convert.ToInt32(Console.ReadLine());
 Console.WriteLine(" ");
Console.WriteLine("Вводите только числа или латинские символы , с русскими символами ничего не выводиться.");
 Console.WriteLine(" ");

string[] arr = new string[size];
Random rand = new Random();  
//вторая часть программы
for (int i = 0; i < size; i++)
{
    Console.Write($"Вводите элемент номер {i+1}: ");
    arr[i] = Console.ReadLine();
}