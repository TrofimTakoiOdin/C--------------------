static void HowManyEvens() // Задача 34
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
    Console.ForegroundColor = ConsoleColor.DarkGreen;
    Console.WriteLine("Задан массив заполненный случайными положительными трёхзначными числами"); 
    Console.WriteLine("Программа показывает количество чётных чисел в массиве.");
    Console.WriteLine();
    Console.ResetColor(); 
    Console.ForegroundColor = ConsoleColor.DarkBlue;
    Console.WriteLine($"Количество четных трехзначных чисел в массиве из 8 случайных трехзначных чисел: {EvenCounter}");
    Console.ResetColor();
}
static void UnevenIndexSum() // Задача 36
{
    const int Size = 10;
    Random rnd = new Random();
    int UnevenPosCounter = 0;
    int [] RandomNumbers = new int[Size];
    int i;
    Console.WriteLine("Задан одномерный массив, заполненный случайными числами: ");
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
    Console.ForegroundColor = ConsoleColor.DarkGreen;
    
    Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях: {UnevenPosCounter}");
    Console.ResetColor();
}
static void MaxMinDifference() // Задача 38
{
    const int Size = 15;
    Random rnd = new Random();
    double [] DoubleArray = new double[Size];
    int i; 
    Console.ForegroundColor = ConsoleColor.DarkGreen; 
    Console.WriteLine("Массив вещественных чисел: ");
    Console.WriteLine();

    for (i = 0; i < Size; i++)
    {
        DoubleArray[i] = rnd.Next(-100, 101) + rnd.NextDouble();
        Console.Write(DoubleArray[i] + " ");
    }
    Console.ResetColor();

    var Max = DoubleArray[MaxIndex(DoubleArray)];
    var Min = DoubleArray[MinIndex(DoubleArray)];
    var Difference = Max - Min;
 
    Console.WriteLine(); 
    Console.ForegroundColor = ConsoleColor.DarkBlue;
    Console.WriteLine(); 
    Console.WriteLine($"Максимальное число в массиве: {Max}");
    Console.WriteLine($"Минимальное число в массиве: {Min}");
    Console.ResetColor();
    Console.WriteLine(); 
    Console.ForegroundColor = ConsoleColor.DarkMagenta;
    Console.WriteLine("Искомая разность: ");
    Console.WriteLine($"{Max} — {Min} = {Difference}");
    Console.ResetColor();
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
static void Spaces()
{
    Console.WriteLine("=================");
}
static bool Exit()
{
    Console.WriteLine("Хотите выйти?");
    Console.WriteLine("Введите Y, чтобы выйти");
    Console.WriteLine("Любая другая клавиша, чтобы остаться");
    if (Console.ReadLine().ToLower() == "y")
    {
        return false;  
    }
    else
    {
        return true;
    }
}
static bool MainMenu()
{
    Console.Clear();
    Console.BackgroundColor = ConsoleColor.Black; 
    Console.ForegroundColor = ConsoleColor.DarkBlue;
    Console.WriteLine("Выберите задачу: ");
    Console.WriteLine("1. Задача 34");
    Console.WriteLine("2. Задача 36");
    Console.WriteLine("3. Задача 38");
    Console.WriteLine("Для выхода нажмите Q");
    Console.ResetColor();
            
    switch (Console.ReadLine().ToLower())
    {
        case "1":
        HowManyEvens();
        Spaces();
        return Exit();

        case "2":
        UnevenIndexSum();
        Spaces();
        return Exit();

        case "3":
        MaxMinDifference();
        Spaces();
        return Exit();

        case "q":
        return false;

        default:
        return true;
    }
}

bool ShowMenu = true;
while (ShowMenu)
{
    ShowMenu = MainMenu();
}       
  