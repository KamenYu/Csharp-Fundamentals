using System;
namespace foreign_languages
{
    class Program
    {
        static void Main(string[] args)
        {        
            string country = Console.ReadLine();

            switch (country)
            {
                case "England":
                case "USA":
                    Console.WriteLine("English");                 //English is spoken in England and USA; 
                    break;
                case "Spain":
                case "Argentina":
                case "Mexico":
                    Console.WriteLine("Spanish");                    //Spanish is spoken in Spain, Argentina and Mexico;
                    break;
                default:
                    Console.WriteLine("unknown");                       //for the others "unknown"
                    break ;
            }
        }
    }
}
