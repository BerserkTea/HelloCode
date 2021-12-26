// 5. Написать программу вычисления значения функции y = f(a) = (1+1/a)^a
// 
//double x = 5.4;
//double y = 9999;
//y = x*x*(x + x);
//Console.WriteLine(y);

// double method1 (double a)
// {
//     double result = a*a+1;
//     return result;
// }
// double v = method1(9);
// Console.WriteLine("Функция y = f(a) при а = 9 равна ");
// Console.WriteLine(v);

Console.WriteLine("Введите a");
double a = Convert.ToDouble(Console.ReadLine());

if (a==0)
{
   Console.WriteLine("Введено некорректное число"); 
}
else
{
    double y = Math.Pow((1+1/a),a);
    Console.Write(" y = (1+1/a)^a, значение функции будет равно ");
    Console.WriteLine(y);
}