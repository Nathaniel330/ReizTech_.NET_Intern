using System;

namespace consoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declare variables and then initialize to zero. 
            // initialized -1 for minutes since 'minute 60' is considered zero.
            int inputHours = 0; int inputMinutes = -1;


            // Display title as the C# console calculator app.
            Console.WriteLine("\nTest 1: Console Clock Angle Calculator in C#");
            Console.WriteLine("--------------------------------------------\n");


            // Ask the user to type the 'Hour'.
            while (inputHours < 1 || inputHours > 12)
            {
                Console.WriteLine("Type a number (HOUR) from 1 - 12, and then press Enter");
                inputHours = Convert.ToInt32(Console.ReadLine());
            }


            // Ask the user to type the 'Minute'.
            while (inputMinutes < 0 || inputMinutes > 59)
            {
                Console.WriteLine("Type another number (MINUTE) from 0 - 59, and then press Enter");
                inputMinutes = Convert.ToInt32(Console.ReadLine());
            }


            // Display time (based on the inputs) on the console.
            Console.WriteLine($"\nThe Console Clock's Time is {(inputHours < 10 ? "0" + inputHours : inputHours)}:{(inputMinutes < 10 ? "0" + inputMinutes : inputMinutes)}\n");


            // Convert input to degrees.
            double hourDegrees = ((double)inputHours/12) * 360;
            double minuteDegrees = ((double)inputMinutes/60) * 360;


            // Logic for Lesser Angle / Output answer
            double angleOne = Math.Abs(hourDegrees - minuteDegrees);
            double angleTwo = 360 - angleOne;

            Console.WriteLine("\n--+--+--+--+--+--+--+--+--+--");
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            if (angleOne == 360 || hourDegrees == minuteDegrees)
            {
                Console.WriteLine("THE HOUR AND MINUTE HANDS ARE IN THE SAME POSITION (0 DEGREES)");
            } else if (angleOne > 180)
            {
                Console.WriteLine($"THE LESSER ANGLE IS {angleTwo} DEGREES");
            } else if (angleOne == 180)
            {
                Console.WriteLine($"THE HAND AND MINUTES HANDS {angleTwo} DEGREES APART");
            } else
            {
                Console.WriteLine($"THE LESSER ANGLE IS {angleOne} DEGREES");
            }
            Console.ResetColor();
            Console.WriteLine("--+--+--+--+--+--+--+--+--+--\n\n");


            // Test 
            // Console.WriteLine(hourDegrees);
            // Console.WriteLine(minuteDegrees);
            // Console.WriteLine(angleOne);
            // Console.WriteLine(angleTwo);

        }
    }      
}