﻿using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.PupovAA.Sprint1.Task3.V3.Lib
{
    public class DataService : ISprint1Task3V3
    {
        public double ParallelepipedVolume(double length, double width, double height)
        {
            double r = length * width * height;
            return Math.Round(r, 3);
        }
    }
}
