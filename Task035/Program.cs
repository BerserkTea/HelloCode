// 35. Определить, присутствует ли в заданном массиве, некоторое число
int [] somearray = {9,6,7,42,1,8,123,87,23,76,21412,6,0,12,42,42,123,7};

void CheckArrayForNumber (int[] array)
{
    Console.WriteLine("Какое число искать?");
    int search = Convert.ToInt32(Console.ReadLine());
    int counter = 0;
    for(int i =0; i<array.Length;i++)
    {
        if (array[i]==search)
        {
            Console.WriteLine($"{i}й член массива равный {array[i]} совпадает с заданным числом");
            counter++;
        }
    
    }
Console.WriteLine($"В массиве найдено {counter} элементов совпадающих с числом {search}");
}
CheckArrayForNumber(somearray);