﻿// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.


int InputNum(string text)
{
    Console.Write(text);
    return int.Parse(Console.ReadLine()!);
}

string[] FillArray(int rows)
{
    string[] initialArray = new string[rows];
    for (int i = 0; i < rows; i++)
    {
        Console.Write($"Введите элемент массива №{i}: ");
        initialArray[i] = Console.ReadLine();
    }
    return initialArray;
}

void PrintArray(string[] arr)
{
    for (int i = 0; i < arr.Length; i++)
        Console.Write($"{arr[i]} ");
    Console.WriteLine();
}

string[] FillNewArray(string[] list)
{
    int maxLenght = 3;
    int count = 0;
    string[] array = new string[list.Count(x => x.Length <= maxLenght)];
    for (int i = 0; i < list.Length; i++)
    {
        if (list[i].Length <= 3)
        {
           array[count] = list[i];
           count ++; 
        }
    }
    return array;
}

Console.Clear();
int numberElements = InputNum("Введите количество элементов изначального массива: ");

string[] firstArray = FillArray(numberElements);

Console.WriteLine("Исходный массив:");
PrintArray(firstArray);

string[] secondtArray = FillNewArray( firstArray);

Console.WriteLine("Массив из элентов менее или равный 3 символам: ");
PrintArray(secondtArray);