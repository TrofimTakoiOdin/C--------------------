using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Homework_S3;

public class PointThreeD
{
    public double X {get;}
    public double Y {get;}
    public double Z {get;}

    public PointThreeD(double x, double y, double z)
    {
        X = x;
        Y = y;
        Z = z;
    }
    public PointThreeD Read3DPoint()
    {
        Console.Write("Введите координаты x: ");
        var x = Convert.ToDouble(Console.ReadLine());
        Console.Write("Введите координаты y: ");
        var y = Convert.ToDouble(Console.ReadLine());
        Console.Write("Введите координаты z: ");
        var z = Convert.ToDouble(Console.ReadLine());
        return new PointThreeD(x, y, z);
    }
}
