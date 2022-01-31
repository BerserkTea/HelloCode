// 46. Написать программу масштабирования фигуры
// ```
// Тут для тех кто далеко улетел, чтобы задавались вершины фигуры списком (одной строкой)
// например: "(0,0) (2,0) (2,2) (0,2)"
// коэффициент масштабирования k задавался отдельно - 2 или 4 или 0.5
// В результате показать координаты, которые получатся.
// при k = 2 получаем "(0,0) (4,0) (4,4) (0,4)"
// ```
Console.WriteLine("Введите колличество вершин фигуры");
int figurePeaks = Convert.ToInt32(Console.ReadLine);

Console.WriteLine("Введите последовательно координаты каждой из вершин через точку");

string stroka = Console.ReadLine();
string[] strokaArr = stroka.Split(".");
Console.WriteLine("Введите коэффициент масштабирования");
double koef = Convert.ToDouble(Console.ReadLine());
double[] numberArr = new double[strokaArr.Length];
for (int i = 0; i < numberArr.Length; i++)
{
    numberArr[i] = (Convert.ToDouble(strokaArr[i]) * koef);
}

Console.WriteLine("({0};{1}) ({2};{3}) ({4};{5}) ({6};{7})", numberArr[0], numberArr[1], numberArr[2], numberArr[3], numberArr[4], numberArr[5], numberArr[6], numberArr[7]);

// using static System.Console;
// // Написать программу масштабирования фигуры
// string MyInput(string msg)
// {
//     Write(msg);
//     return ReadLine() ?? string.Empty;
// }
// double[] StringConvert(string stringDouble, char[] splitChar, out bool sign)
// {
//     string[] tmp = stringDouble.Split(splitChar, StringSplitOptions.RemoveEmptyEntries);
//     double[] result = new double[tmp.Length];
//     bool flag = false;
//     double temp = 0;
//     for (int i = 0; i < tmp.Length; i++)
//     {
//         flag = double.TryParse(tmp[i], out temp);
//         if (!flag)
//         {
//             WriteLine($"Неверный ввод: {tmp[i]}");
//             sign = false;
//             return result;
//         }
//         result[i] = temp;
//     }
//     sign = true;
//     return result;
// }
// void ScalingCoordinates(double[] coordinates, double coefficient)
// {
//     for (int i = 0; i < coordinates.Length; i++)
//         coordinates[i] *= coefficient;
// }
// void PrintArray(double[] array)
// {
//     int k = 1;
//     for (int i = 0; i < array.Length; i++)
//     {
//         Write($"{array[i]}\t");
//         if (k % 7 == 0)
//             WriteLine();
//         k++;
//     }
//     WriteLine();
// }
// char[] splitFormat = { ' ', ',', '(', ')', '-', '_' };
// Console.Clear();
// while (true)
// {
//     bool sign = true;
//     string answer = MyInput("Введите координаты: ");
//     if (answer.Length == 0)
//         break;
//     double[] coordinates = StringConvert(answer, splitFormat, out sign);
//     WriteLine(sign);
//     if (!sign)
//         continue;
//     Write("Введите коэффициент: ");
//     string coefficient = ReadLine() ?? string.Empty;
//     bool flag = double.TryParse(coefficient, out double coefficientScaling);
//     if (!flag)
//     {
//         WriteLine($"Неверный ввод коэффициента: {coefficient}");
//         continue;
//     }
//     WriteLine("Введены координаты");
//     PrintArray(coordinates);
//     ScalingCoordinates(coordinates, coefficientScaling);
//     WriteLine("Координаты после масштабирования");
//     PrintArray(coordinates);
// }