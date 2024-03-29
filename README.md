# Итоговая контрольная работа по основному блоку

#### Работу подготовил : Студент школы GeekBrains, Куликов Сергей

## 1. Условие задачи:

Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

Примеры:
[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]

[“1234”, “1567”, “-2”, “computer science”] → [“-2”]

[“Russia”, “Denmark”, “Kazan”] → []

## 2. Описание решения

Решение данной задачи с помощью языка C# потребует от нас написание основного метода и нескольких вспомогательных. Далее рассмотрим их подробнее.

### 2.1 Метод **FillNewArray()** принимает на вход исходный массив и выдает на выходе массив, состоящий только из элементов, длина символов которых меньше или ровна 3

Графически работу алгоритма можно представить в виде такой блок схемы:

![Алгоритм метода FillNewArray()](https://github.com/AItemerbek/GeekBrains_FirstBlock_Final/blob/main/FillNewArray.jpg?raw=true)

Код метода FillNewArray():

```C#
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
```
Итог: Для вычисления длины нового массива используем встроенную функцию .Count(), с помощью которой определяем количество элементов исходно массива, длина которых меньше либо равна 3 символам. Далее при помощи цикла for() наполняем новый массив элементами, согласно условию задачи.

### 2.2 Вспомогательные методы 

#### 2.2.1 InputNum(). Метод для ввода целочисленнных значений, таких как длинна исходного массива.

```C#
int InputNum(string text)
{
    Console.Write(text);
    return int.Parse(Console.ReadLine()!);
}
```
#### 2.2.2 FillArray(). Метод для ввода значений элементов массива заданной размерности

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

#### 2.2.3 PrintArray(). Метод для печати массива.

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
 - ["Russia", "Denmark", "Kazan", "USA", "China", "EU"] -> ["USA", "EU"] 