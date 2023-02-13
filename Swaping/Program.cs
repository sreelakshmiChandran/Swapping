namespace Swapping
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the 1st number a =");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the 1st number b =");
            int b = int.Parse(Console.ReadLine());
            int temp = a;
            a = b;
            b = temp;
            Console.WriteLine("a = " + a);
            Console.WriteLine("b = " + b);
        }
    }
}