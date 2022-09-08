internal partial class Program
{
    private static void Main(string[] args)
    {
        static void Spaces()
        {
            Console.WriteLine();
            Console.WriteLine("=================");
        }
        static void FiveDigitPalindrome()

        {
            Console.WriteLine("Введите пятизначное число: ");
            string a = new(Console.ReadLine());
            int x;
            if (int.TryParse(a, out x) && x > 9999 && x < 100000)
            {
                string b = new(string.Join("", a.Reverse()));
                if (a == b)
                {
                    Console.WriteLine("Да, это палиндром");
                }
                else
                {
                    Console.WriteLine("Нет, это не палиндром!");
                    
                }
            }
            else
            {
                Console.WriteLine("Вы ввели что-то не то!");
            }
        }
        static void StereoDistance()
        {
            double x = 0,
               y = 0,
               z = 0; 
        
        var p1 = new Homework_S3.PointThreeD(x, y, z);
        p1 = p1.Read3DPoint();
        var p2 = new Homework_S3.PointThreeD(x, y, z);
        p2 = p2.Read3DPoint();

        Homework_S3.StereoMeasurment Distance = new Homework_S3.StereoMeasurment();
        var D = Distance.Distance3D(p1, p2);
        Console.WriteLine($"Координаты точки А: X = {p1.X}, Y = {p1.Y}, Z = {p1.Z}");
        Console.WriteLine($"Координаты точки Б: X = {p2.X}, Y = {p2.Y}, Z = {p2.Z}");
        Console.WriteLine($"Расстояние между точками в 3D пространстве = {Math.Round(D, 2)}");
        }
        static void Cube()
        {
            {
            Console.WriteLine("Введите число больше 1: ");
            string a = new(Console.ReadLine());
            int x;
            if (int.TryParse(a, out x) && x > 1)
            {   
                Console.WriteLine("Кубы: ");
                for (int i = 1; i < (x + 1); i++)
                {
                    Console.Write(i * i * i + " ");
                }
            }
            else
            {
                Console.WriteLine("Вы ввели что-то не то!");
            }
        }

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
            Console.WriteLine("Выберите задачу: ");
            Console.WriteLine("1. Задача 19");
            Console.WriteLine("2. Задача 21");
            Console.WriteLine("3. Задача 23");
            Console.WriteLine("Для выхода нажмите Q");
            
            switch (Console.ReadLine().ToLower())
            {
                case "1":
                FiveDigitPalindrome();
                Spaces();
                return Exit();

                case "2":
                StereoDistance();
                Spaces();
                return Exit();

                case "3":
                Cube();
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