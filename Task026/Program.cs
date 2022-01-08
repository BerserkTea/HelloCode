// 26. Возведите число А в натуральную степень B используя цикл

Console.WriteLine("Введите число ");
double NumberA = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите степень для возведения числа ");
int degreeB = Convert.ToInt32(Console.ReadLine());
double degree = 1;
if (NumberA == 0)
{
    Console.WriteLine(0);
}
else if (degreeB == 0)
{
    Console.WriteLine(1);
}
else
{
    for (int i = 1; i <= degreeB; i++)
    {
        degree = degree*NumberA;
    }
    Console.WriteLine(degree);
}

