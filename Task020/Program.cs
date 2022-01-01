// 20. Задать номер четверти, показать диапазоны для возможных координат

// void Method (int x, int y)
// {
//     if (x>0 && y>0)
//     {
//     Console.WriteLine("Точка в 1 координатной четверти");
//     }
//     else if (x<0 && y>0)
//     {
//     Console.WriteLine("Точка во 2 координатной четверти");
//     }
//     else if (x<0 && y<0)
//     {
//     Console.WriteLine("Точка в 3 координатной четверти");
//     }
//     else if (x>0 && y<0)
//     {
//     Console.WriteLine("Точка в 4 координатной четверти");
//     }
//     else
//     Console.WriteLine("ошибка");
// }

// Method (0, 0);
void Method (int number)
{
    if (number == 1)
    {
        Console.WriteLine("x>0");
        Console.WriteLine("y>0");
    }
    else if (number == 2)
    {
        Console.WriteLine("x<0");
        Console.WriteLine("y>0");
    }
    else if (number == 3)
    {
        Console.WriteLine("x<0");
        Console.WriteLine("y<0");
    }
    else if (number == 4)
    {
        Console.WriteLine("x>0");
        Console.WriteLine("y<0");
    }
    else
        Console.WriteLine("Введите корректное значение");
}

Console.WriteLine("Введите номер четверти (от 1 до 4) для отображения дапазона возможных координат");
int NumberAR = Convert.ToInt32(Console.ReadLine());

Method(NumberAR);