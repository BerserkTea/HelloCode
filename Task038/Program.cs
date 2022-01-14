// 38. Найти сумму чисел одномерного массива стоящих на нечетной позиции
int [] somearray = {1,2,3,4,5,6,7,8,9,7,6,10,12,15};
int sum = 0;
for (int i = 0; i < somearray.Length; i++)
{
    if (i%2==0)
    {
        sum=sum + somearray[i];
    }
}
Console.WriteLine (sum);