// Задача 1: Задайте массив заполненный случайными положительными
//трёхзначными числами. Напишите программу, которая покажет количество
//чётных чисел в массиве.
//[345, 897, 568, 234] -> 2

int size = Input("Введите размерность массива: ");
int[] mas = FillArray(size, 100, 1000);
Console.WriteLine($"[{String.Join(";", mas)}] -> {CountEven(mas)}");

//------метод: заполнение массива-----
int[] FillArray(int size, int min, int max)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(min,max);
    }
    return array;
}

//------метод: приглашение ко вводу числа------
int Input(string text)
{
    Console.Write(text);
    int num = int.Parse(Console.ReadLine()!);
    return num;
}

//------метод: подсчет четных чисел в массиве----
int CountEven(int[] array)
{
    int count = 0;
    foreach (int el in array)
    {
        if (el %2 ==0) count++;
    }
    return count;
}