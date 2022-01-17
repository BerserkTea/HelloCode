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