// See https://aka.ms/new-console-template for more information

namespace calctest;
public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine($"Hello World");
        Console.WriteLine(Add2Nos(10,20));
        
        
    }

    public static int Add2Nos(int v1, int v2)
    {
        return v1+v2;
    }
}