using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeExercise1_2
{
    class Menu
    {
        // bool to run do - while
        private bool running = true;
        // string used by switch statement.
        private string x;
        // list of sports to guess from
        private List<string> sportsList = new List<string>() {"Hockey", "Soccer", "Golf", "Curling", "Skateboarding", "Snowboarding", "Skiing", "Baseball", "Figure Skating", "Swimming",
            "Ice Fishing"};
        // used to keep track of what clue they are on
        int counter = 1;
        // shows chances remaining for user to guess
        int chancesRemaining = 10;
        // variable to win the game
        string winningSport = "Hockey";

        public Menu()
        {
            SwitchStatement();
        }
        // switch statement so user can interact with application. Will run untill the do while is 
        public void SwitchStatement()
        {
            do
            { 
                // runs if the uers runs out of chances. Will prompt user if they would like to play again. 
                if (chancesRemaining == 0)
                {
                    Console.WriteLine("It looks like youve ran out of chances. Play again?\n1.Yes\n2.No");
                    int playAgainInt = Validation.GetIntWithinRange(1, 2);
                    if (playAgainInt == 1)
                    {
                        chancesRemaining = 10;
                        counter = 1;
                        Validation.ConsoleClear();
                    }
                    else
                    {
                        Console.WriteLine("Well better luck next time then.");
                        running = false;
                    }
                }
                else
                {
                    // start of the game. Prompts user with the rules. 
                    Console.WriteLine("You have 10 chances to guess a random sport from this list. If the current clue is not helpful, you can request a new clue. In doing" +
                    " so you lose a chance to guess.");
                    Display();
                    Console.WriteLine("Remaining Chances: " + chancesRemaining);
                    DisplayArray(out x);
                    switch (x)
                    {
                        case "1":
                        case "Show Clue":
                            {
                                ShowClue();
                                Validation.ConsoleClear();
                            }
                            break;
                        case "2":
                        case "Show New Clue":
                            {
                                counter++;
                                chancesRemaining--;
                                ShowClue();
                                Validation.ConsoleClear();
                            }
                            break;
                        case "3":
                        case "Guess The Sport":
                            {
                                Guess();
                                Validation.ConsoleClear();
                            }
                            break;
                        case "4":
                        case "give up":
                            {
                                Console.WriteLine("Shame. The answer was Hockey.");
                                running = false;
                            }
                            break;
                        default:
                            Console.WriteLine("Please choose a valid number");
                            Validation.ConsoleClear();
                            break;
                    }
                }
            } while (running == true);
        }
        // displays the list of sports
        private void Display()
        {
            for (int i = 0; i < sportsList.Count; i++)
            {
                if(i != sportsList.Count -1)
                {
                    Console.Write($"{sportsList[i]}, ");
                }
                // used to make sure the list ends with a "." and not a ","
                else
                {
                    Console.Write($"{sportsList[i]}.");

                }
            }
            Console.WriteLine("\n\r");

        }
        // clues that will prompt pending on what number the counter is currently set to. 
        private void ShowClue()
        {
            if (counter == 1)
            {
                Console.WriteLine("The sport is done at a fast pace.");
            }
            else if (counter == 2)
            {
                Console.WriteLine("The sport is done in the cold.");
            }
            else if (counter == 3)
            {
                Console.WriteLine("The sport requires hand eye coordination.");
            }
            else if (counter == 4)
            {
                Console.WriteLine("The sport is professionally played as a team.");
            }
            else if (counter == 5)
            {
                Console.WriteLine("The Sport is done on ice.");
            }
            else if (counter == 6)
            {
                Console.WriteLine("The Sport is done on skates.");
            }
            else if (counter == 7)
            {
                Console.WriteLine("You can take some hard hits in this sport.");
            }
            else if (counter == 8)
            {
                Console.WriteLine("This sport doesnt use a ball, but it does have a goal.");
            }
            else if (counter == 9)
            {
                Console.WriteLine("This sport uses a puck.");
            }
            else if (counter == 10)
            {
                Console.WriteLine("If you dont know it by now...Then...Dang... I dont know. Wayne Gretzky played this game.");
            }
        }
        // method for getting the user to guess. If user doesnt user proper casing with the winning number, the game will let them know they are close. 
        public void Guess()
        {
            Console.WriteLine("What is your guess?");
            Console.WriteLine("Make sure the first letter of your guess is capitolized.");
            string guess = Validation.NullOrEmpty(Console.ReadLine());
            if(guess == winningSport)
            {
                Console.WriteLine("Congrats! You've won the game!");
                running = false;
                
            }
            else if (guess == "hockey")
            {
                Console.WriteLine("You're close! Check the format of your last choice.");
            }
            else
            {
                Console.WriteLine("Ouch. That answer was not correct. Please guess again or ask for a new clue.");
                chancesRemaining--;
            }

        }
        // method to display the menu.
        public string DisplayArray(out string x)
        {// make two methods. one that inputs for array two that outputs user input
            string[] menuArray = { "Show Current Clue", "Show New Clue","Guess The Sport", "Give Up" };
            for (int i = 0; i < menuArray.Length; i++)
            {
                Console.WriteLine($"{i + 1} {menuArray[i]}");
            }
            Console.WriteLine("Please enter the choice you would like to run.");
            string userChoice = Console.ReadLine();
            // validates user string so they can type any case
            userChoice = userChoice.ToLower().Trim();
            return x = userChoice;
        }
    }
}

