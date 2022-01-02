// 21. Программа проверяет пятизначное число на палиндромом.


//  1-й способ с 2 массивами и сравнением их.

// Console.WriteLine("Введите пятизначное число");
// int Numbers = Convert.ToInt32(Console.ReadLine());
// string NumbersString = Convert.ToString(Numbers); // создали переменную типа string из введенных чисел
// if (NumbersString.Length != 5)
// {
//     Console.WriteLine("Введите корректное число");
// }
// else

// {
//     int[] numbersArr = new int[NumbersString.Length];   // Создаю массив с длинной стоки y
//     int Z = Numbers;                                    // Ввел переменную Z что бы не пилить стартовую переменную а.
//     int arrSize = NumbersString.Length;                 // ввел переменную длинны исходя из длинны строки y
//     for (int i = 0; Z > 0; i++)
//       {
//         numbersArr[arrSize - 1] = Z % 10;               // Берем последний элемент массива(а не первый, и записываем в него остаток от деления числа Z на 10)
//         arrSize = arrSize - 1;                          // уменьшаем счетчик длинны на 1 что бы в след раз вносить уже в другой номер элемента массива
//         //Console.WriteLine(arrSize);
//         Z = Z / 10;                                     // уменьшаем исходное число убирая у него последнее число, что бы в след проходе работать уже с другими числами.

//         //Console.Write(numbersArr[arrSize]);
//     }
//     int indexNumber = 4;
//     int[] rrasrebmun = new int[5];                       // создаю массив под названием rrasrebmun который будет зеркалить массив numbersarr
//     for (int ii = 0; ii < 5; ii++)

//     {
//         rrasrebmun[ii] = numbersArr[indexNumber];
//         indexNumber = indexNumber - 1;
//         Console.Write(rrasrebmun[ii]);
//     }
//     // int ij = 4;
//     // for (int index = 0; index < 5; index++)
//     // {
//     //     numbersArr[index] == rrasrebmun[ij];
//     // }
//     Console.WriteLine("");
//     if (numbersArr[0] == rrasrebmun[0] && numbersArr[1] == rrasrebmun[1] && numbersArr[2] == rrasrebmun[2] && numbersArr[3] == rrasrebmun[3] && numbersArr[4] == rrasrebmun[4])
//     {
//         Console.WriteLine("число является палиндромом");
//     }
//     else
//     {
//         Console.WriteLine("число не является палиндромом");
//     }
// }

// 2ой способ попроще.
string NumbersString ="78687";
Console.WriteLine($"Задано число {NumbersString}");
//string NumbersString = Convert.ToString(Numbers); // создали переменную типа string из введенных чисел
//Console.WriteLine(NumbersString.Length);
int howManyCounts = NumbersString.Length / 2;   //Переменная что бы узнать сколько требуется раз провести расчеты(сравнения)
if (NumbersString.Length != 5)
{
    Console.WriteLine("Введите корректное число"); //Вывод ошибки при вводе нетого чего-то.
}
else
{
    int fromBack = NumbersString.Length - 1; //Добавил переменную чтобы вести сравнение с конца
    bool resultcomp = false;                  //Добавил переменную чтобы вытащить результат из цикла
    for (int i = 0; i < howManyCounts; i++)  //Запускаем цикл что бы сравнивать крайние значения массива с шагом 1
    {
        if (NumbersString[i] == NumbersString[fromBack])
        {
            // Console.WriteLine($"{i} Число и {fromBack} равны.");
            fromBack = fromBack - 1;
            resultcomp = true;
        }
        else
        {
            //Console.WriteLine("Число не является палиндромом");
            resultcomp = false;
            break;
        }
    }
    if (resultcomp)
    {
        Console.WriteLine("Число является палиндромом");
    }
    else
    {
        Console.WriteLine("Число не является палиндромом");
    }
}
