using System;

namespace NumberManipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            int myInt = 12;
            Console.WriteLine(myInt);
            myInt *= myInt;
            myInt += 14;
            myInt -= 3;
            Console.WriteLine(myInt);

            Console.WriteLine("Please enter an integer");
            Console.WriteLine(Method1());
        }

        public static string Method1(){
            string input = Console.ReadLine();
            int output;
            if(Int32.TryParse(input, out output)){
                output = int.Parse(input);
            } else {
                Console.WriteLine("Please enter a proper integer next time..");
                return null;
            }
            output *= output;
            output += 14 - 3;
            return "The value returned is " + output;
        }
    }
}
