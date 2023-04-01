// Задача 2: Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных индексах.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int size = Input("Введите размерность массива: ");
int[] mas = FillArray(size, -100, 100);
Console.WriteLine($"[{String.Join(";", mas)}] -> {SumEven(mas)}");

//------метод: заполнение массива-----
int[] FillArray(int size, int min, int max)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(min, max);
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

//------метод: сумма элементов, стоящих на нечётных индексах---
int SumEven(int[] array)
{
    int sum=0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 != 0)
        {
            sum += array[i];
        }
    }
    return sum;
}