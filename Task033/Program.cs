// 33. Задать массив из 12 элементов, заполненных числами из [0,9]. Найти сумму положительных/отрицательных элементов массива
void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(0, 10);
        //index = index + 1;
        index++;
    }
}
int[] array = new int[12];
void PrintArr(int[] cop)
{
    int count = cop.Length;
    int position = 0;
    while (position < count)
    {
        Console.Write($"{cop[position]} ");
        position++;
    }
}
void MethodSumDiff(int[] summdiffarray)
{
    int steps= summdiffarray.Length;
    int pos = 0;
    int summ = 0;
    int diff = 0;
    while (pos<steps)
    {
        if (summdiffarray[pos]>0)
        {
            summ=summ+summdiffarray[pos];
        }
        else
        {
            diff=diff-summdiffarray[pos];
        }
        pos++;
    }
Console.WriteLine("");
Console.WriteLine($"Сумма положительных элементов равна {summ}, сумма отрицательных элементов равна {diff}");
}
FillArray(array);
PrintArr(array);
MethodSumDiff(array);

