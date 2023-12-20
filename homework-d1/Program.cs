// сразу извиняюсь за качество работ - вижу, что явно можно лучше, но соображать среди рабочей недели тяжело :) Хотелось бы более подробных подсказок, как и где можно было бы использовать кроме if/else

void func1() // Задание 1: Пользователь вводит 2 числа (A и B). Если A>B, подсчитать A+B, если A=B, подсчитать A*B, если A<B, подсчитать A-B.
{
    Console.WriteLine("Enter 2 numbers");
    double a = Convert.ToDouble(Console.ReadLine());
    double b = Convert.ToDouble(Console.ReadLine());
    double c;
    if (a > b)
    {
        c = a + b;
    }
    else if (a == b) {
        c = a * b;
    }
    else { 
        c = a - b;
    }
    Console.WriteLine(c);
}

void func2() // Пользователь вводит 2 числа (X и Y). Определить какой четверти принадлежит точка с координатами (X, Y).
{
    Console.WriteLine("Enter X and Y");
    double X = Convert.ToDouble(Console.ReadLine());
    double Y = Convert.ToDouble(Console.ReadLine());
    if (X > 0 && Y > 0) {
        Console.WriteLine("1st quater");
    }
    else if (X < 0 && Y > 0) { 
        Console.WriteLine("2nd quater");
    }
    else if (X < 0 && Y < 0) { 
        Console.WriteLine("3rd quter");
    }
    else if (X > 0 && Y < 0) { 
        Console.WriteLine("4th quarter");
    }
    else { 
            Console.WriteLine("on the abscissa or ordinate line");
    }

}

void func3() // Пользователь вводит 3 числа (A, B и С). Выведите их в консоль в порядке возрастания.
{
    Console.WriteLine("Enter 3 numbers to compare:");
    double A = Convert.ToDouble(Console.ReadLine());
    double B = Convert.ToDouble(Console.ReadLine());
    double C = Convert.ToDouble(Console.ReadLine());
    if (A > B && B > C)
        Console.WriteLine(C + " < " + B + " < " + A);
    else if (A > C && C > B)
        Console.WriteLine(B + " < " + C + " < " + A);
    else if (B > C && C > A)
        Console.WriteLine(A + " < " + C + " < " + B);
    else if (B > A && A > C)
        Console.WriteLine(C + " < " + A + " < " + B);
    else if (C > A && A > B)
        Console.WriteLine(B + " < " + A + " < " + C);
    else if (C > B && B > A)
        Console.WriteLine(A + " < " + B + " < " + C);
    else
        Console.WriteLine("seems like one of the numbers is too big or maybe you've entered the same numbers :)");
}

void func4() // Пользователь вводит 3 числа (A, B и С). Выведите в консоль решение(значения X) квадратного уравнения стандартного вида, где A X 2+BX +C=0.
{
    Console.WriteLine("To solve ax^2 * bx * c = 0, please enter a, b and c:");
        double a = Convert.ToDouble(Console.ReadLine());
        double b = Convert.ToDouble(Console.ReadLine());
        double c = Convert.ToDouble(Console.ReadLine());
        double D = b * b - 4 * a * c;
    if (D < 0)
    { 
        Console.WriteLine("0 square roots");
    }
    else if (D == 0)
    {
        double x = -b / (2 * a);
        Console.WriteLine("1 square root: " + x);
    }
    else
    {
        double x1 = (-b + Math.Sqrt(D)) / (2 * a);
        double x2 = (-b - Math.Sqrt(D)) / (2 * a);
        Console.WriteLine("2 square roots: " + x1 + "and " + x2);
    }


}

func4();