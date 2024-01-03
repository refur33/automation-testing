int[] createAndFill()
// создать и заполнить массив, вывести в консоль и передать
{
    int[] myArray = new int[9];
    Random rnd = new Random();
    for (int i = 0; i < myArray.Length; i++)
    {
        myArray[i] = rnd.Next(50);
    }

    for (int i = 0; i < myArray.Length; i++)
    {
        Console.Write(myArray[i] + ", ");
    }
    return myArray;
};

void task1() // done
// Найти минимальный элемент массива
{
    int[] myArray = createAndFill();

    int min = myArray.Min();
    Console.WriteLine("\n" + min);
    Console.ReadLine(); // чтобы консоль не закрывалась
};

void task2() // done
// Найти максимальный элемент массива
{
    int[] myArray = createAndFill();

    int max = myArray.Max();
    Console.WriteLine("\n" + max);
    Console.ReadLine(); // чтобы консоль не закрывалась
};

void task3() // done
// Найти индекс минимального элемента массива
{
    int[] myArray = createAndFill();

    int min = myArray.Min();
    int minIndex = Array.IndexOf(myArray, min);
    Console.WriteLine("\n" + minIndex);
    Console.ReadLine(); // чтобы консоль не закрывалась
};

void task4() // done
// Найти индекс максимального элемента массива
{
    int[] myArray = createAndFill();

    int max = myArray.Max();
    int maxIndex = Array.IndexOf(myArray, max);
    Console.WriteLine("\n" + maxIndex);
    Console.ReadLine(); // чтобы консоль не закрывалась
};

void task5() // done
// Посчитать сумму элементов массива с нечетными индексами
{
    int[] myArray = createAndFill();

    int sum = 0;
    for (int i = 1; i < myArray.Length; i +=2)
    {
        sum += myArray[i];
    }
    Console.WriteLine("\n" + sum);
    Console.ReadLine(); // чтобы консоль не закрывалась
};

void task6() // done
// Сделать реверс массива (массив в обратном направлении)
{
    int[] myArray = createAndFill();

    Array.Reverse(myArray);
    Console.WriteLine();
    foreach (int number in myArray)
    {
        Console.Write(number + ", ");
    }

    Console.ReadLine(); // чтобы консоль не закрывалась
};

void task7() // in progress (крешается)
// Посчитать количество нечетных элементов массива
{
    int[] myArray = createAndFill();
    int index = 0;
    int oddsNumber = 0;
    for (index = 0; index > Array.MaxLength; index++)
    {
        if (myArray[index] % 2 != 0)
        {
            oddsNumber += myArray[index];
        }
    }

    Console.WriteLine("\n" + oddsNumber);
    Console.ReadLine(); // чтобы консоль не закрывалась

};

task7();