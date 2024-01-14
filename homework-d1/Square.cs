using System;

class Square
{
    private int side;
    private string colour;
    private int area;

    public Square(int side, string colour)
    {
        this.side = side;
        this.colour = colour;
        CalculateArea();
    }

    private void CalculateArea()
    {
        area = side * side;
    }

    public void DisplayInfo()
    {
        Console.WriteLine("Square name: " + colour);
        Console.WriteLine("Square side lenght: " + side);
        Console.WriteLine("Square area: " + area);
        Console.WriteLine();
    }

    public int GetArea() 
    {
        return area;
    }

    public void ChangeSideLength(int newSide)
    {
        side = newSide;
        CalculateArea();
    }
}
