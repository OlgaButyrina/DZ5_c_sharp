// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и 
// минимальным элементов массива.
// [3 7 22 2 78] -> 76

double[] GenerateArray(int size, int leftRange, int rightRange)
{
    double[] array = new double[size];
    var rand = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rand.Next(leftRange, rightRange + 1);
    }
    return array;
}

void PrintArray(double[] array)
{
    System.Console.WriteLine("[" + string.Join(", ", array) + "]");
}

double DiffMinMax(double[] array)
{
    double diff = 0;
    double max = 0;
    double min = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max) max = array[i];
    }
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < min) min = array[i];
    }
    if (min < 0) min = min * -1;
    diff = max - min;
    return diff;
}

double[] myArray = GenerateArray(5, -10, 10);
PrintArray(myArray);
System.Console.WriteLine("Разница между максимальным и минимальным элементом массива = " + DiffMinMax(myArray));

