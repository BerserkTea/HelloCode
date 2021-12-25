// Показать вторую цифру трёхзначного числа
// Console.WriteLine("Hello, World!");

// var x = 316564;

// string stringNumber = Convert.ToString(x);
// if (stringNumber.Length>3)
// {
//     Console.WriteLine("длинна превышена");
// }
// else
// {
//     Console.WriteLine(stringNumber[1]);
// }
// Показать вторую цифру трёхзначного числа

Console.WriteLine("Введите число");
int a = Convert.ToInt32(Console.ReadLine());

if (99 < a && a < 1000)
{
   int result = (a % 100)/10; 
Console.WriteLine(result);
}
else
{
    Console.WriteLine("Ошибка");
}
