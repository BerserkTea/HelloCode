// 16. Дано число обозначающее день недели. Выяснить является номер дня недели выходным 
string[] dayOfWeek = {"Понедельник","Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресенье"};
Console.WriteLine("Введите число дня недели");
int a = Convert.ToInt32(Console.ReadLine())-1;
if (a>-1 && a<7)
{
    if (a==5 || a==6)
    {
        Console.WriteLine(dayOfWeek[a]+" Выходной, чилим изи");
    }
    else
    {
        Console.WriteLine(dayOfWeek[a]+" Будний день");
    }
}
else
{
    Console.WriteLine("Введено некорректное значение Папаша!");
}