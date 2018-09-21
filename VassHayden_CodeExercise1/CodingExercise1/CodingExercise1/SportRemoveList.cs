using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingExercise1
{
    class SportRemoveList
    {
        // variable that runs the switch statement
        private bool running = true;
        private bool temp = true;
        // user input off of the display array method that tells the switch statement to run. 
        private string x;
        // list of sports
        private List<string> sportsList = new List<string>() {"Hockey", "Soccer", "Golf", "Curling", "Skateboarding", "Snowboarding", "Skiing", "Baseball", "Football", "Swimming",
            "Rugby", "Lacrosse", "Rowing", "Boxing", "Wrestling", "Water Polo", "Hurling", "Basketball", "Fencing", "Cricket"};
        public SportRemoveList()
        {
            SwitchStatement();
        }

        public void SwitchStatement()
        {
            // switch statement that runs off a bool. Will continue to run until the bool variable is switch to false (option 5)
            do
            {
                DisplayArray(out x);
                switch (x)
                {
                    case "1":
                    case "View all available sports":
                        {
                            DisplaySports();
                            Validation.ConsoleClear();
                        }
                        break;
                    case "2":
                    case "Alphabetize Sports List":
                        {
                            Alphabetize();
                            Validation.ConsoleClear();

                        }
                        break;
                    case "3":
                    case "View Cart":
                        {
                            ReverseAlphabetize();
                            Validation.ConsoleClear();

                        }
                        break;
                    case "4":
                    case "Remove Item From List":
                        {
                            Remove();
                            Validation.ConsoleClear();
                        }
                        break;
                    case "5":
                    case "Exit":
                        {
                            running = false;
                        }
                        Console.WriteLine("good bye");
                        running = false;
                        break;
                    default:
                        Console.WriteLine("Please choose a valid number");
                        Validation.ConsoleClear();
                        break;
                }
            } while (running == true);
        }
        // displays all the sports in the sports list
        private void DisplaySports()
        {
            EmptySportsLIst(temp);
            if (temp == true)
            {
                foreach (string sport in sportsList)
                {
                    Console.WriteLine(sport);
                }
            }

        }
        // alphabetizes the list of sports then prints it to the console. 
        private void Alphabetize()
        {
            sportsList.Sort();
            DisplaySports();

        }
        // sorts the list alphabetically, then reverses it. Prints to the conosole all the sports but in reverse alphabetical
        private void ReverseAlphabetize()
        {
            sportsList.Sort();
            sportsList.Reverse();
            DisplaySports();

        }
        private void Remove()
        {
            // tells user there are no other items to remove from the list.
            if (sportsList.Count != 0)
            {
                Random random = new Random();
                int temp = random.Next(0, sportsList.Count);
                Console.WriteLine($"{sportsList.ElementAt(temp)} has been removed from the list. There are {sportsList.Count -1} sports left in the list.");
                sportsList.RemoveAt(temp);
            }
            else
            {
                Console.WriteLine("No more sports to show.");
            }

        }
        // bool to validate if the list is empty or not.
        private bool EmptySportsLIst(bool temp)
        {
            if (sportsList.Count == 0)
            {
                Console.WriteLine("there are no more sports to show");
                return temp = false;
            }
            else
            {
                return temp = true;
            }
        }
        // prints array to console. switch statement operates off input.
        public string DisplayArray(out string x)
        {// make two methods. one that inputs for array two that outputs user input
            string[] menuArray = { "View All Available Sports", "Alphabetize Sports List", "Reverse Alphabetize Sports List", "Remove Item From List", "Exit" };
            for (int i = 0; i < menuArray.Length; i++)
            {
                Console.WriteLine($"{i + 1} {menuArray[i]}");
            }
            Console.WriteLine("Please enter the number you would like to run.");
            string userChoice = Console.ReadLine();
            // validates user string so they can type any case
            userChoice = userChoice.ToLower().Trim();
            return x = userChoice;
        }
    }
}

