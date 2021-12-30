// 14. Найти третью цифру числа или сообщить, что её нет

// string chislo = Console.ReadLine();
// char[] ch = new char[chislo.Length]; 
//  for (int i = 0; i < chislo.Length; i++) { 
//             ch[i] = chislo[i]; 
//            Console.WriteLine(ch[i]);
//         }

// int a = 6534;
// string chislo = Convert.ToString(a);
// char[] numbarr = new char[chislo.Length];
// for (int index = 0; index < chislo.Length; index++)
// {
//     numbarr[index] = chislo[index];
// }
// if (numbarr[2] != 0)
// {
//     Console.WriteLine(numbarr[2]);    // как уточнить существует ли эллемент массива?
// }
// else
// {
//     Console.WriteLine("А нет её, всё-всё нет её.");
// }

// Найти третью цифру числа или сообщить, что её нет

Console.WriteLine("Введите число");
int a = Convert.ToInt32(Console.ReadLine());

if (100 > a)
{
    Console.WriteLine("ошибка 3 цифры нет");
}
else
{
    string y = Convert.ToString(a);     // создал переменную стринг конвертацией int из переменной а
    // Console.WriteLine(y[2]);
    //Console.WriteLine(y.Length);
    int[] numbers = new int[y.Length];  // Создаю массив с длинной стоки y
    int Z = a;                          // Ввел переменную Z что бы не пилить стартовую переменную а.
    int arrSize = y.Length;             // ввел переменную длинны исходя из длинны строки y
    for (int i = 0; Z > 0; i++)
    {
        numbers[arrSize - 1] = Z % 10;  // Берем последний элемент массива(а не первый, и записываем в него остаток от деления числа Z на 10)
        arrSize = arrSize - 1;          // уменьшаем счетчик длинны на 1 что бы в след раз вносить уже в другой номер элемента массива
        //Console.WriteLine(arrSize);
        Z = Z / 10;                     // уменьшаем сходное число убирая у него последнее число, что бы в след проходе работать уже с другими числами.
        //Console.WriteLine(numbers[i]);
    }
    Console.WriteLine(numbers[2]);
}