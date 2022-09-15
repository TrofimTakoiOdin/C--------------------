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
    
}
