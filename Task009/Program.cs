// Показать последнюю цифру трёхзначного числа
Console.WriteLine("Hello, World!");

var x = 431;

string y = Convert.ToString(x);

if (y.Length>3)
{
    Console.WriteLine("длинна превышена");
}
else
{
    Console.WriteLine(y[2]);
}