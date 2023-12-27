using System;

void func1() // (done)
//Пользователь вводит 2 числа (A и B). Возвести число A в степень B.
{
    Console.WriteLine("enter base number:");
    int b = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("enter exponent number:");
    int e = Convert.ToInt32(Console.ReadLine());
    int result = 1;
    for (int i = 0; i < e; i++)
    {
        result *= b;
    }
    Console.WriteLine("result: " + result);
};

void func2() //  (done)
//Пользователь вводит 1 число (A). Вывести все числа от 1 до 1000, которые делятся на A.
{
    {
        Console.WriteLine("enter number:");
        int a = Convert.ToInt32(Console.ReadLine());
        for (int i = 1; i <= 1000; i++)
        {
            if (i % a == 0)
            {
                Console.Write("result: " + i);
            }
        }

    };
}

void func3() // (done)
// Пользователь вводит 1 число (A). Найдите количество положительных целых чисел, квадрат которых меньше A.
{
    Console.WriteLine("enter number:");
    uint a = Convert.ToUInt32(Console.ReadLine());
    int result = 0;
    for (int i = 1; i < a; i++)
    {
        if (i * i < a)
        {
            result++;
        }
    };
    Console.WriteLine("result: " + result);
}

void func4() // (done)
//Пользователь вводит 1 число (A). Вывести наибольший делитель (кроме самого A) числа A.
// хотелось бы остановиться тут поподробнее - а как тут жить, если юзер ввел отрицательное число?
// также вижу, что решение пока не оптимальное - например, ели юзер ввел 1, то программа не выдает 1

{
    Console.WriteLine("enter number:");
    int a = Convert.ToInt32(Console.ReadLine());
    for (int i = a - 1; i > 0; i--)
    {
        if (a % i == 0)
        {
            Console.WriteLine(i);
            break;
        }
    };

}

void func5() // (done)
//Пользователь вводит 2 числа (A и B). Вывести сумму всех чисел из диапазона
//от A до B, которые делятся без остатка на 7 (Учтите, что при вводе B может
//оказаться меньше A).
{
    Console.WriteLine("Enter number A: ");
    int a = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter number B: ");
    int b = Convert.ToInt32(Console.ReadLine());
    int result = 0;
    if (a > b)
    {
        for (int i = b; i <= a; i++)
        {
            if (i % 7 == 0)
            {
                result += i;

            }
        };
        Console.WriteLine(result);
    }

    else if (a < b)
    {
        for (int i = a; i <= b; i++)
        {
            if (i % 7 == 0)
            {
                result += i;

            }
        };
        Console.WriteLine(result);
    }
    else if (a == b)
    {
        if (a % b == 0)
        {
            result = 1;
            Console.WriteLine(result);
        }
    }
    else
    {
        Console.WriteLine("oops, something went wrong :)");
    };

}

void func6() // (done)
//Пользователь вводит 1 положительное число (N). Выведите N-ое число ряда
//фибоначчи. В ряду фибоначчи каждое следующее число является суммой двух
//предыдущих. Первое и второе считаются равными 1
{
    Console.WriteLine("enter number:");
    int order = Convert.ToInt32(Console.ReadLine());
    int first = 1;
    int second = 1;
    for (int i = 3; i <= order; i++)
    {
        int third = first + second;
        first = second;
        second = third;
    }
    Console.WriteLine(second);
};

void func7() // (done)
//Пользователь вводит 2 числа. Найти их наибольший общий делитель
//используя алгоритм Евклида.
{
    Console.WriteLine("Enter number A: ");
    int a = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter number B: ");
    int b = Convert.ToInt32(Console.ReadLine());
    while ((a != 0) & (b != 0))
    {
        if (a > b)
            a = a % b;
        else
            b = b % a;
    }
    Console.WriteLine(a + b);
};

void func8() // (done)
// comment: doesnt work if N is not a interger (will go into loop :( )
// Пользователь вводит целое положительное число, которое является кубом
// целого числа N. Найдите число N методом половинного деления.
{
    Console.WriteLine("Enter number: ");
    double x = Convert.ToDouble(Console.ReadLine());
    double a = 0;
    double b = 1000;
    double c = (a + b) / 2;
    if (x == Math.Pow(a, 3))
    {
        Console.WriteLine(a);
    }
    else if (x == Math.Pow(b, 3))
    {
        Console.WriteLine(b);
    }
    else
    {
        while (x != Math.Pow(c, 3))
        {
            c = (a + b) / 2;
            Console.WriteLine($"test {c}");
            if (x == Math.Pow(c, 3))
            {
                Console.WriteLine(c);
            }
            else if (x > Math.Pow(c, 3))
            {
                a = c;
            }
            else
            {
                b = c;
            }
        }
    };

};

void func9() // (done)
// Пользователь вводит 1 число. Найти количество нечетных цифр этого числа.
{
    Console.WriteLine("Enter number: ");
    int a = Convert.ToInt32(Console.ReadLine());
    int b = 0;
    while (a > 0)
    {
        if (a % 2 == 1)
        {
            b++;
        }
        a = a / 10;

    }
    Console.WriteLine($"Amount is {b}");
}

void func10() // (done)
//Пользователь вводит 1 число. Найти число, которое является зеркальным
//отображением последовательности цифр заданного числа, например, задано
//число 123, вывести 321
{
    Console.WriteLine("Enter number: ");
    int a = Convert.ToInt32(Console.ReadLine());
    int b = 0;
    int c = 1;
    while ((a / Convert.ToInt32(Math.Round(Math.Pow(10, c)))) != 0)
    {
        c++;
    }
    for (; c >= 1; c--)
    {
        b += (a % 10) * Convert.ToInt32(Math.Round(Math.Pow(10, c - 1)));
        a = a / 10;
    }
    Console.WriteLine($"Result is: " + b);
}
