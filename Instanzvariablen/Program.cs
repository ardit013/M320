using System;

class Program
{
    static void Main()
    {
        Rectangle rect1 = new Rectangle(5, 15);
        Console.WriteLine("Length: " + rect1.GetLength());
        Console.WriteLine("Width: " + rect1.GetWidth());

        Rectangle rect3 = new Rectangle();
        Console.WriteLine("Height before change: " + rect3.GetHeight());
        rect3.SetHeight(20);
        Console.WriteLine("Height after change: " + rect3.GetHeight());
    }
}
