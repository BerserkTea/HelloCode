// Показать вторую цифру трёхзначного числа
Console.WriteLine("Hello, World!");

var x = 316564;

string stringNumber = Convert.ToString(x);
if (stringNumber.Length>3)
{
    Console.WriteLine("длинна превышена");
}
else
{
    Console.WriteLine(stringNumber[1]);
}