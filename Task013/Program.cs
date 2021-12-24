// 13. Выяснить, кратно ли число заданному, если нет, вывести остаток.
double a = 6;
double b = 64;

if (b%a==0)
{
    Console.WriteLine("Число b кратно числу a");
}
else
{
    double x=b%a;
    Console.Write("Число b не кратно числу a, и остаток составляет ");
    Console.WriteLine(x);
}
