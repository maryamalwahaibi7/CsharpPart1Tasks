namespace CsharpPart1Tasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter how many numbers you need :");
            int n = int.Parse(Console.ReadLine());
            int[] numbers = new int[n]; 
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Enter number : ");
                numbers[i] = int.Parse(Console.ReadLine());
            }
            int total = 0;
            for (int i = 0; i < n; i++)
            {
                total += numbers[i];
            }
            float average = (float)total / n;
            Console.WriteLine("The average is: " + average);

        }
    }
}
