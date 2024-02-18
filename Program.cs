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
//третья часть программы
int rand_number = rand.Next(1, 4);
string[] arrNew = new string[rand_number];  
//четвертая часть программы
for(int i = 0; i < arrNew.Length; i++){
    arrNew[i] = arr[i];
}

for (int i = 0; i < arrNew.Length; i++)
{
    Console.Write($"{arrNew[i]} ");
}