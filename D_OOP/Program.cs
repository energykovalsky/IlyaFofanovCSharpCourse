namespace D_OOP;

internal class Program    
{
    static void Main(string[] args)
    {
        Character c = new Character();
        //c.Health = -20; 
        c.Hit(120);

        
        Console.WriteLine($"C.Health = {c.Health}");
        Console.WriteLine();

        Calculator calc = new Calculator();
        double Square1 = calc.CalcTriangleSquare(1, 1);

        calc.CalcTriangleSquare(10, 20, 30);
        double Square2 = calc.CalcTriangleSquare(1, 1, 2);

        double Square3 = calc.CalcTriangleSquare(1, 1, 2);

        Console.WriteLine($"Square1 = {Square1}");
        Console.WriteLine($"Square2 = {Square2}");
        Console.WriteLine($"Square3 = {Square3}");
    }
}