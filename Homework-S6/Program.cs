void CountNumsGreaterZero()
{
    Console.WriteLine("Сколько чисел будем вводить? (укажите число)");
    int Size = Convert.ToInt32(Console.ReadLine());
    double [] Array = new double[Size];
    int Counter = 0;
    Console.WriteLine("Вводим числа по одному, каждое на новой строке!");
    for (int i = 0; i < Size; i++)
    {
        Array[i] = Convert.ToDouble(Console.ReadLine());
        if (Array[i] > 0)
        {
            Counter++;
        }
    }
    Console.WriteLine($"Количество чисел больше нуля: {Counter}");
}
CountNumsGreaterZero();