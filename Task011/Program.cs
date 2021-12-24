// Дано число из отрезка [10, 99]. Показать наибольшую цифру числа
// Console.WriteLine("Hello, World!");

void FillArray(int[] numbers)
{
    int length = numbers.Length;
    int index = 0;
    while (index < length)
    {
        numbers[index] = index + 10;
        //index = index + 1;
        index++;
    }
}

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}

int[] mass = new int[90];

FillArray(mass);

int x = mass[new Random().Next(0, mass.Length)];

//Console.WriteLine(mass.Length);

//PrintArray(array);
Console.WriteLine(x);
int y =x%10;
//Console.WriteLine(y); проверял
int z = (x-y)/10;
//Console.WriteLine(z); проверял

if (y>z)
{
    Console.WriteLine(y);
}
else
{
    Console.WriteLine(z);
}