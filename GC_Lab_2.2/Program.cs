using System;

namespace GC_Lab_2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Learn your Squares & Cubes!");
            bool isLooping = true;
            var maxValueIntCubeRoot = (Int64)Math.Pow(Int64.MaxValue, (1.0 / 3.0));

            while (isLooping)
            {

                bool validInput = false;
                var endingNumber = Int64.MinValue;

                do
                {
                    Console.WriteLine();
                    Console.WriteLine("Please give me an integer greater than 0 and press enter: ");
                    string input = Console.ReadLine();
                    Console.WriteLine();
                    var isInt = Int64.TryParse(input, out endingNumber);

                    if (!isInt)
                    {
                        Console.WriteLine("That is not an integer, try again.");
                    }
                    else if (endingNumber <= 0)
                    {
                        Console.WriteLine("That number is not greater than 0, try again.");
                    }
                    else if (endingNumber > maxValueIntCubeRoot)
                    {
                        Console.WriteLine("the maximum cube/square of this number is too big for me to calculate, try again.");
                    }
                    else
                    {
                        validInput = true;
                    }

                } while (!validInput);

                Console.WriteLine("|==============================================================|");
                Console.WriteLine(String.Format("|{0,20}|{1,20}|{2,20}|", "Number", "Square", "Cube"));
                Console.WriteLine("|====================|====================|====================|");

                for (Int64 i = 0; i <= endingNumber; i++)
                {
                    var num = i;
                    var square = i * i;
                    var cube = i * i * i;
                    Console.WriteLine(String.Format("|{0,20}|{1,20}|{2,20}|", num, square, cube));


                }
                Console.WriteLine("|==============================================================|");

                bool showGoAgainPromptLoop = true;
                while (showGoAgainPromptLoop)
                {

                    Console.Write("\nDo you want to go again? (y/n): ");
                    var keyPressed = Console.ReadKey();
                    Console.WriteLine();

                    if (keyPressed.KeyChar.ToString().ToLower() == "y")
                    {
                        showGoAgainPromptLoop = false;
                        Console.WriteLine("\nSounds good! Lets Go!\n");
                    }
                    else if (keyPressed.KeyChar.ToString().ToLower() == "n")
                    {
                        showGoAgainPromptLoop = false;
                        isLooping = false;
                    }
                    else
                    {
                        Console.WriteLine("not a valid responce");
                    }

                }

            }

            Console.WriteLine("Thank you for your time!");

        }
    }
}
