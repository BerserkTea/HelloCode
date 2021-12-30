// 18. Проверить истинность утверждения ¬(X ⋁ Y) = ¬X ⋀ ¬Y


//пишем метод

bool check(bool x, bool y)
{
    if (!(x || y) == (!x && !y))
        return true;
    else
        return false;
}

if (check(false, false) && check(false, true) && check(true, false) && check(true, true))
    Console.WriteLine("Верно");
else
{
    Console.WriteLine("Не Верно");
}



