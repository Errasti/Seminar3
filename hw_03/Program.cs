Console.WriteLine("Введите число N: ");
int cube = int.Parse(Console.ReadLine());

void getCube ( int n )
{
    int count = 1;
    if ( n <= 0 )
    {
        Console.WriteLine("Введите положительное N");
    }
    else if ( n > 0)
    {
        while ( count <= n )
        {
            int result = count * count * count;
            Console.Write(result + " ");
            count ++;
        }
    }
}
getCube(cube);
