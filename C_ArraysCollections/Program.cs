namespace CSharpCourse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] a1;
            a1 = new int[10];

            int[] a2 = new int[5];

            int[] a3 = new int[5] { 1, 3, -2, 5, 10 };

            int[] a4 = { 1, 3, 2, 4, 5 };

            Array myArray = new int[5];

            Array myArray2 = Array.CreateInstance(typeof(int), 5);
            myArray2.SetValue(12, 0);

            Console.WriteLine(myArray2.GetValue(0));


        }
    }
}