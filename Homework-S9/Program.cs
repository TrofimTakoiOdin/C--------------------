internal class Program
{
    private static void Main(string[] args)
    {
        bool ShowMenu = true;
        while (ShowMenu)
        {
            ShowMenu = MainMenu();
        }     
    }    
    static bool MainMenu()
    {
        Console.Clear(); 
        Console.ForegroundColor = ConsoleColor.DarkBlue;
        Console.WriteLine("Выберите задачу: ");
        Console.WriteLine("1. Задача 64");
        Console.WriteLine("2. Задача 66");
        Console.WriteLine("3. Задача 68");
        Console.WriteLine("Для выхода нажмите Q");
        Console.ResetColor();
            
        switch (Console.ReadLine().ToLower())
        {
            case "1":
            Console.Clear();
            Console.WriteLine("Программа с помощью рекурсии выводит все натуральные числа от N до 1");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            FromNtoOne(ParseInput(EnterAndSplitString())[0]);
            Console.ResetColor();
            Spaces();
            return Exit();

            case "2":
            Console.Clear();
            Console.WriteLine("Программа находит сумму натуральных чисел в промежутке от A до B");
            Console.WriteLine();
            
            int[] numbers = ParseInput(EnterAndSplitString());
            int a = 0, b = 0;
            if (numbers[0] < numbers[1]) { a = numbers[0]; b = numbers[1]; }
            else { a = numbers[1]; b = numbers[0]; }
            Console.WriteLine();
            Console.Write("Искомый результат: ");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine(BetweenNumsSum(a, b));
            Console.ResetColor();
            Spaces();
            return Exit();

            case "3":
            Console.Clear();
            Console.WriteLine("Функция Аккермана. Осторожнее с ней :)");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("Не вводите большие значения аргуметов");
            Console.WriteLine("Например значение Accerman(4, 4) больше числа атомов во вселенной!");
            Console.ResetColor();
            Console.WriteLine();
            Console.WriteLine("Введите значение первого коэфициента");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите значение второго коэфициента");
            b = Convert.ToInt32(Console.ReadLine());
            int akk = Akkerman(a, b);
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine($"Искомое значение: {akk}");
            Console.ResetColor();
            Spaces();
            
            return Exit();

            case "q":
            return false;

            default:
            return true;
        }
    }
    
    static void Spaces()
    {
        Console.WriteLine("=================");
    }
    static bool Exit()
    {
        Console.WriteLine("Хотите выйти?");
        Console.WriteLine("Введите Y, чтобы выйти");
        Console.WriteLine("Любая другая клавиша, чтобы вернуться в МЕНЮ");
        if (Console.ReadLine().ToLower() == "y") return false;  
        else return true;
    }
    static string[] EnterAndSplitString()
    {
        Console.Write("Введите одно или несколько чисел через пробел, запятую или / : ");
        return Console.ReadLine()!.Split(' ', ',', '/');
    }
    static int[] ParseInput(string[] nums)
    {
        int[] integerNums = new int[nums.Length];
        for (int i = 0; i < nums.Length; i++)
        {
            integerNums[i] = int.Parse(nums[i])!;
        }
        return integerNums;
    }
    static void FromNtoOne(int num)
    {
        if (num > 0)
        {
            Console.Write($"{num} ");
            FromNtoOne(num - 1);
        }
        else
        {
            Console.WriteLine();
            return;
        }
    }
    static int BetweenNumsSum(int a, int b)
    {
        int total = 0;
        if (a == b)
        {
            return a;
        }
        total += b;
        return BetweenNumsSum(a, b - 1) + total;

    }
    static int Akkerman(int x, int y)
    {
        if (x == 0) return y + 1;
        else if (x > 0 && y == 0) return Akkerman(x - 1, 1);
        return Akkerman(x - 1, Akkerman(x, y - 1));
    }
    
}