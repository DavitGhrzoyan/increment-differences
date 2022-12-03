using System;

namespace __x_and_x____diference
{
    class Program
    {
        static void Main(string[] args)
        {
            int value = 5;
            int sum = value++ + ++value + ++value - --value - value--;
            //          5     +    7    +    8    -    7     -  7
            //value? = 6
            //sum ? =  6
            //sum = 5; without post pre

            // if it is pre then the sign is before  ->   force action;
            // if it is post then the sign is after  ->   snooze action

            Console.WriteLine("The value is " + value + " and sum is " + sum);
        }
    }
}
