using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Homework_S3;

public class StereoMeasurment
{
    public double Distance3D(PointThreeD p1, PointThreeD p2)
    {
        return Math.Sqrt((p1.X - p2.X) * (p1.X - p2.X) 
                         + (p1.Y - p2.Y) * (p1.Y - p2.Y) 
                         + (p1.Z - p2.Z) * (p1.Z - p2.Z));
    }
}
