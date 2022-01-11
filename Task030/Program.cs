// 30. Показать кубы чисел, заканчивающихся на четную цифру
Console.WriteLine("Введите число");
int N = Convert.ToInt32(Console.ReadLine());
//выделить последнее число
int LastNumber = N%10;
if (LastNumber%2==0)
{
    N = N*N*N;
    Console.WriteLine(N);
}
else
{
    Console.WriteLine("Число не заканчивается на четную цифру.");
}