// 23. Показать таблицу квадратов чисел от 1 до N 
Console.WriteLine("Введите число ");
int NumberN = Convert.ToInt32(Console.ReadLine());
int[] ArrayNumbers = new int[NumberN+1];
Console.WriteLine("Число\tКвадрат");
for (int j = 1; j < ArrayNumbers.Length; j++)
{
    ArrayNumbers[j] = j;
    //Console.WriteLine($"{ArrayNumbers[j]}___{j*j}");
    Console.WriteLine("{0}\t{1}", j, Math.Pow(j,2));
}
// for (int i = 1; i < NumberN + 1; i++)
// {
//     Console.WriteLine(i * i);
// }
