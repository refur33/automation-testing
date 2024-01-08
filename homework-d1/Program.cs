int[] createAndFill(int n)
// создать и заполнить массив, вывести в консоль и передать
{
    int[] myArray = new int[n];
    Random rnd = new Random();
    for (int i = 0; i < myArray.Length; i++)
    {
        myArray[i] = rnd.Next(50);
    }

    return myArray;
};

int[] createAndFillWithRandom(int n, int start, int end)
// создать и заполнить массив, вывести в консоль и передать + старт и конец широты рандома
{
    int[] myArray = new int[n];
    Random rnd = new Random();
    for (int i = 0; i < myArray.Length; i++)
    {
        myArray[i] = rnd.Next(50);
    }

    return myArray;
};

void outputMyArray(int[] myArray) // отдельно для вывода в консоль
{
    
    for (int i = 0; i < myArray.Length; i++)
    {
        Console.Write(myArray[i] + ", ");
    }
};

void task1() // done
// Найти минимальный элемент массива
{
    int[] myArray = createAndFill(10);
    outputMyArray(myArray);

    int min = myArray.Min();
    Console.WriteLine("\n" + min);
    Console.ReadLine(); // чтобы консоль не закрывалась
};

void task2() // done
// Найти максимальный элемент массива
{
    int[] myArray = createAndFill(50);
    outputMyArray(myArray);

    int max = myArray.Max();
    Console.WriteLine("\n" + max);
    Console.ReadLine(); // чтобы консоль не закрывалась
};

void task3() // done
// Найти индекс минимального элемента массива
{
    int[] myArray = createAndFill(20);
    outputMyArray(myArray);

    int min = myArray.Min();
    int minIndex = Array.IndexOf(myArray, min);
    Console.WriteLine("\n" + minIndex);
    Console.ReadLine(); // чтобы консоль не закрывалась
};

void task4() // done
// Найти индекс максимального элемента массива
{
    int[] myArray = createAndFill(20);
    outputMyArray(myArray);

    int max = myArray.Max();
    int maxIndex = Array.IndexOf(myArray, max);
    Console.WriteLine("\n" + maxIndex);
    Console.ReadLine(); // чтобы консоль не закрывалась
};

void task5() // done
// Посчитать сумму элементов массива с нечетными индексами
{
    int[] myArray = createAndFill(30);
    outputMyArray(myArray);

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
    int[] myArray = createAndFill(40);
    outputMyArray(myArray);

    Array.Reverse(myArray);
    Console.WriteLine();
    foreach (int number in myArray)
    {
        Console.Write(number + ", ");
    }

    Console.ReadLine(); // чтобы консоль не закрывалась
};

void task7() // not ready yet
// Посчитать количество нечетных элементов массива

{
    int[] myArray = createAndFillWithRandom(10, 20, 30);
    outputMyArray(myArray);

    int oddsNumber = 0;
    for (int index = 0; index < myArray.Length; index++)
    {
        if (myArray[index] % 2 != 0)
        {
            oddsNumber += myArray[index];
        }
    }

    Console.WriteLine("\n" + oddsNumber);
    Console.ReadLine(); // чтобы консоль не закрывалась

};

void task8() // done
// Поменять местами первую и вторую половину массива, например, для
//массива 1 2 3 4, результат 3 4 1 2, или для 12345 - 45312

{
    int[] myArray = createAndFill(7);
    outputMyArray(myArray);

    int mid = myArray.Length / 2;
    for (int i = 0; i < mid; i++)
    {
        int tmp = myArray[i];
        myArray[i] = myArray[i + mid + (myArray.Length % 2)];
        myArray[i + mid + (myArray.Length % 2)] = tmp;
    }


    Console.WriteLine(" ");
    Console.WriteLine(string.Join(", ", myArray));
    Console.ReadLine(); // чтобы консоль не закрывалась
}

