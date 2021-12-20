// 4. Найти максимальное из трех чисел
int a = 65;
int b = 99;
int c = 9;
int max = a;
if (max < b)
{
    max = b;
}
if (max < c)
{
    max = c;
}
Console.Write("Максимальное число ");
Console.WriteLine(max);