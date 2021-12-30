// 17. По двум заданным числам проверять является ли одно квадратом другого

Console.WriteLine("Введите число 1 ");
int firstNumber = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число 2");
int secondNumber = Convert.ToInt32(Console.ReadLine());

int sqrFirstNumber = firstNumber * firstNumber;
int sqrSecondNumber = secondNumber * secondNumber;

if (sqrFirstNumber == secondNumber)
{
    Console.WriteLine($"Число {secondNumber} является квадратом числа {firstNumber}");
}
else if (sqrSecondNumber == firstNumber)
{
    Console.WriteLine($"Число {firstNumber} является квадратом числа {secondNumber}");
}
else
{
    Console.WriteLine ("Числа не являются квадратом друг друга");
}
//смотри 1 задачу