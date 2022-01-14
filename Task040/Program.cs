// 40. В Указанном массиве вещественных чисел найдите разницу между максимальным и минимальным элементом
double[] somearray = { 1.4, 0.5673, 3.1, 4.15, 5.35, 6.78, 7, 64.19878, 29, 7.54, 6, 10, 12, 15 };
double maxNumber = somearray[0];
double minNumber = somearray[0];
int fromBackCount = somearray.Length-1;
for (int i = 0; i < somearray.Length; i++)
{
    if (somearray[i]>maxNumber)
    {
    maxNumber = somearray[i];
    }
    else if (somearray[i]<minNumber)
    {
        minNumber = somearray[i];
    }
    
}
Console.WriteLine($"Разница между максимальным и минимальным элементом массива равна {Math.Round((maxNumber-minNumber),2)}");

