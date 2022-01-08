// 28. Подсчитать сумму цифр в числе
Console.WriteLine("Введите число");
var a = Console.ReadLine();
int count = 0;
if (int.TryParse(a, out int number))
{
    int[] arrayNumbers = new int[a.Length];
    int leng = a.Length;
    int summ = 0;
    for (int i = 0; i < a.Length; i++)
    {
        arrayNumbers[leng - 1] = number % 10;
        number = number / 10;
        summ = summ + arrayNumbers[leng - 1];
        --leng;
    }
    Console.WriteLine($"Сумма цифр в числе равна {summ}");
}

else
{
    Console.WriteLine("error");
}

