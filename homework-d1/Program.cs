int[] createAndFill()
// создать и заполнить массив, вывести в консоль и передать
{
    int[] myArray = new int[7];
    Random rnd = new Random();
    for (int i = 0; i < myArray.Length; i++)
    {
        myArray[i] = rnd.Next(5);
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

void task5() // in progress
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
}


task5();