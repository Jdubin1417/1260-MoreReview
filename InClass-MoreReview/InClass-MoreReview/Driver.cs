using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InClass_MoreReview
{
    public class Driver
    {
        public static void Main()
        {
            //-----Enums-----
            Console.WriteLine("Please enter a month: ");
            string userInput = Console.ReadLine();

            Months userMonth = (Months)Enum.Parse(typeof(Months), userInput); //From string -> Month data type

            string userMonthStr = userMonth.ToString(); //From Month -> string

            //Can use internal integer values associated with enum constants as well
            Months myMonth = (Months)5; //should be May
            Console.WriteLine(myMonth);


            //string path = "E:\\Fall 2022\\1260\\myImage.jpg";
            //string path2 = "..\\..\\1260\\myImage.jpg";

            //-----Menu-----
            Menu();
        }

        public static void Menu()
        {
            string userInput;
            int x = 0;

            do
            {
                Console.WriteLine("My Menu");
                Console.WriteLine("-------");
                Console.WriteLine("1. ...");
                Console.WriteLine("2. ...");
                Console.WriteLine("3. Quit");

                Console.WriteLine("Please enter a choice from the menu:");
                userInput = Console.ReadLine();

                switch (userInput)
                {
                    case "1":
                        x = 2;
                        Console.WriteLine("Hello!");
                        break;
                    case "2":
                        Console.WriteLine("Hello from option 2");
                        Console.WriteLine(x);
                        break;
                    case "3":
                        break;
                    default:
                        Console.WriteLine("Invalid selection, please try again.");
                        break;
                }
            } while (userInput != "3");
            
        }
    }
}
