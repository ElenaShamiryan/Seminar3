﻿Console.Write("Введите x1: ");
double x = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите y1: ");
double y = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите z1: ");
double z = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите x2: ");
double xx = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите y2: ");
double yy = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите z2: ");
double zz = Convert.ToDouble(Console.ReadLine()); 

void Distance (double x1, double y1, double z1, double x2, double y2, double z2)
{
double distance=0;
distance = distance + Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));
Console.WriteLine($"Расстояние между двумя точками равно {distance}");
}

Distance(x,y,z,xx,yy,zz);

