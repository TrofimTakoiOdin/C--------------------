using System;

public class MainClass
{
    public static void Main()
    {
        string line = Console.ReadLine(); // ввод числа в десятеричной системе 

        int x = int.Parse(line);

        string answer = Convert.ToString(x, 16);
        

        Console.WriteLine(answer);
    }
}