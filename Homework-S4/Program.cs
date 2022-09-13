internal class Program
{
    private static void Main(string[] args)
    {
        static void AinPowerB()  // Задача 25. 
        {   Console.WriteLine("Цикл принимает на вход два числа (A и B)");
            Console.WriteLine("и возводит число A в натуральную степень B");
            Console.WriteLine();
            Console.WriteLine("Введите число 'a': ");
            string a = new(Console.ReadLine());
            Console.WriteLine("Введите число 'b': ");
            string b = new(Console.ReadLine());
            int c = 1;
            int x, y;
            if (int.TryParse(a, out x) && int.TryParse(b, out y) && x > 0 && y >= 0)
            {

                for (int i = 1; i < y + 1; i++)
                {
                    c *= x;
                }
                Console.Write($"{a}^{b} = ");
                Console.Write(c);
            }
            else
            {
                Console.WriteLine("Вы ввели что-то не то!");
            }
        }
        static void DigitSum()  // Задача 27. 
        {
            Console.WriteLine("Программа принимает на вход число и выдаёт сумму цифр в числе");
            Console.WriteLine();
            Console.WriteLine("Введите число, сумму цифр которого вы хотите найти: ");
            string a = new(Console.ReadLine());
            string b = a;
            int x, Counter;
            if (int.TryParse(a, out x) && x >= 0)
            {
                Counter = 0;
                for (int i = 0; i < b.Length; i++)
                {
                    
                    Counter = Counter + (int)char.GetNumericValue(b[i]);
                }
                Console.WriteLine($"Сумма цифр введенного числа: {Counter}");

            }
            else
            {
                Console.WriteLine("Вы ввели что-то не то!");
            }
        }
        static void MakeAndPrintArray() // Задача 29.
        {
            Console.WriteLine("Пользователь вводит 8 чисел. Далее они помещаются в массив и распечатываются");
            Console.WriteLine();
            int[] Array = new int[8];
            Console.WriteLine("Введите 8 чисел, каждое на отдельной строке: ");
            for (int i = 0; i < 8; i++)
            {
                Array[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine();
            Console.WriteLine("Список: ");
            for (int j = 0; j < 8; j++)
            {
                Console.Write(Array[j] + " ");
            }
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
        static void Spaces()
        {
            Console.WriteLine();
            Console.WriteLine("=================");
        }
        static bool MainMenu()
        {
            Console.Clear();
            Console.WriteLine("Выберите задачу: ");
            Console.WriteLine("1. Задача 25");
            Console.WriteLine("2. Задача 27");
            Console.WriteLine("3. Задача 29");
            Console.WriteLine("Для выхода нажмите Q");
            
            switch (Console.ReadLine().ToLower())
            {
                case "1":
                AinPowerB();
                Spaces();
                return Exit();

                case "2":
                DigitSum();
                Spaces();
                return Exit();

                case "3":
                MakeAndPrintArray();
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
    }
}