﻿// // Дано число из отрезка [10, 99]. Показать наибольшую цифру числа
// // Console.WriteLine("Hello, World!");

// void FillArray(int[] numbers)
// {
//     int length = numbers.Length;
//     int index = 0;
//     while (index < length)
//     {
//         numbers[index] = index + 10;
//         //index = index + 1;
//         index++;
//     }
// }

// void PrintArray(int[] col)
// {
//     int count = col.Length;
//     int position = 0;
//     while (position < count)
//     {
//         Console.WriteLine(col[position]);
//         position++;
//     }
// }

// int[] mass = new int[90];

// FillArray(mass);

// int x = mass[new Random().Next(0, mass.Length)];

// //Console.WriteLine(mass.Length);

// //PrintArray(array);
// Console.WriteLine(x);
// int y =x%10;
// //Console.WriteLine(y); проверял
// int z = (x-y)/10;
// //Console.WriteLine(z); проверял

// if (y>z)
// {
//     Console.WriteLine(y);
// }
// else
// {
//     Console.WriteLine(z);
// }
// Дано число из отрезка [10, 99]. Показать наибольшую цифру числа

//int number = new Random().Next(10, 100);
System.Console.WriteLine("Введите число от 10 до 99 ");
int number = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine(number);
if (9<number && number<100)
{
    int a = number % 10;
    int b = number/ 10;
    if (a > b)
    {
    Console.Write("Наибольшей цифрой числа является ");
    Console.WriteLine(a);
    }
    else
    {
    Console.Write("Наибольшей цифрой числа является ");
    Console.WriteLine(b);
    }
}
else
{
    Console.WriteLine("Введено некоректное значение");
}
