// 22. Найти расстояние между точками в пространстве 2D/3D
// a (x1,y1,z1)
// b (x2,y2,z2)


void Method2D3D(double x1, double y1, double z1, double x2, double y2, double z2)
{
    double ab3D = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1) + (z2 - z1) * (z2 - z1));
    double ab2D = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));
    Console.Write("Расстояние между точками в 3D = ");
    Console.WriteLine(ab3D);
    Console.Write("Расстояние между точками в 2D = ");
    Console.WriteLine(ab2D);
}
//Задаем координаты для отработки метода x1.y1.z1.x2.y2.z2)
Method2D3D(1, 1, 1, 50, 50, 50);