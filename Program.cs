using System;

namespace SorboAssignment4

{
    class Program
    {
        static void Main(string[] args)
        {
            string result;

            do
            {
                result = DisplayMenu();
                Run(result);
            }
            while (result.ToUpper() != "E");

            Console.WriteLine(" Good Bye...");

        }
        public static string DisplayMenu()
        {

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Rob Sorbo\nHomework Assignment 4");
            Console.WriteLine();
            Console.WriteLine("Hit [1] to run Exercise 1.");
            Console.WriteLine("Hit [2] to run Exercise 2.");
            Console.WriteLine("Hit [3] to run Exercise 3.");
            Console.WriteLine("Hit [4] to run Exercise 4.");
            Console.WriteLine("Hit [5] to run Exercise 5.");

            Console.WriteLine();
            Console.WriteLine("Hit [E]: Exit;");
            Console.WriteLine();
            Console.WriteLine();

            var result = Console.ReadLine();
            return result;


        }
        private static bool Run(string exeArg)

        {
            switch (exeArg.ToLower())
            {

                case "1":
                    DoExe1();
                    return true;

                case "2":
                    DoExe2();
                    return true;

                case "3":
                    DoExe3();
                    return true;

                case "4":
                    DoExe4();
                    return true;

                case "5":
                    DoExe5();
                    return true;

                default:
                    Console.WriteLine("Exiting the Program!");
                    return true;
            }
        }
        private static void DoExe1()
        {
            Console.WriteLine("Exercise 1");


            //resource for determining capital letter: https://www.geeksforgeeks.org/c-sharp-char-isupper-method/#:~:text=Char.-,IsUpper(Char)%20Method,returns%20True%20otherwise%20return%20False.
           
            char letter=' ';    
            bool isCapital = false; //forcing it to be false so that the loop begins


            while (isCapital == false)
            {
                if (letter == '!')
                { break; }

                Console.Write("Enter an uppercase letter or ! to quit >>   ");
                letter = Convert.ToChar(Console.ReadLine());
                isCapital = char.IsUpper(letter);

                if (isCapital == true) 
                {
                    Console.WriteLine($"OK. You typed in a capital letter: {letter}");
                    break;
                }
                else
                {
                    Console.WriteLine("Sorry - that was not an uppercase letter.");
                }
            }



        }
        private static void DoExe2()
        {
            Console.WriteLine("Exercise 2");
            Console.Write("Enter a phrase >>");

            string phrase;
            phrase = Console.ReadLine();
            int vowelCount = 0, phraseLength, i;
            phraseLength = phrase.Length;

            //How I figured out the code: https://www.tutorialspoint.com/Chash-Program-to-count-vowels-in-a-string 

            for (i = 0; i < phraseLength; i++)
            {
                if (phrase[i] == 'a' || phrase[i] == 'A' || phrase[i] == 'e' || phrase[i] == 'E' || phrase[i] == 'i' || phrase[i] == 'I' || phrase[i] == 'o' || phrase[i] == 'O' || phrase[i] == 'u' || phrase[i] == 'U')
                {
                    vowelCount++;
                }


            }

            Console.WriteLine($"There are {vowelCount} vowels in {phrase}");

        }
        private static void DoExe3()
        {
            Console.WriteLine("Exercise 3");

            int numSum = 0, i;

            for (i = 0; i < 100; i++)
            {
                numSum = numSum + i;

            }
            Console.WriteLine($"Halway there...\n\tafter 100 numbers, the sum is {numSum}");
            for (i = 100; i < 201; i++)
            {
                numSum = numSum + i;
            }
            Console.WriteLine($"The sum of the integers 1 through 200 is {numSum}");

        }
        private static void DoExe4()
        {
            const string ITEM209 = "209";
            const string ITEM312 = "312";
            const string ITEM414 = "414";
            const double PRICE209 = 12.99, PRICE312 = 16.77, PRICE414 = 109.07;
            double price;
            string stockNum;

            Console.Write("Please enter the stock number of the item you want ");
            stockNum = Console.ReadLine();
            Console.WriteLine("You entered: " + stockNum);

            //the main issue in the original code was the use of && rather than ||
            while (!(stockNum == ITEM209 || stockNum == ITEM312 || stockNum == ITEM414))
            {
                Console.WriteLine("Invalid stock number. Please enter again. ");
                stockNum = Console.ReadLine();
            }

            if (stockNum == ITEM209) price = PRICE209;
            else if (stockNum == ITEM312) price = PRICE312;
            else price = PRICE414;
            Console.WriteLine("The price for item # {0} is {1}", stockNum, price.ToString("C"));

        }
        private static void DoExe5()
        {
            const double LIMIT = 1000000.00;
            const double START = 0.01;
            string inputString;
            double total;
            int howMany;
            int count;
            Console.Write("How many days do you think ");
            Console.WriteLine("it will take you to reach ");
            Console.Write("{0} starting with {1}",
               LIMIT.ToString("C"), START.ToString("C"));
            Console.WriteLine(" and doubling it every day?");
            inputString = Console.ReadLine();
            howMany = Convert.ToInt32(inputString);
            count = 0;
            total = START;


            while (total < LIMIT)
            {
                total = total * 2;
                count = count + 1;
            }


            if (howMany > count)
                Console.WriteLine("Your guess was too high.");
            else
              if (howMany < count)
                Console.WriteLine("Your guess was too low.");
            else
                Console.WriteLine("Your guess was correct.");
            Console.WriteLine("It takes {0} days to reach {1}",
               count, LIMIT.ToString("C"));
            Console.WriteLine("when you double {0} every day",
               START.ToString("C"));
        }
    }
}
