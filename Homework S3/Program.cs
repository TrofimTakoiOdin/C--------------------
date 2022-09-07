internal partial class Program
{
    private static void Main(string[] args)
    {
        void FiveDigitPalindrome()

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
        
         
        double x = 0,
               y = 0,
               z = 0; 
        
        var p1 = new Homework_S3.PointThreeD(x, y, z);
        p1 = p1.Read3DPoint();
        var p2 = new Homework_S3.PointThreeD(x, y, z);
        p2 = p2.Read3DPoint();

        Homework_S3.StereoMeasurment Distance = new Homework_S3.StereoMeasurment();
        var D = Distance.Distance3D(p1, p2);
        Console.WriteLine(p1.X + " " + p1.Y + " " + p1.Z);
        Console.WriteLine(p2.X + " " + p2.Y + " " + p2.Z);
        Console.WriteLine(Math.Round(D, 2));
        

        
    
        
        

    }
    
}