using System.Collections.Generic;

namespace CollectionAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Assignment1();
            Assignment2();
            Assignment3();
            Assignment4();
            Assignment5();
            Assignment6();
        }

        static void Assignment1()
        {
            // Create a new array or list

            // Add numbers 0-9 to the array or list using a for loop or foreach loop

            // Print the array or list
        }

        static void Assignment2()
        {
            // Create a new array or list with numbers 0-9

            // Print to the user numbers that are greater than 5 using ForEach loop
        }

        static void Assignment3()
        {
            // Ask the user for 5 integers and store them in an array or list

            // Then tell the user what the average is
            // Calculate the average using ForEach or For loop
            // There is a function that calculates the average (Average), but do not use it, calculate it manually.
            // This helps understand how the average is calculated and how the Average function works.
        }

        static void Assignment4()
        {
            // Ask the user which name they want to remove from the list
            // The user can remove a name from the list either by writing the name or a number
            // If the user writes a number, then remove the name based on the array index
            // In this case, the user can input the numbers 0,1,2
            // After this, print the list again and show that the name has been removed

            List<string> nameList = new List<string>
            {
                "Jonathan",
                "Suzi",
                "Joseph"
            };
        }

        static void Assignment5()
        {
            // Create and Print a Dictionary

            // Create a Dictionary where the keys are people's names (as strings) and values are their ages (as integers).
            // Add three people to the dictionary.
            // Print each person and their age.
        }

        static void Assignment6()
        {
            // Implement a program that allows the user to add, remove, and edit people using a dictionary.
            // First, ask the user whether they want to add, remove, or edit people.
            // Then call the correct function that implements the functionality.
            // The user can exit the program by typing "exit" if they are in the "main menu",
            // i.e., at the beginning of this function where the action is asked.

            Dictionary<string, int> personsDictionary = new Dictionary<string, int>();
            personsDictionary.Add("Jonathan", 21);
            personsDictionary.Add("Suzi", 25);
            personsDictionary.Add("Joseph", 32);

            //Implement add
            Assignment6Add(personsDictionary);

            //Implement remove
            Assignment6Remove(personsDictionary);

            //Implement edit
            Assignment6Edit(personsDictionary);

        }

        static void Assignment6Add(Dictionary<string, int> persons)
        {
            // Make a program that asks the user for a name and age. Store this result in a dictionary,
            // where the key is the name and the value is the age.

            // Then print all names and ages.

            // The user can stop adding by typing "exit"
        }

        static void Assignment6Remove(Dictionary<string, int> persons)
        {
            // Extend Assignment6 task so that the user can also remove people from the dictionary.
            // The user can remove based on either name or age.
            // The user can stop removing by typing "exit"
        }

        static void Assignment6Edit(Dictionary<string, int> persons)
        {
            // Then make a functionality where the user can edit a person's age.
            // Age can be edited if the name given by the user is found in the dictionary.
            // Then ask the user for a new age.
            // If the person is not found, print an error message.
            // Then ask the user for a name again.
            // The user can stop editing by typing "exit"
        }
    }
}