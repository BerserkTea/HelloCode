// 27. Определить количество цифр в числе

Console.WriteLine("Введите число");
var a = Console.ReadLine();
int count = 0;
if (int.TryParse(a, out int number))
{
    for (int i = 0; number > 0; i++)
    {
        number = number / 10;
        count++;
    }
    Console.WriteLine($"Во введенном числе {count} цифр");
}

else
{
    Console.WriteLine("error");
}
