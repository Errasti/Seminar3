/* Напишите программу для вычисления площади круга, прямоугольника и треугольника.
Ввод данных осуществляется в диалоговом режиме. На первом шаге у пользователя запрашивается фигура,
площадь которой нужно вычислить. На втором шаге пользователь вводит параметры, необходимые для рассчета.
Затем, выводится результат.
*/


double rectangleSquare( double sidea, double sideb )
{
    double recResult = sidea * sideb;
    return recResult;
}

double triangleSquare( double mainSide, double height)
{
    double triResult = mainSide * height / 2;
    return triResult;
}

double roundSquare( double radius )
{
    double roundResult = 3.14 * radius * radius;
    return roundResult;
}

Console.WriteLine("Введите название фигуры для расчета площади: ");
string figure = Console.ReadLine().ToLower();

if ( figure == "треугольник" )
{
    Console.WriteLine("Введите длину оснвоания: ");
    double sideMain = double.Parse(Console.ReadLine());
    Console.WriteLine("Введите длину высоты: ");
    double userHeight = double.Parse(Console.ReadLine());
    Console.WriteLine("Площадь треугольника равна: " + triangleSquare( sideMain, userHeight ));
}

else if ( figure == "прямоугольник" )
{
    Console.WriteLine("Введите ширину:");
    double width = double.Parse(Console.ReadLine());
    Console.WriteLine("Введите высоту");
    double height = double.Parse(Console.ReadLine());
    Console.WriteLine("Площадь прямоугольника равна: " + rectangleSquare(width, height));
}

else if ( figure == "круг" )
{
    Console.WriteLine("Введите радиус: ");
    double userRadius = double.Parse(Console.ReadLine());
    Console.WriteLine("Площадь круга равна: " + roundSquare( userRadius ));
}
else
{
    Console.WriteLine("Расчет площади для данной фигуры не предусмотрен");
}