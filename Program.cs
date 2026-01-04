namespace CsharpPart1Tasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Enter how many numbers you need :");
            //int n = int.Parse(Console.ReadLine());
            //int[] numbers = new int[n]; 
            //for (int i = 0; i < n; i++)
            //{
            //    Console.WriteLine("Enter number : ");
            //    numbers[i] = int.Parse(Console.ReadLine());
            //}
            //int total = 0;
            //for (int i = 0; i < n; i++)
            //{
            //    total += numbers[i];
            //}
            //float average = (float)total / n;
            //Console.WriteLine("The average is: " + average);


            //Task 2
            Console.WriteLine("Enter a number");
            float number = float.Parse(Console.ReadLine());

            if (number % 2 == 0)
            {
                Console.WriteLine("The number is Even");
            }

            else
            {
                Console.WriteLine("The number is Odd");
            }

        }
    }
}
