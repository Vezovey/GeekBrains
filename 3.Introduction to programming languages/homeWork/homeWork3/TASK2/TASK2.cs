//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.


double LineLenghtAB(int x1, int y1, int z1, int x2, int y2, int z2)
{
    double LineLenghtAB = Math.Sqrt((x2 - x1)*(x2 - x1)+(y2 - y1)*(y2 - y1)+(z2 - z1)*(z2 - z1));
    return LineLenghtAB;
}

Console.WriteLine("Enter X coord A: ");
int xAcoord = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter Y coord A: ");
int yAcoord = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter Z coord A: ");
int zAcoord = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter X coord B: ");
int xBcoord = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter Y coord B: ");
int yBcoord = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter Z coord B: ");
int zBcoord = Convert.ToInt32(Console.ReadLine());

double dist = LineLenghtAB(xAcoord, yAcoord, zAcoord, xBcoord, yBcoord, zBcoord);
Console.WriteLine($"Distance AB is {dist:f3}");