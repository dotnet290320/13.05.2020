using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Simon1305_console
{
    class Program
    {
        // preferences
        // later will be in configuration file
        const int MAX_NUMBER_OF_RANDOM = 4;
        const int TIME_BEFORE_CLEAR_NUMBERS = 1000;
        const int SEQUENCE_MAX_LENGTH = 3;
        const bool CHEAT_MODE = true;
        const string WIN_STRING = "You won!! what a great memory!!! you're the best!";
        const string LOOSE_STRING = "Wrong ..... sorry ....";
        const string WRONG_NUMBER_STRING = "You chose {0} the correct number was {1}";
        const string START_USER_INPUT_STRING = "Please start the sequence...";
        const string DO_YOU_WANT_TO_PLAY_AGAIN_STRING = "Do you want to play again? (Y-yes, N-no)";

        static int[] sequence_numbers;

        static Random random_generator = new Random();

        static void Main(string[] args)
        {
            while (true)
            {
                GenerateRandomChain();

                bool won = GameLoop();
                PrintEndOfGameStatus(won);

                string answer = AskUserIfHeWantsToPlayAgain();

                if (answer == "N")
                    break;
            }
        }

        private static void PrintEndOfGameStatus(bool won)
        {
            if (won)
            {
                Console.WriteLine(WIN_STRING);
            }
            else
            {
                Console.WriteLine(LOOSE_STRING);
            }
        }

        /// <summary>
        /// This function asks the user if he wants to play again
        /// </summary>
        /// <returns>Y - if yes, N - if no</returns>
        private static string AskUserIfHeWantsToPlayAgain()
        {
            string answer;

            Console.WriteLine(DO_YOU_WANT_TO_PLAY_AGAIN_STRING);

            do
            {
                answer = Console.ReadLine();
            }
            while (answer != "Y" && answer != "N");

            return answer;
        }

        /// <summary>
        /// This is the game main loop which presents the numbers in each round
        /// gets the user input and check it
        /// will be ended if the user won or loss
        /// </summary>
        /// <returns>true - if user won, else false</returns>
        private static bool GameLoop()
        {
            bool wasUserRightWithAllOfHisNumbers = false;

            int round_number = 0;

            do
            {
                round_number++;

                PresentCurrentChainToUserForThisRound(round_number);

                Thread.Sleep(TIME_BEFORE_CLEAR_NUMBERS);

                if (!CHEAT_MODE)
                {
                    Console.Clear();
                }

                Console.WriteLine(START_USER_INPUT_STRING);

                wasUserRightWithAllOfHisNumbers = GetAndCheckUserInput(round_number);
            }
            while (wasUserRightWithAllOfHisNumbers && round_number < SEQUENCE_MAX_LENGTH); // while isGameOver == false

            if (wasUserRightWithAllOfHisNumbers)
                return true; // won

            return false; // loss

            // short version:
            // return wasUserRightWithAllOfHisNumbers;
        }

        static int InputNumberFromUserInRange(string message, int min, int max)
        {
            int number = 0;
            do
            {
                Console.WriteLine(message);
            }
            while (int.TryParse(Console.ReadLine(), out number) == false || number < min || number > max);

            return number;
        }

        /// <summary>
        /// This will read line the user input for all of the numbers of the specific 
        /// round (given parameter).
        /// The input will continue until all numbers are correct or there was a mistake
        /// </summary>
        /// <param name="round_number">current number</param>
        /// <returns>true if all numbers were correct, else returns false</returns>
        private static bool GetAndCheckUserInput(int round_number)
        {
            for (int i = 1; i <= round_number; i++)
            {
                int number_from_user = InputNumberFromUserInRange($"{i}: ", 1, MAX_NUMBER_OF_RANDOM);
                if (number_from_user != sequence_numbers[i - 1])
                {
                    Console.WriteLine("Wrong ... ");
                    return false;
                }
            }
            return true;
        }

        private static void PresentCurrentChainToUserForThisRound(int round_number)
        {
            Console.WriteLine("================");
            for (int i = 1; i <= round_number; i++)
            {
                Console.WriteLine(sequence_numbers[i - 1]);
            }
            Console.WriteLine("================");

        }

        private static void GenerateRandomChain()
        {
            sequence_numbers = new int[SEQUENCE_MAX_LENGTH];

            for (int i = 0; i < SEQUENCE_MAX_LENGTH; i++)
            {
                sequence_numbers[i] = random_generator.Next(1, MAX_NUMBER_OF_RANDOM + 1);
            }
        }




    }
}
