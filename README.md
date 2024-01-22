# Итоговая контрольная работа по основному блоку

#### Работу подготовил : Студент школы GeekBrains, Куликов Сергей

## 1. Условие задачи:

Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

Примеры:
[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]

[“1234”, “1567”, “-2”, “computer science”] → [“-2”]

[“Russia”, “Denmark”, “Kazan”] → []

## 2. Описание решения

Решение данной задачи с помощью языка C# потбебует от нас написание двух основных методов и нескольких вспомогательных. Далее рассмотрим их подробнее.

### 2.1 Основные методы для решения задачи

#### 2.1.1 Метод **ElementsCount()** принимает на вход строковый массив и возвращает количество элементов, длинна которых меньше или равна 3 символам

Графически работу алгоритма можно представить в виде такой блок схемы:

![Алгоритм метода ElementsCount()](https://github.com/AItemerbek/GeekBrains_FirstBlock_Final/blob/main/ElementsCount.jpg?raw=true)

Код метода ElementsCount():

```C#
int ElementsCount(string[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3) count++;
    }
    return count;
}
```
Итог: данный метод позволяет получить длину нового массива, который содержит только те элементы исходного массива, которые меньше или равны трем символам.

#### 2.1.2 Метод **FillNewArray()** принимает на вход два значения. Первое значение - это количество элементов нового массива, которое мы получаем при помощи метода ElementsCount. Второе значение - это исходный массив, в котором будет проводится поиск. Данный метод возвращает строковый массив из элементов исходного, длина которых менее 3 символов.

Графически работу алгоритма можно представить в виде такой блок схемы:

![Алгоритм метода FillNewArray()](https://github.com/AItemerbek/GeekBrains_FirstBlock_Final/blob/main/FillNewArray.jpg?raw=true)

Код метода FillNewArray():

```C#
string[] FillNewArray(int rows, string[] list)
{
    int count = 0;
    string[] array = new string[rows];
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
```

### 2.2 Вспомогательные методы 

#### 2.2.1 InputNum(). Метод для ввода значений целочисленнных значений, таких как длинна массива.

```C#
int InputNum(string text)
{
    Console.Write(text);
    return int.Parse(Console.ReadLine()!);
}
```
#### 2.2.2 CreateArray(). Метод для создания массива заданного размера.

```C#
string[] CreateArray(int rows)
{
    return new string[rows];
}
```

#### 2.2.3 FillArray(). Метод для ввода значений элементов массива заданной размерности

```C#
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
```

#### 2.2.4 PrintArray(). Метод для печати массива в требуемом формате.

```C#
void PrintArray(string[] arr)
{
    for (int i = 0; i < arr.Length; i++)
        Console.Write($"{arr[i]} ");
    Console.WriteLine();
}
```

## 3. Решение задачи

#### Данные которые использовались для проверки работы программы и результат работы программы:
 - ["q", "qw","qwe", "qwer", "qwert", "qwerty"] -> ["q", "qw", "qwe"]
 - ["1", "12","123", "1234", "12345", "123456"] -> ["1", "12", "123"]
 - ["Russia", "Denmark", "Kazan", "USA", "China", "EU"] -> ["USA","EU"] 