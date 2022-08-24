using System.Globalization;

internal class Program
{
    private static void Main(string[] args)
    {
        int minValue = 3;
        int maxValue = 101;
        int firstМultiplicity = 3;
        int secondМultiplicity = 5;
        int newValue = 0;
        int finalCount = 0;        
        
        Random randomNumber = new Random();
        int number = randomNumber.Next(minValue, maxValue);

        Console.WriteLine(number);
        Console.WriteLine("Начинаем ряд");

        for (int count = 3; count <= number; count++)
        {
            if (count % firstМultiplicity == 0 || count % secondМultiplicity == 0)
            {
                Console.WriteLine(count);
                newValue += count;                
            }            
        }
        finalCount = number + newValue;

        Console.WriteLine(finalCount);        
    }
}