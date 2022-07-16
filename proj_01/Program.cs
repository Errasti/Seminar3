Console.Write("Введите координаты x ");
int xinput = int.Parse(Console.ReadLine());

Console.Write("Введите координаты y ");
int yinput = int.Parse(Console.ReadLine());

int getQuarter ( int x, int y )
{
    if ( x > 0 && y > 0)
    {
        return 1;
    }
    if ( x < 0 && y > 0)
    {
        return 2;
    }
    if ( x < 0 && y < 0)
    {
        return 3;
    }
    if ( x > 0 && y < 0)
    {
        return 4;
    }
return 0;
}

int result = getQuarter(xinput , yinput );
Console.WriteLine(result);
