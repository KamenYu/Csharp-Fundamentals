using System;

namespace ValidUsernames
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] test = Console.ReadLine().Split(", ");

            for (int i = 0; i < test.Length; i++)
            {
                if (test[i].Length >= 3 && test[i].Length <= 16)
                {
                    bool isValid = true;
                    for (int j = 0; j < test[i].Length; j++)
                    {
                        if ((char.IsLetterOrDigit(test[i][j]) || test[i][j] == '-' || test[i][j] == '_') == false )
                        {
                            isValid = false;
                        }
                    }

                    if (isValid)
                    {
                        Console.WriteLine(test[i]);
                    }
                }                
            }
        }
    }
}
