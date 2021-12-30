// 19. Определить номер четверти плоскости, в которой находится точка с координатами Х и У, причем X ≠ 0 и Y ≠ 0

void Method (int x, int y)
{
    if (x>0 && y>0)
    {
    Console.WriteLine("Точка в 1 координатной четверти");
    }
    else if (x<0 && y>0)
    {
    Console.WriteLine("Точка во 2 координатной четверти");
    }
    else if (x<0 && y<0)
    {
    Console.WriteLine("Точка в 3 координатной четверти");
    }
    else if (x>0 && y<0)
    {
    Console.WriteLine("Точка в 4 координатной четверти");
    }
    else
    Console.WriteLine("ошибка");
}

Method (0, 0);
