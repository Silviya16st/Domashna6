using System;

namespace Zadd
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedList<int> numbers = new LinkedList<int>();             
            AddNumbers(numbers);
             
            LinkedList<int> evenNumbers = new LinkedList<int>();
            LinkedList<int> oddNumbers = new LinkedList<int>();
            Razdelyane(numbers, evenNumbers, oddNumbers);

          
            Console.WriteLine("Numbers: ");
            PrintList(numbers);
            Console.WriteLine();
            
            Console.WriteLine("EvenNumbers: ");
            PrintList(evenNumbers);
            Console.WriteLine();
           
            Console.WriteLine("OddNumbers: ");
            PrintList(oddNumbers);
        }

        public static void AddNumbers(LinkedList<int> numbers)
        {
            
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Enter number to be added");
                int number = int.Parse(Console.ReadLine());
                numbers.AddLast(number);
            }
            
            
        }

        public static void Razdelyane(LinkedList<int> numbers, LinkedList<int> evenNumbers, LinkedList<int> oddNumbers)
        {
            foreach (var item in numbers)
            {
                if (item % 2 == 0)
                {
                    evenNumbers.AddLast(item);
                }
                else
                {
                    oddNumbers.AddLast(item);
                }
            }
        }

        public static void PrintList(LinkedList<int> nums)
        {
            
            foreach (var num in nums)
            {
                Console.WriteLine(string.Join(", ", nums));
            }

           

        }
    }
    
}