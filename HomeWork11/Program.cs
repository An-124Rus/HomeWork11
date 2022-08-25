using System.Globalization;

internal class Program
{
    private static void Main(string[] args)
    {
        int minValue = 3;
        int maxValue = 101;
        int firstМultiplicity = 3;
        int secondМultiplicity = 5;
        int sum = 0;               
        
        Random randomNumber = new Random();
        int number = randomNumber.Next(minValue, maxValue);

        Console.WriteLine(number);
        Console.WriteLine("Начинаем ряд");

        for (int i = 1; i <= number; i++)
        {
            if (i % firstМultiplicity == 0 || i % secondМultiplicity == 0)
            {
                Console.WriteLine(i);
                sum += i;                
            }            
        }
        
        Console.WriteLine(sum);        
    }
}