//32. Задать массив из 8 элементов, заполненных нулями и единицами вывести их на экран

void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(0, 2);
        //index = index + 1;
        index++;
    }
}
void PrintArr(int[] cop)
{
    int count = cop.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(cop[position]);
        position++;
    }
}
int[] array = new int[8];
FillArray(array);
PrintArr(array);