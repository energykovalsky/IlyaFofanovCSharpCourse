namespace D_OOP;

internal class Program    
{
    static void Main(string[] args)
    {
        Character c = new Character();
        //c.Health = 120;
        c.Hit(120);

        //c.Health = -20;

        Console.WriteLine(c.Health);
    }
}