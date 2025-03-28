using System;

namespace Task
{
    class Program
    {
        static int FindSecondLargest(int[] arr)
        {
            if (arr == null || arr.Length < 2)
            {
                throw new ArgumentException("Array must have at least two elements.");
            }

            int largest = int.MinValue;
            int secondLargest = int.MinValue;

            foreach (int num in arr)
            {
                if (num > largest)
                {
                    secondLargest = largest;
                    largest = num;
                }
                else if (num > secondLargest && num != largest)
                {
                    secondLargest = num;
                }
            }

            if (secondLargest == int.MinValue)
            {
                throw new InvalidOperationException("No second largest element found.");
            }

            return secondLargest;
        }

        static void Main(string[] args)
        {
            int[] numbers = { 10, 20, 4, 45, 99, 99, 5 };
            int secondLargest = FindSecondLargest(numbers);

            Console.WriteLine("The second largest element in the array is: " + secondLargest);
            Console.ReadLine();
        }
    }
}


