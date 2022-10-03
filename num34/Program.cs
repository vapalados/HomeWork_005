//Массив заполненный случайными положительными трёхзначными числами. Программа, которая покажет количество чётных чисел в массиве.
int[] Vvod_massiva()
{
    int[] Massiv = new int[8];
    Random rnd = new Random();
    for (int i = 0; i<8; i++)
    {
        Massiv[i]=rnd.Next(100,999);
    }
    return Massiv;
}
void Vivod_Massiva(int[] mass)
{
    for (int i = 0; i<8; i++)
    {
        Console.Write($" {mass[i]} ");
    }
    Console.WriteLine();
    Console.WriteLine("Нечетных чисел:" + Skolko_nechet(mass));
}
int Skolko_nechet(int[] mass)
{
    int nechet = 0;
    for (int i = 0; i<8; i++)
    {
        if (mass[i] % 2 != 0)
        {
            nechet= nechet + 1;
        }
    }
    return nechet;
}
int [] mas = Vvod_massiva();
Vivod_Massiva(mas);