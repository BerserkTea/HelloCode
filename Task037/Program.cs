// 37. В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99]

int[] somearray = new int[123];

void FillArray(int[] newarray)
{
    for (int i = 0; i < newarray.Length; i++)
    {
        newarray[i] = new Random().Next(1, 1000);
        Console.Write($"{newarray[i]} ");
    }
}
void CheckMassNumber(int[] checkedarray)
{
    int NumberCounter = 0;
    for (int j = 0; j < checkedarray.Length; j++)
    {
        if (checkedarray[j] < 100 && checkedarray[j] > 9)
        {
            NumberCounter = NumberCounter + 1;
        }
    }
Console.WriteLine("");
Console.WriteLine($"В массиве {NumberCounter} чисел из дипазона [10,99]");
}
FillArray(somearray);
CheckMassNumber(somearray);