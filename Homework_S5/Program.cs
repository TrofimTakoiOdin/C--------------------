static void HowManyEvens()
{   const int Size = 8;
    int EvenCounter = 0;
    int[] ThreeDigitNums = new int[Size];
    for (int i = 0; i < Size; i++)
    {
        ThreeDigitNums[i] = new Random().Next(100, 1000);
        if (ThreeDigitNums[i] % 2 == 0)
        {
            EvenCounter += 1;
        }
    }
    Console.WriteLine($"Количество четных трехзначных чисел в массиве из 8 случайных трехзначных чисел: {EvenCounter}");
}
static void UnevenIndexSum()
{
    const int Size = 10;
    Random rnd = new Random();
    int UnevenPosCounter = 0;
    int [] RandomNumbers = new int[Size];
    int i;
    Console.WriteLine("Массив случайных чисел: ");
    for (i = 0; i < Size; i++)
    {
        RandomNumbers[i] = rnd.Next(-100, 101);
        Console.Write(RandomNumbers[i] + " ");
    }
    Console.WriteLine();
    for (i = 1; i < RandomNumbers.Length; i += 2)
    {
        UnevenPosCounter += RandomNumbers[i];
    }
    Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях: {UnevenPosCounter}");
}
UnevenIndexSum();