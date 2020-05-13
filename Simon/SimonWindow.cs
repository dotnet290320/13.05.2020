using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simon
{
    public partial class SimonWindow : Form
    {
        // preferences
        // later will be in configuration file
        const int MAX_NUMBER_OF_RANDOM = 4;
        const int TIME_BEFORE_CLEAR_NUMBERS = 1000;
        const int SEQUENCE_MAX_LENGTH = 8;
        const bool CHEAT_MODE = true;
        const string WIN_STRING = "You won!! what a great memory!!! you're the best!";
        const string LOOSE_STRING = "Wrong ..... sorry ....";
        const string WRONG_NUMBER_STRING = "You chose {0} the correct number was {1}";
        const string START_USER_INPUT_STRING = "Please start the sequence...";
        const string DO_YOU_WANT_TO_PLAY_AGAIN_STRING = "Do you want to play again? (Y-yes, N-no)";

        const int RED = 1;
        const int YELLOW = 2;
        const int BLUE = 3;
        const int GREEN = 4;

        int[] sequence_numbers;

        Random random_generator = new Random();

        public SimonWindow()
        {
            InitializeComponent();
        }

        private void GenerateRandomSequence()
        {
            sequence_numbers = new int[SEQUENCE_MAX_LENGTH];

            for (int i = 0; i < SEQUENCE_MAX_LENGTH; i++)
            {
                sequence_numbers[i] = random_generator.Next(1, MAX_NUMBER_OF_RANDOM + 1);
            }
        }

        private void DrawThreeTimes()
        {
            for (int i = 1; i <= 3; i++)
            {
                redPnl.BackColor = Color.Black;
                Thread.Sleep(500);
                redPnl.BackColor = Color.Red;
                Thread.Sleep(500);
            }
        }

        private void DrawEntireSequence()
        {
            for (int i = 0; i < sequence_numbers.Length; i++)
            {
                //const int RED = 1;
                //const int YELLOW = 2;
                //const int BLUE = 3;
                //const int GREEN = 4;

                switch (sequence_numbers[i])
                {
                    case RED:
                        redPnl.BackColor = Color.Black;
                        Thread.Sleep(500);
                        redPnl.BackColor = Color.Red;
                        break;
                    case YELLOW:
                        yellowPnl.BackColor = Color.Black;
                        Thread.Sleep(500);
                        yellowPnl.BackColor = Color.Yellow;
                        break;
                    case BLUE:
                        bluePnl.BackColor = Color.Black;
                        Thread.Sleep(500);
                        bluePnl.BackColor = Color.Blue;
                        break;
                    case GREEN:
                        Color saveColor = greenPnl.BackColor;
                        greenPnl.BackColor = Color.Black;
                        Thread.Sleep(500);
                        greenPnl.BackColor = saveColor;
                        break;
                }

                Thread.Sleep(500);
            }

        }

        private void startBtn_Click(object sender, EventArgs e)
        {
            GenerateRandomSequence();

            // generate new worker
            //Task.Run(new Action( DrawThreeTimes ));

            Task.Run(new Action(DrawEntireSequence));

            // multi-threaded
            // thread -- worker
            // ui thread 

            /*
            for (int i = 0; i < sequence_numbers.Length; i++)
            {

            }
            */
        }
    }
}
