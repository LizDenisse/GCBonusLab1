using System;

namespace BonusLab1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("   Welcome!!");
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();

            bool repeatProgram = true;
            while (repeatProgram)
            {
                Console.WriteLine("");
                Console.WriteLine("Please enter your grade");
                double grade = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine(""); //For Space

                // Grade A+------------------------------------------
                if (grade <= 100 && grade >= 95)
                {
                    Console.WriteLine("Gongratulations {0}, you got an A+ which is the highes possible grade.", name);
                    Console.WriteLine("Let's do a celebration dance now");
                }
                // Grade A ------------------------------------------
                if (grade <= 94 && grade >= 90)
                {
                    Console.WriteLine("Gongratulations {0}, you got an A-.", name);
                    Console.WriteLine("Great Job!!");
                }
                // Grade B+------------------------------------------
                if (grade <= 89 && grade >= 85)
                {
                    Console.WriteLine("Gongratulations {0}, you got an B+.", name);
                    Console.WriteLine("Great Job!!");
                }
                // Grade B------------------------------------------
                if (grade <= 84 && grade >= 80)
                {
                    Console.WriteLine("Gongratulations {0}, you got an B-.", name);
                    Console.WriteLine("Great Job!!");
                }
                // Grade C+------------------------------------------
                if (grade <= 79 && grade >= 75)
                {
                    Console.WriteLine("I am sorry {0}, you got an C+.", name);
                    Console.WriteLine("at lease you did not died, or worst; got spelled !!");
                }
                // Grade C------------------------------------------
                if (grade <= 74 && grade >= 70)
                {
                    Console.WriteLine("I am sorry {0}, you got an C-.", name);
                    Console.WriteLine("with a bit more effort, you will do better next time!!");
                }
                // Grade D+------------------------------------------
                if (grade <= 69 && grade >= 65)
                {
                    Console.WriteLine("I am sorry {0}, you got an D+.", name);
                    Console.WriteLine("with a bit more effort, you will do better next time!!");
                }
                // Grade D------------------------------------------
                if (grade <= 64 && grade >= 60)
                {
                    Console.WriteLine("I am sorry {0}, you got an D-.", name);
                    Console.WriteLine("with a bit more effort, you will do better next time!!");
                }
                // Grade F------------------------------------------
                if (grade <= 59 && grade >= 1)
                {
                    Console.WriteLine("What's wrong with you {0}.", name);
                    Console.WriteLine("You are a complete Dissapointment");
                }

                // Else------------------------------------------
                if (grade < 1 && grade > 100)
                {
                    Console.WriteLine("Sorry {0}, this is an invilid entry. The number must be between 1 and 100", name);
                }
                Console.WriteLine("");
                Console.WriteLine("Do you want to try another grade? y/n");
                string repeat = Console.ReadLine();

                while (repeat != "n" && repeat != "N" && repeat != "y" && repeat != "Y")
                {
                    Console.WriteLine("invalid entry please try again");
                    Console.ReadLine();
                }
                if (repeat == "n" || repeat == "N")
                {
                    Console.WriteLine(" Good Bye {0}", name);
                    Console.ReadLine();
                    repeatProgram = false;
                }







            }


        }
    }
}

/*
 * Task:  Convert Given names into number into letter grade 

What will the application do 

The user will enter a numerical grade  from 0 to 100.  
The application will display the corresponding letter grade 
The application will prompt the user to continue 

Build Specifications 

Assume that the user will enter valid integers for the grades 
The application should only continue if the user enters "y" or "Y"

Hints: 

Grade Ranges: 

	• A: 100-88
	• B: 87-80
	• C: 79-67
	• D: 66- 60
	• F: 60-0

Extended Challenge: Edit your grade ranges to include pluses and minuses(Ex 99-100=A+)

Consoles Preview: 

-----------------------------------------------------------
Welcome to the Letter Grade Converter!  

Enter a numberical grade: 90 
Letter Grade: A 

Continue? y/n  

*/
