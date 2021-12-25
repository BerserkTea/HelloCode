// Показать последнюю цифру трёхзначного числа
// Console.WriteLine("Hello, World!");

// var x = 431;

// string y = Convert.ToString(x);

// if (y.Length>3)
// {
//     Console.WriteLine("длинна превышена");
// }
// else
// {
//     Console.WriteLine(y[2]);
// }
// Показать последнюю цифру трёхзначного числа

Console.WriteLine("Введите число");
int a = Convert.ToInt32(Console.ReadLine());

if (99 < a && a < 1000)
{
   int result = a % 10; 
Console.WriteLine(result);
}
else
{
    Console.WriteLine("Ошибка");
}

