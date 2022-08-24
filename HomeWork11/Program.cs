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
        
        Random randomNumber = new Random();
        int number = randomNumber.Next(minValue, maxValue);

        Console.WriteLine(number);
        Console.WriteLine("Начинаем ряд");

        for (int firstRowValue = 3; firstRowValue <= number; firstRowValue++)
        {
            if (firstRowValue % firstМultiplicity == 0 || firstRowValue % secondМultiplicity == 0)
            {
                Console.WriteLine(firstRowValue);
                newValue += firstRowValue;                
            }            
        }
        int finalCount = number + newValue;

        Console.WriteLine(finalCount);        
    }
}