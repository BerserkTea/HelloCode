// 13. Выяснить, кратно ли число заданному, если нет, вывести остаток.
// double a = 6;
// double b = 64;

// if (b%a==0)
// {
//     Console.WriteLine("Число b кратно числу a");
// }
// else
// {
//     double x=b%a;
//     Console.Write("Число b не кратно числу a, и остаток составляет ");
//     Console.WriteLine(x);
// }
// Выяснить, кратно ли число заданному, если нет, вывести остаток.

Console.WriteLine("Введите число1");
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число2");
int A = Convert.ToInt32(Console.ReadLine());
int result = N % A;
if (result != 0)
{
    Console.WriteLine(result);
}
else
{
    Console.WriteLine("Кратно");
}
