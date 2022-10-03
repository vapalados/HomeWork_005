//Массив вещественных чисел. Показывающий разницу между максимальным и минимальным элементов массива.

double[] Vvod_massiva()
{
    double[] Massiv = new double[8];
    Random rnd = new Random();
    for (int i = 0; i<8; i++)
    {
        Massiv[i]=rnd.Next(1,100);
    }
    return Massiv;
}

void PrintArray(double [] array)
{
    int count = array.Length;

    for (int i = 0; i < count; i++)
    {
        Console.Write($" {array[i]} ");
    }
    Console.WriteLine();
}

void MaxMin(double[] massiv)
{
    double min = massiv[0];
    double max = massiv[0];
    for (int i = 0; i < massiv.Length; i++)
    {
        if (massiv[i]<min)
        {
            min = massiv[i];
        }
        if (massiv[i]>max)
        {
            max = massiv[i];
        }
    }
    double result = max - min;
    Console.WriteLine("Максимальное: " + max);
    Console.WriteLine("Минимальное: " + min);
    Console.WriteLine("Разница: " + result);
}

double[] arr = Vvod_massiva();
PrintArray(arr);
MaxMin(arr);
