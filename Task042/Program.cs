﻿// 42. Определить сколько чисел больше 0 введено с клавиатуры
// Console.WriteLine("Введи-ка мне дружок через пробел цифирь");
// string stroka = Console.ReadLine();

// string[] strokaArr = stroka.Split(" ");

// int counter = 0;
// for (int i = 0; i < strokaArr.Length; i++)
// {
//     bool result = double.TryParse(strokaArr[i], out double number); // ввели переменную для проверки а число ли перед нами
//     if (result == false)
//     {
//         Console.WriteLine("введено не число");    
//     }
//     else
//     {
//         if (number>0)
//         {
//              counter++;
//         }      
//       //Console.WriteLine(number);  использовал для проверки что  распределилилось в массив
//     }
// }
// Console.WriteLine($"Хозяин, Доби сосчитал до {counter} подсчитывая цифры больше 0.");
string line;
int countPositive = 0;
Console.WriteLine("Введите числа, для завершения введите quit");
 while (true)
{
    line = Console.ReadLine();
    if (int.TryParse(line, out int number))
    {
        if (number > 0) countPositive++;
    }
    else
    {
        if (line == "quit") break;
        Console.WriteLine("Ты не прав дружок");
    }
}
Console.WriteLine(countPositive);