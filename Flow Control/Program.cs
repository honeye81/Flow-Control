using System;

class Program
{
    static void Main(string[] args)
    {
        // booln to keep the program running until the user chooses to exit
        bool keepRunning = true;

        // Main menu loop
        while (keepRunning)
        {
            Console.Clear(); // Clear the console every time the menu is shown
            Console.WriteLine("Welcome to the main menu!");
            Console.WriteLine("Select an option by typing a number:");
            Console.WriteLine("1 - Youth or Senior");
            Console.WriteLine("2 - Calculate the price for a group");
            Console.WriteLine("3 - Repeat text ten times");
            Console.WriteLine("4 - The third word");
            Console.WriteLine("0 - Exit the program");
            Console.Write("Your choice: ");

            string input = Console.ReadLine();

            switch (input)
            {
                case "0":
                    keepRunning = false; // Exit the loop
                    Console.WriteLine("Exiting the program.");
                    break;

                case "1":
                    YouthOrSenior();
                    break;

                case "2":
                    CalculateGroupPrice();
                    break;

                case "3":
                    RepeatTextTenTimes();
                    break;

                case "4":
                    TheThirdWord();
                    break;

                default:
                    Console.WriteLine("Invalid input, please try again.");
                    break;
            }
            Console.WriteLine("\nPress any key to continue...");
            Console.ReadKey();
        }
    }

    static void YouthOrSenior()
    {
        Console.Write("Enter your age: ");
        string ageInput = Console.ReadLine();

        if (int.TryParse(ageInput, out int age))
        {
            if (age < 5 || age > 100)
            {
                Console.WriteLine("Free entry for children under 5 and seniors over 100!");
            }
            else if (age < 20)
            {
                Console.WriteLine("Youth price: 80 SEK");
            }
            else if (age > 64)
            {
                Console.WriteLine("Senior price: 90 SEK");
            }
            else
            {
                Console.WriteLine("Standard price: 120 SEK");
            }
        }
        else
        {
            Console.WriteLine("Invalid input, please enter a valid age.");
        }
    }

    static void CalculateGroupPrice()
    {
        Console.Write("How many people are in your group? ");
        string numberOfPeopleInput = Console.ReadLine();

        if (int.TryParse(numberOfPeopleInput, out int numberOfPeople))
        {
            int totalCost = 0;

            for (int i = 1; i <= numberOfPeople; i++)
            {
                Console.Write($"Enter the age for person {i}: ");
                string ageInput = Console.ReadLine();

                if (int.TryParse(ageInput, out int age))
                {
                    if (age < 5 || age > 100)
                    {
                        Console.WriteLine("Free entry.");
                    }
                    else if (age < 20)
                    {
                        Console.WriteLine("Youth price: 80 SEK");
                        totalCost += 80;
                    }
                    else if (age > 64)
                    {
                        Console.WriteLine("Senior price: 90 SEK");
                        totalCost += 90;
                    }
                    else
                    {
                        Console.WriteLine("Standard price: 120 SEK");
                        totalCost += 120;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input, please enter a valid age.");
                    i--; // Go back and ask for age again
                }
            }

            Console.WriteLine($"\nTotal number of people: {numberOfPeople}");
            Console.WriteLine($"Total cost for the group: {totalCost} SEK");
        }
        else
        {
            Console.WriteLine("Invalid input, please enter a valid number of people.");
        }
    }

    static void RepeatTextTenTimes()
    {
        Console.Write("Enter some text to repeat: ");
        string input = Console.ReadLine();

        for (int i = 1; i <= 10; i++)
        {
            Console.Write($"{i}. {input} ");
        }
        Console.WriteLine(); 
    }

    static void TheThirdWord()
    {
        Console.Write("Enter a sentence with at least three words: ");
        string input = Console.ReadLine();

        string[] words = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

        if (words.Length >= 3)
        {
            Console.WriteLine($"The third word is: {words[2]}");
        }
        else
        {
            Console.WriteLine("The sentence contains fewer than three words.");
        }
    }
}