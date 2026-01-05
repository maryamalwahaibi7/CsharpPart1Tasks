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
            //Console.WriteLine("Enter a number");
            //float number = float.Parse(Console.ReadLine());

            //if (number % 2 == 0)
            //{
            //    Console.WriteLine("The number is Even");
            //}

            //else
            //{
            //    Console.WriteLine("The number is Odd");
            //}



            ////Task 3
            //Console.WriteLine("Enter how many numbers you need :");
            //int n = int.Parse(Console.ReadLine());

            //int[] numbers = new int[n];

            //for (int i = 0; i < n; i++)
            //{
            //    Console.WriteLine("Enter number : ");
            //    numbers[i] = int.Parse(Console.ReadLine());
            //}

            //// Set smallest as the first number in the list
            //int smallest = numbers[0];

            //// Check each number in the list
            //for (int i = 1; i < n; i++)
            //{
            //    if (numbers[i] < smallest)
            //    {
            //        smallest = numbers[i];
            //    }
            //}

            //// Output the result
            //Console.WriteLine("The smallest number is: " + smallest);


            //Task 4
            Console.WriteLine("Enter how many numbers you need:");
            int n = int.Parse(Console.ReadLine());

            int[] numbers = new int[n];

            int positiveCount = 0;
            int negativeCount = 0;

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Enter number:");
                numbers[i] = int.Parse(Console.ReadLine());

                if (numbers[i] > 0)
                {
                    positiveCount++;
                }
                else if (numbers[i] < 0)
                {
                    negativeCount++;
                }
            }

            // Output the results
            Console.WriteLine("Number of positive numbers: " + positiveCount);
            Console.WriteLine("Number of negative numbers: " + negativeCount);
        }
    }
}
