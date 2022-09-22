static void CountNumsGreaterZero()  // Задача 41
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
static void Intersection()  // Задача 43
{
    Console.WriteLine("Данная программа вычисляет точку пересечения двух прямых");
    Console.WriteLine("заданных уравнениями y = k * x + b, y = k1 * x + b1;");
    Console.WriteLine("Введите коэфициент k");
    double k = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите коэфициент k1");
    double k1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите коэфициент b");
    double b = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите коэфициент b1");
    double b1 = Convert.ToInt32(Console.ReadLine());
    Console.Clear();

    if (k != k1 && b != b1)
    {
        double x = (b1 - b) / (k - k1);
        double y = k * x + b;
        Console.WriteLine($"Координаты пересечения прямых: ({x}; {y})");
    }
    else Console.WriteLine("Прямые параллельны или совпадают");
}
static void Spaces()
{
    Console.WriteLine();
    Console.WriteLine("=================");
}
static bool Exit()
{
    Console.WriteLine("Хотите выйти?");
    Console.WriteLine("Введите Y, чтобы выйти");
    Console.WriteLine("Любая другая клавиша, чтобы вернуться в МЕНЮ");
    if (Console.ReadLine().ToLower() == "y")
    {
        return false;  
    }
    else
    {
        return true;
    }
}
static bool MainMenu()  // Менюшка
{
    Console.Clear();
    Console.ForegroundColor = ConsoleColor.DarkCyan;
    Console.WriteLine("Выберите задачу: ");
    Console.WriteLine("1. Задача 41");
    Console.WriteLine("2. Задача 43");
    Console.WriteLine("Для выхода нажмите Q");
    Console.ResetColor();
            
    switch (Console.ReadLine().ToLower())
    {
        case "1":
        CountNumsGreaterZero();
        Spaces();
        return Exit();

        case "2":
        Intersection();
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
  