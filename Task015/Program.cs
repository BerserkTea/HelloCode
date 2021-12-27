// 15. Дано число. Проверить кратно ли оно 7 и 23

Console.WriteLine("15. Дано число. Проверить кратно ли оно 7 и 23");
Console.WriteLine("Введите число");
int A = Convert.ToInt32(Console.ReadLine());
if (A % 7 == 0 && A % 23 == 0)
{
    Console.WriteLine("Введенное число кратно 7 и 23");
}
else if (A % 7 != 0 && A % 23 == 0)
{
    Console.WriteLine("Введенное число не кратно 7, но кратно 23");
}
else if (A % 7 == 0 && A % 23 != 0)
{
    Console.WriteLine("Введенное число не кратно 23, но кратно 7");
}
else
{
    Console.WriteLine("Введенное число не кратно 7 и 23");
}