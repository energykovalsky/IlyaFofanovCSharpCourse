namespace D_OOP;

internal class Program
{
    static void Main(string[] args)
    {
        Character c = new Character();
        c.Hit(120);
        Console.WriteLine($"C.Health = {c.Health}");
        Console.WriteLine();

        Calculator calc = new Calculator();

        double Square1 = calc.CalcTriangleSquare(1, 1);
        double Square2 = calc.CalcTriangleSquare(1, 1, 1);
        
        double Square3 = Calculator.CalcTriangleSquare(ab: 1, ac: 1, alpha: 1); //071 Именованные аргументы.mp4
        double Square4 = Calculator.CalcTriangleSquare(ab: 1, ac: 1, alpha: 1, isInRadians: true); //Опциональные параметры

        Console.WriteLine($"Square1 = {Square1}");
        Console.WriteLine($"Square2 = {Square2}");
        Console.WriteLine($"Square3 = {Square3}");

        double avg = Calculator.Average2(1, 2, 3, 4);
        Console.WriteLine(avg);

        Console.WriteLine("Enter a number, please");
        //int number = int.Parse(Console.ReadLine())
        string line = Console.ReadLine();
        bool wasParsed = int.TryParse(line, out int number);
        if (wasParsed)
        {
            Console.WriteLine(number);
        }
        else
        {
            Console.WriteLine("Failed to parse");
        }


        if (Calculator.TryDivide(1, 0, out double result))
        {
            Console.WriteLine(result);
        }
        else
        {
            Console.WriteLine("Failed to parse");
        }
    }
}