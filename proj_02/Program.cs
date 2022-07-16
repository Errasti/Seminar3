Console.WriteLine("Введите комер четверти: ");
int quarter = int.Parse(Console.ReadLine());

string  XY ( int number )
{
    if( number == 1 )
    {
        return "X > 0 ; Y > 0";
    }
    if ( number == 2 )
    {
        return "X < 0 ; Y > 0";
    }
    if ( number == 3 )
    {
        return "X < 0 ; Y < 0";
    }
    if ( number == 4 )
    {
        return "X > 0 ; Y < 0";
    }
    return "Нет такой четверти";
}

Console.WriteLine(XY(quarter));


