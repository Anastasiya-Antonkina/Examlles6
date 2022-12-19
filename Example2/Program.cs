﻿/* Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19

[-4, -6, 89, 6] -> 0 */

Console.Write("Введите размер массива: ");
var str = Console.ReadLine() ?? "";

if (!int.TryParse(str, out var value) || value < 1)
{
    Console.Error.WriteLine($"{str} не является числом или массив меньше одного элемента");
    return;
}

int[] arr = new int[value];
Random rnd = new();
int negSum = 0;

for (int i = 0; i < value; i++)
    arr[i] = rnd.Next(-100, 100);

for (int i=1; i<arr.Length; i+=2)
    negSum += arr[i];

Console.Write("Сумма чисел элементов с нечетными индексами [");
for (int i = 0; i < arr.Length; i++)
    Console.Write(arr[i].ToString() + (i < arr.Length - 1 ? ", " : ""));
Console.Write($"] равна {negSum}.");