using System;
class Program
{
    static void Main()
    {
        Square greenSquare = new Square(5, "Green");
        Square darkblueSquare = new Square(2, "Dark Blue");
        Square lightblueSquare = new Square(15, "Light Blue");

        Console.WriteLine("Before: ");
        greenSquare.DisplayInfo();
        darkblueSquare.DisplayInfo();
        lightblueSquare.DisplayInfo();

        int newGreenSide = darkblueSquare.GetArea() * 3;

        greenSquare.ChangeSideLength(newGreenSide);

        Console.WriteLine("After: ");
        greenSquare.DisplayInfo();
        darkblueSquare.DisplayInfo();
        lightblueSquare.DisplayInfo();

        Console.ReadLine();
    }
}