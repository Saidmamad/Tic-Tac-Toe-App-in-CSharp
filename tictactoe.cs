using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace wf_tictactoe
{
    public partial class Form1 : Form
    {
        bool turn = true; // true = x turn; false = y turn 
        int turn_count = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("By Saidmamad", "Tic tac toe about");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button_click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (turn)
                b.Text = "x";
            else
                b.Text = "o";

            turn = !turn;
            b.Enabled = false;
            turn_count++;
            checkForWinner();

        }

        private void checkForWinner()
        {
            bool there_is_a_winner = false;

            // HORIZONTAL CHECKS
            if ((A1.Text == A2.Text) && (A2.Text == A3.Text)&& (!A1.Enabled))
                there_is_a_winner = true;
            else if ((B1.Text == B2.Text) && (B2.Text == B3.Text))
                there_is_a_winner = true;
            else if ((C1.Text == C2.Text) && (C2.Text == C3.Text))
                there_is_a_winner = true;

            if (there_is_a_winner)
            {
                disbaleButtons();
                string winner = "";
                if (turn)
                    winner = "o";
                else
                    winner = "x";

                MessageBox.Show(winner + " Wins!", "Yay");

            }
            else
            {
                if (turn_count == 9)
                    MessageBox.Show("It was a draw","BUmmer");
            }
        }


        private void disbaleButtons() 
        {
            try
            {

                foreach (Control c in Controls)
                {
                    Button b = (Button)c;
                    b.Enabled = false;
                }
            }
            catch { }
        }

    }
}
