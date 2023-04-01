// Задача 3: Задайте массив вещественных чисел. Найдите разницу между максимальным
//и минимальным элементов массива.
//[3, 7.4, 22.3, 2, 78] -> 76

int size = Input("Введите размерность массива: ");
double[] mas = FillArray(size, -100, 100);
Console.WriteLine($"[{String.Join(";  ", mas)}] -> {Sum(mas)}");

//------метод: приглашение ко вводу числа------
int Input(string text)
{
    Console.Write(text);
    int num = int.Parse(Console.ReadLine()!);
    return num;
}

//------метод: заполнение массива-----
double[] FillArray(int size, int min, int max)
{
    double[] array = new double[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = Math.Round(new Random().Next(min, max)+ new Random().NextDouble(),2);
    }
    return array;
}
//-------метод: сумма максимального и минимального-----
double Sum(double[] array)
{
    double min = array[0];
    double max = array[0];
    foreach (double el in array)
    {
        if (el < min) min = el;
        if (el > max) max = el;
    }
    return Math.Round(max-min, 2);
}