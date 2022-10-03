//Одномерный массив, заполненный случайными числами. Показывающий сумму элементов, стоящих на нечётных позициях.
int[] Vvod_massiva()
{
    int[] Massiv = new int[8];
    Random rnd = new Random();
    for (int i = 0; i<8; i++)
    {
        Massiv[i]=rnd.Next(-100,100);
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
    Console.WriteLine("Сумма чисел на нечетных позициях:" + Summa_nechetnih(mass));
}
int Summa_nechetnih(int[] mass)
{
    int nechet_index = 0;
    for (int i = 0; i<8; i++)
    {
        if (i % 2 != 0)
        {
            nechet_index = nechet_index + mass[i];
        }
    }
    return nechet_index;
}
int [] mas = Vvod_massiva();
Vivod_Massiva(mas);