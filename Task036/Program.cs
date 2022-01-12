// 36. Задать массив, заполнить случайными положительными трёхзначными числами. Показать количество нечетных\четных чисел
int[] somearray = new int[10];

void FillArray(int[] newarray)
{
    for (int i = 0; i < newarray.Length; i++)
    {
        newarray[i] = new Random().Next(100,1000);
        Console.WriteLine(newarray[i]);
    }
}

void countNumbers (int[] checkedarray)
{
    int chet = 0;
    int nechet = 0;
    for(int j=0;j<checkedarray.Length;j++)
    {
        if (checkedarray[j]%2==0)
        {
            chet = chet+1;
        }
        else
        {
            nechet = nechet+1;
        }
    }
Console.WriteLine ($"В массиве {chet} четных элементов");
Console.WriteLine ($"В массиве {nechet} нечетных элементов");
}
FillArray(somearray);
countNumbers(somearray);