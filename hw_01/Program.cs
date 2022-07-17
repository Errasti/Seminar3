/* Напишите программу, которая принимает на вход пятизначное 
число и проверяет, является ли оно палиндромом.

14212 -> нет

12821 -> да

23432 -> да
*/

Console.WriteLine("Введите 5ти значное число: ");
int reqNum = int.Parse(Console.ReadLine());

string getPali ( int number )
{
    int[] array = {0, 0, 0, 0, 0};
    int index = 4;
    while( index >= 0 )
    {
        array[index] = number % 10;
        number = number / 10;
        index = index -1;
    }
    if ( array[0] == array[4] && array[1] == array[3])
    {
        return "Число - палиндром";
    }
    else
    {
        return "Число - не палиндром";
    }
   
}
Console.WriteLine(getPali(reqNum));

