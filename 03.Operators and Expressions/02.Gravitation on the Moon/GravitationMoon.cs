﻿/*The gravitational field of the Moon is approximately 17% of that on the Earth.
Write a program that calculates the weight of a man on the moon by a given weight on the Earth.*/

using System;

class GravitationMoon
{
    static void Main()
    {
        Console.Write("Please enter your weight on Earth: ");
        double weight = double.Parse(Console.ReadLine());
        Console.WriteLine("Your weight on the moon is: {0}", weight*0.17);
    }
}

