//29. Написать программу вычисления произведения чисел от 1 до N
// можно через факториал, а можно и через массив.
Console.WriteLine("Введите число N для вычисления произведения числе от 1 до N");
int N = Convert.ToInt32(Console.ReadLine());
int result = 1;
if (N > 0)
{
    for (int i = 1; i <= N; i++)
    {
        result = result * i;
    }
    Console.WriteLine(result);
}
else
{
    Console.WriteLine("Введите корректное число");
}
