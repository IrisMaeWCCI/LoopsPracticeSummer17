using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopsPracticeSummer17
{
    class Program
    {
        static void Main(string[] args)
        {
            //When would you use a loop?
            //Why would you use a loop?
            //Nested loops
            //Infinite Loops
            //Keywords break and continue
            //for loops
            //for each loops
            //while loops
            //do-while loops
            //automation, printing things out that have to be done more than once, meeting a certain condition over and over, repeated execution of a chunk of code over and over, clock- a nested loop
            //for loop can be used for both counting and...iterating through an array (or some other collection type) 
            //for (initializer; condition; updater)
            //{
            //  Do something
            //}

            //Example 1
            // int i;
            //if we don't set this correctly we will have an infinite loop
            for(int counter = 15; counter>0; counter--)
            {
                Console.WriteLine(counter);
            }
            // examples comparison your counting variable i or counter
        
            for (int i = 15; i > 0; i--)
            {
                Console.WriteLine(i);
            }
            // Console.WriteLine("After the loop has tun, i now has the calue of " + i);
            //Example 2
            for (int i = 50; i <= 100; i++)
            {
                Console.WriteLine(i);
            }

            //Example 3
            string greeting = "\nMy name is Little Bill.";
            //The.Split()method takes a string and turns it into an array of smaller strings(substrings). It defaults the split on spaces.
            string[] wordsInGreeting = greeting.Split();
            //for loop to print the words
            //instead of doing console.write do this loop in order to print on other lines
            for (int i = 0; i < wordsInGreeting.Length; i++) 
            {
                Console.WriteLine("\n"+ wordsInGreeting[i]);
            }
            //Practice Problems 
            //1.Create an array called days with the elements Monday, Tuesday, and Wednesday.
            //  Using a For Loop, print the elements of the days array.

            //2.Start with the string "Once upon a time" and create an array called
            //  storyWords using the Split method. Reverse the order of the elements in
            //  the array and using a For Loop, print each word

            //3.Add the product (multiplication) of 1 through 10 using a For Loop
            //  Print the product to the screen

            //1.
            string[] days = { "Monday", "Tuesday", "Wednesday" };
            for (int counter = 0; counter < 3; counter++)
            {
                Console.WriteLine( days[counter]);
                //when you just have cw (counter) you get the counter. 
                //you must place days on the outside to indicate you want the contents sitting at each of those indeces to be printed to the screen
            }
            //2.
            string storyLine = "Once upon a time";
            string[] storyWords = storyLine.Split();
            Console.WriteLine(storyWords);

            //3.
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int product = numbers[0];
            for (int i = 0; i <numbers.Length; i++)
            {
                product = product * numbers[i];
                Console.WriteLine(product);
            }
            //Another example of problem 3
            int productt = 1;
            for (int i = 1; i <=10; i++)
            {
                product = product * 1;
                Console.WriteLine();
                Console.WriteLine(product);
            }

            //Another Example
            string[] firstMonths = { "Jan", "Feb", "Mar", "Apr", "May", "Jun" };
            //Foreach always begins with keyowrd foreach
            foreach(string month in firstMonths)
            {
                Console.WriteLine(month);
            }
            //foreach loops allow the temporary cariable to "know" to assign
            //itself to each element in the collection (like an array), one at a time
            //Create an array of 6 musicians (bans or solo artists)
            //Using a foreach loop, print each musician's name'
            string[] musicians = { "The Clash", "Tiger Army", "Justin Bieber", "The Scissor Sisters", "Bach" };
            foreach(string musician in musicians)
            {
                Console.WriteLine(musician);
            }
            //While loop is used when you want a chunk of code to run only if a
            //condition is MethodAccessException first
            //While something is true, do this thing
            Console.WriteLine("What is your first name?");
            string firstName = Console.ReadLine();
            while(firstName .ToUpper() == "DANIEL")
            {
                Console.WriteLine("I love that name!");
                break;
            }

        }
    }
}
