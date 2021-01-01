using System;

namespace common_elements
{
    class Program
    {
        static void Main(string[] args)
        {
            //compare the elements of the second array to the elements of the first

            string[] arr1 = Console.ReadLine()
                .Split();
            string[] arr2 = Console.ReadLine()
                .Split();
            string result = "";

            foreach (string word1 in arr2)    
            {
                foreach  (string word2 in arr1)     // checks if word1 from arr2 equals any of the words in arr1
                {
                    if(word1 == word2)
                    {
                        result += word1 + " ";
                    }
                }
            }
            Console.WriteLine(result);
        }
    }
}
