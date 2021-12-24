//12. Удалить вторую цифру трёхзначного числа
int a = 321;

string numberString = Convert.ToString(a);

if (numberString.Length>3)
{
    Console.WriteLine("длинна превышена");
}
else
{
    string numberlessString = numberString.Remove(1,1); // создаем новую переменную у которой удаляем 2ой символ(номерация с нуля), но тут переменная в формате string
    Console.WriteLine(numberlessString);
}