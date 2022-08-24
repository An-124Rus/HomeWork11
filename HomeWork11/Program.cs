using System.Globalization;

internal class Program
{
    private static void Main(string[] args)
    {
        int finalCount = 0;        
        int newValue = 0;

        Random rand = new Random();
        int number = rand.Next(3, 101);

        Console.WriteLine(number);
        Console.WriteLine("Начинаем ряд");


        for (int count = 3; count <= number; count++)
        {            
            int checkDivisionByThree = count % 3;
            int checkDivisionByFive = count % 5;

            if (checkDivisionByThree == 0 || checkDivisionByFive == 0)
            {
                Console.WriteLine(count);
                newValue += count;                
            }
            else
            {
                continue;
            }            
        }
        finalCount = number + newValue;
        Console.WriteLine(finalCount);        
    }
}