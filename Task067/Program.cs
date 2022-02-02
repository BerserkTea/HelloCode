// 67. Показать натуральные числа от N до 1, N задано

int N = 25;

void FromNToOne (int lastnumber)
{
    Console.Write($"{lastnumber} ");
    if (lastnumber!= 1)
    FromNToOne (lastnumber-1);
  
}
FromNToOne(N);
