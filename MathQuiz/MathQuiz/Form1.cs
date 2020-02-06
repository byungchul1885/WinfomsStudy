using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

#pragma warning disable IDE1006 // Naming Styles

namespace MathQuiz
{
    public partial class MainForm : Form
    {
        readonly Random randomizer = new Random();

        int addend1;
        int addend2;
        int timeLeft;
        Color backupColor;

        public MainForm()
        {
            InitializeComponent();
            backupColor = timeLabel.BackColor;
        }

        public void StartTheQuiz()
        {
            timeLabel.BackColor = backupColor; 

            addend1 = randomizer.Next(51);
            addend2 = randomizer.Next(51);

            plusLeftLabel.Text = addend1.ToString();
            plusRightLabel.Text = addend2.ToString();

            sumNumericUpDown.Value = 0;

            timeLeft = 30;
            timeLabel.Text = "30 seconds";
            timer1.Start();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            StartTheQuiz();
            startButton.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (CheckTheAnswer())
            {
                timer1.Stop();
                MessageBox.Show("You got all the answers right!", "Congratulations!");
                startButton.Enabled = true;
            }
            else if (timeLeft > 0)
            {
                timeLeft--;
                timeLabel.Text = timeLeft + " seconds";

                if (timeLeft <= 5)
                {
                    timeLabel.BackColor = Color.Red;
                }
            }
            else
            {
                timer1.Stop();
                timeLabel.Text = "Time's up!";
                MessageBox.Show("You didn't finish in time.", "Sorry!");

                sumNumericUpDown.Value = addend1 + addend2;

                startButton.Enabled = true;
            }
        }


        public bool CheckTheAnswer()
        {
            if (addend1 + addend2 == sumNumericUpDown.Value)
                return true;
            else
                return false;
        }

        private void NumericUpDown_Enter(object sender, EventArgs e)
        {
            // Select the whole answer in the NumericUpDown control.

            if (sender is NumericUpDown answerBox)
            {
                int lengthOfAnswer = answerBox.Value.ToString().Length;
                answerBox.Select(0, lengthOfAnswer);

                Debug.WriteLine($"lengthOfAnswer:{lengthOfAnswer} value:{answerBox.Name}");
            }
        }
    }
}
