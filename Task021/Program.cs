double distance(double x1, double y1, double z1, double x2, double y2, double z2)
{
    double dist = Math.Sqrt((x2-x1)*(x2-x1)+(y2-y1)*(y2-y1)+(z2-z1)*(z2-z1));
    return dist;
}
double x1 = 3;
double y1 = 6;
double z1 = 8;
double x2 = 2;
double y2 = 1;
double z2 = -7;

Console.WriteLine($"Расстояние между точками {distance(x1,y1,z1,x2,y2,z2)} условных единиц");