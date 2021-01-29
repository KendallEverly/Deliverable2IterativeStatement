using System;

namespace Deliverable2IterativeStatement
{
    class Program
    {
        static void Main(string[] args)
        {
            //get user input
            Console.WriteLine("Enter an integer value between 1 and 100 to execute an iterative statement");
            //try for catch block for user input
            try
            {
                //gather user input
                string input = Console.ReadLine();
                //parsed input as integar
                int value_of_input = int.Parse(input);
                //if value is between 1 and 100 execute a loop
                if ((value_of_input > 0) && (value_of_input <= 100))
                {
                    Console.WriteLine("executing for a loop");
                    for (int i=0; i < value_of_input; i++)
                    {
                        Console.WriteLine("You have entered " + value_of_input.ToString() + " This is the current integer value in the loop" + i.ToString());
                    }
                    //exit the program
                    Console.WriteLine("Press any key to exit the program");
                    //pause before key entry
                    Console.ReadKey(true);
                }
                //if the user does not enter correct int
                else
                {
                    Console.WriteLine("Please enter an integer between 1 and 100");
                }
            }
            //end of try
            catch
            {
                Console.WriteLine("Please re-enter an integer value and then run the program again");
                Console.WriteLine("Press any key to exit the program");
                Console.ReadKey(true);
            }
            //end of catch
        }
        //end of main
    }
    //end of class
}
//end of namespace
