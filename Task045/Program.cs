//45. Показать числа Фибоначчи
//   Console.Write("Введите конец диапазона от 1 до : ");
//   int end=int.Parse(Console.ReadLine());
//   int j=1;
//   for(int i=1; i<=end; i+=j) {
//    Console.Write("{0} ", i);
//    j=i-j;
//   }
//   Console.ReadKey();
//   return 0;

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int firstNumber = 0;
int secondNumber = 1;
int fibonacciPositiv = 0;

if (number > 0)
{
    fibonacciPositiv = secondNumber; //для положительных чисел 
    Console.Write($"Ряд Фибоначчи для {number}:  ");
    for (int i = 0; i < number; i++)
    {
        Console.Write("{0}  ", fibonacciPositiv);
        fibonacciPositiv = firstNumber + secondNumber;
        firstNumber = secondNumber;
        secondNumber = fibonacciPositiv;
    }
}

if (number < 0)
{
    fibonacciPositiv = secondNumber; //для положительных чисел 
    Console.Write($"Ряд Фибоначчи для {number}:  ");
    for (int i = 0; i < number * (-1); i++)
    {
        Console.Write("{0} ", fibonacciPositiv);
        fibonacciPositiv = ((secondNumber-firstNumber) * (-1));
        firstNumber = secondNumber;
        secondNumber = fibonacciPositiv;
    }
}