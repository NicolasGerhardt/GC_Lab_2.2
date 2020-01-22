using System;

namespace GC_Lab_2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Learn your Squares & Cubes!");
            bool isLooping = true;
            int maxValueIntCubeRoot = (int) Math.Pow(int.MaxValue, (1.0 / 3.0));

            while (isLooping)
            {

                bool validInput = false;
                int endingNumber = int.MinValue;

                do
                {
                    Console.WriteLine();
                    Console.WriteLine("Please give me an integer greater than 0 and press enter: ");
                    string input = Console.ReadLine();
                    Console.WriteLine();
                    var isInt = int.TryParse(input, out endingNumber);

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


                Console.WriteLine("Number\t\tSquared\t\tCubed");
                Console.WriteLine("=======\t\t========\t======");

                for (int i = 0; i <= endingNumber; i++)
                {
                    Console.WriteLine($"{i}\t\t{i * i}\t\t{i * i * i}");


                }

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
