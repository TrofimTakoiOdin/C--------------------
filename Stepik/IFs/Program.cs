using System;

public class MainClass
{
    public static void Main()
    {   
        string line = Console.ReadLine();
        string[] splitString = line.Split(' ');
        int[] numbers = new int[3];
        numbers = splitString.Select(x => int.Parse(x)).ToArray();
        int minn = numbers.Min();
        Console.WriteLine(minn);
    }
}