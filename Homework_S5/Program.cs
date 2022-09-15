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
static void MaxMinDifference()
{
    const int Size = 15;
    Random rnd = new Random();
    double [] DoubleArray = new double[Size];
    int i;
    Console.BackgroundColor = ConsoleColor.White; 
    Console.ForegroundColor = ConsoleColor.Red; 
    Console.WriteLine("Массив вещественных чисел: ");

    for (i = 0; i < Size; i++)
    {
        DoubleArray[i] = rnd.Next(-100, 101);
        Console.Write(DoubleArray[i] + " ");
    }
    Console.ResetColor();

    var Max = DoubleArray[MaxIndex(DoubleArray)];
    var Min = DoubleArray[MinIndex(DoubleArray)];
    var Difference = Max - Min;
 
    Console.WriteLine();
    Console.BackgroundColor = ConsoleColor.White; 
    Console.ForegroundColor = ConsoleColor.DarkBlue; 
    Console.WriteLine($"Максимальное число в массиве: {Max}");
    Console.WriteLine();
    Console.WriteLine($"Минимальное число в массиве: {Min}");
    Console.ResetColor();
    Console.WriteLine();
    Console.WriteLine("Искомая разность: ");
    Console.WriteLine($"{Max} — {Min} = {Difference}");
}
static int MinIndex(double[] Array)
{
    int MinInd = 0;
    for (int i = 1; i < Array.Length; i++)
    {
        if (Array[i] < Array[i - 1])
        {
            MinInd = i;
        }
    }
    return MinInd;
}
static int MaxIndex(double[] Array)
{
    int MaxInd = 0;
    for (int i = 1; i < Array.Length; i++)
    {
        if (Array[i] > Array[i - 1])
        {
            MaxInd = i;
        }
    }
    return MaxInd;
}
MaxMinDifference();