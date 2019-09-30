/// changed to Alternating start "X" 1st then "O" starts next game \\\
using System;
using System.Windows.Forms;

namespace Win_tic_tac_toe
{
    public partial class Form1 : Form
    {
        // put variables, counters, strings & boolens here
        bool turn = true; //true = X turn; false = O turn
        bool against_computer = true;
        bool X1st = true; // "X" else "O" 
        private readonly bool Start = true;
        int turn_count = 0;
        private int starts = 1; // change who starts each new game

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // PLAYCOMPUTERToolStripMenuItem.PerformClick();
        }

        private void PLAYCOMPUTERToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //choose player name/s start new game with or with out computer player
            MessageBox.Show("Default play against the Computer or Change \"Player\" & \"Computer\" to your Names' to play against each other");

            P1.Text = "Player";
            P2.Text = "Computer";

        }

        // Checking for 3 in a row and button disabled
        private void CheckForWinner()
        {
            bool there_is_a_winner = false;  // set bool NO winner

            // Horizonal checks
            if ((A1.Text == A2.Text) && (A2.Text == A3.Text) && (!A1.Enabled))
                there_is_a_winner = true;
            else if ((B1.Text == B2.Text) && (B2.Text == B3.Text) && (!B1.Enabled))
                there_is_a_winner = true;
            else if ((C1.Text == C2.Text) && (C2.Text == C3.Text) && (!C1.Enabled))
                there_is_a_winner = true;

            // Vertical checks
            if ((A1.Text == B1.Text) && (B1.Text == C1.Text) && (!A1.Enabled))
                there_is_a_winner = true;
            else if ((A2.Text == B2.Text) && (B2.Text == C2.Text) && (!A2.Enabled))
                there_is_a_winner = true;
            else if ((A3.Text == B3.Text) && (B3.Text == C3.Text) && (!A3.Enabled))
                there_is_a_winner = true;

            // Diagonal checks
            if ((A1.Text == B2.Text) && (B2.Text == C3.Text) && (!A1.Enabled))
                there_is_a_winner = true;
            else if ((A3.Text == B2.Text) && (B2.Text == C1.Text) && (!A3.Enabled))
                there_is_a_winner = true;


            if (there_is_a_winner)
            {
                DisableButtons();

                string winner;
                if (turn)   //  **** out **** && X1st)
                {
                    winner = P2.Text;
                    cntP2.Text = (Int32.Parse(cntP2.Text) + 1).ToString();
                }
                else
                {
                    winner = P1.Text;
                    cntP1.Text = (Int32.Parse(cntP1.Text) + 1).ToString();
                }
                MessageBox.Show(winner + " Wins!", "winner");
            }  // end if winner
            else
            {
                if (turn_count == 9)
                {
                    MessageBox.Show(" Drawn Game ", "Draw");
                    cntD.Text = (Int32.Parse(cntD.Text) + 1).ToString();
                }
            }
        }

        // RAW COPY'N'PASTE FROM CHRIS MERRIT
        private void Computer_make_move()
        {

            //priority 1:  get tick tac toe
            //priority 2:  block x tic tac toe
            //priority 3:  go for corner space
            //priority 4:  pick open space

            //look for tic tac toe opportunities
            Button move = Look_for_win_or_block("O");
            if (move == null)
            {
                move = Look_for_win_or_block("X"); //look for block X's with "O"
                if (move == null)
                {
                    move = Looking_for_corner();
                    if (move == null)
                    {
                        move = Look_for_open_space();
                    }//end if
                }//end if
            }//end if
            try
            {
                move.PerformClick();  //NULL error without try catch
            }
            catch { }

            //RESTARTGAMEToolStripMenuItem_Click();  //  error
        }
        /*  ***** start random button  *****
        private Button Look_for_open_space()
        {
            Control[] c = new Control[Controls.Count];
            int i = 0;

            foreach (Control control in Controls)
            {
                //get an array of all controls // ***  Random logic  ***
                c[i] = control;
                i++;
            }//end foreach

            c = ShuffleArray(c);

            for (int j = 0; j < c.Length; j++)
            {
                if (c[j] is Button b)
                {
                    if (b.Text == "")
                        return b;
                }
            }

            return null;
        }//end look_for_open_space

        private Control[] ShuffleArray(Control[] array)
        {
            Random r = new Random();
            for (int i = array.Length; i > 0; i--)
            {
                int j = r.Next(i);
                Control k = array[j];
                array[j] = array[i - 1];
                array[i - 1] = k;
            }
            return array;
        }  */ //end ShuffleArray  ***** end random button  *****

        // /* comment out
        private Button Look_for_open_space()
        {
            foreach (Control c in Controls)
            {
                try
                {
                    // Looking for button with open space // *** fixed logic  ***
                    Button b = c as Button;
                    {
                        if (b != null)
                        {
                            if (b.Text == "")
                                return b;
                        }
                    }
                }
                catch { }

            }

            return null;
        }


        private Button Looking_for_corner()
        {

            if (A1.Text == "O")
            {
                if (A3.Text == "")
                    return A3;
                if (C3.Text == "")
                    return C3;
                if (C1.Text == "")
                    return C1;
            }

            if (A3.Text == "O")
            {
                if (A1.Text == "")
                    return A1;
                if (C3.Text == "")
                    return C3;
                if (C1.Text == "")
                    return C1;
            }

            if (C3.Text == "O")
            {
                if (A1.Text == "")
                    return A3;
                if (A3.Text == "")
                    return A3;
                if (C1.Text == "")
                    return C1;
            }

            if (C1.Text == "O")
            {
                if (A1.Text == "")
                    return A3;
                if (A3.Text == "")
                    return A3;
                if (C3.Text == "")
                    return C3;
            }

            if (A1.Text == "")
                return A1;
            if (A3.Text == "")
                return A3;
            if (C1.Text == "")
                return C1;
            if (C3.Text == "")
                return C3;


            return null;


        }

        private Button Look_for_win_or_block(string mark)
        {
            // Looking for win or block move
            //HORIZONTAL TESTS
            if ((A1.Text == mark) && (A2.Text == mark) && (A3.Text == ""))
                return A3;
            if ((A2.Text == mark) && (A3.Text == mark) && (A1.Text == ""))
                return A1;
            if ((A1.Text == mark) && (A3.Text == mark) && (A2.Text == ""))
                return A2;

            if ((B1.Text == mark) && (B2.Text == mark) && (B3.Text == ""))
                return B3;
            if ((B2.Text == mark) && (B3.Text == mark) && (B1.Text == ""))
                return B1;
            if ((B1.Text == mark) && (B3.Text == mark) && (B2.Text == ""))
                return B2;

            if ((C1.Text == mark) && (C2.Text == mark) && (C3.Text == ""))
                return C3;
            if ((C2.Text == mark) && (C3.Text == mark) && (C1.Text == ""))
                return C1;
            if ((C1.Text == mark) && (C3.Text == mark) && (C2.Text == ""))
                return C2;

            //VERTICAL TESTS
            if ((A1.Text == mark) && (B1.Text == mark) && (C1.Text == ""))
                return C1;
            if ((B1.Text == mark) && (C1.Text == mark) && (A1.Text == ""))
                return A1;
            if ((A1.Text == mark) && (C1.Text == mark) && (B1.Text == ""))
                return B1;

            if ((A2.Text == mark) && (B2.Text == mark) && (C2.Text == ""))
                return C2;
            if ((B2.Text == mark) && (C2.Text == mark) && (A2.Text == ""))
                return A2;
            if ((A2.Text == mark) && (C2.Text == mark) && (B2.Text == ""))
                return B2;

            if ((A3.Text == mark) && (B3.Text == mark) && (C3.Text == ""))
                return C3;
            if ((B3.Text == mark) && (C3.Text == mark) && (A3.Text == ""))
                return A3;
            if ((A3.Text == mark) && (C3.Text == mark) && (B3.Text == ""))
                return B3;

            //DIAGONAL TESTS
            if ((A1.Text == mark) && (B2.Text == mark) && (C3.Text == ""))
                return C3;
            if ((B2.Text == mark) && (C3.Text == mark) && (A1.Text == ""))
                return A1;
            if ((A1.Text == mark) && (C3.Text == mark) && (B2.Text == ""))
                return B2;

            if ((A3.Text == mark) && (B2.Text == mark) && (C1.Text == ""))
                return C1;
            if ((B2.Text == mark) && (C1.Text == mark) && (A3.Text == ""))
                return A3;
            if ((A3.Text == mark) && (C1.Text == mark) && (B2.Text == ""))
                return B2;

            return null;
        }

        private void Button_click(object sender, EventArgs e)
        {

            try
             {
            Button b = (Button)sender;
            if (turn == true && Start == true)
                b.Text = "X";
            else
                b.Text = "O";

            turn = !turn;  // changes turn from X to O 

            b.Enabled = false; // Disables button from being re-pressed & will Not reset till new game
            turn_count++;
            }
            catch { }

            CheckForWinner();

            if (turn == false && against_computer == true)
            {
                Computer_make_move();
            }

        }

        private void DisableButtons()
        {
            foreach (Control c in Controls)
            {
                try
                {
                    Button b = (Button)c;
                    b.Enabled = false;
                }
                catch { }  // stops other objects eg menuitems from errors stopping program

            }  // end of foreach loop  
        }

        private void P2_TextChanged(object sender, EventArgs e)
        {
            if (P2.Text.ToUpper() == "COMPUTER")  // Default player 2 = COMPUTER
            {
                against_computer = true; Computer_make_move();
            }
            else
            {
                against_computer = false; turn = false;
            }
        }

        private void RESTARTGAMEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            turn = !true; //reset scores & player name/s start new game

            starts++;  // counter to change who starts each new game

            turn_count = 0; // MAX 9 = Drawn Game, 9 Squares filled

            if (starts % 2 == 0) // use ++ starts % 2 == 0; if = 0 "X" starts this game else "O" starts
            {
                X1st = true; turn = true;
            }
            else
            {
                X1st = false; turn = false;
            }
            //turn = X1st;  //?? hard coded X 1st ??

            if (X1st == true)
            {
                turn = true;   // "X" moves 1st
            }
            else
            {
                turn = false;
                Computer_make_move();  // "O" moves 1st
            }


            foreach (Control c in Controls)
            {
                try
                {
                    Button b = (Button)c;
                    b.Enabled = true;
                    b.Text = "";

                }
                catch { }  // stops other objects eg menuitems from errors stopping program
            } // end of foreach loop

        }

        private void ABOUTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Modified by Alan Couttie, \ninspired by Chris Merritt\nC# Lessons on youtube");
        }

        private void EXITToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void GET3INAROWToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" Win Tic Tac Toe by being first to make 3x X's or 3x O's \n in any direction up down or side to side or diagonaly");
        }

        private void Button_Leave(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (b.Enabled)
            {
                {
                    b.Text = "";
                }
            }
        }

        private void Button_Enter(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (b.Enabled)
            {

                if (turn == true)
                {
                    b.Text = "X";  // Player 1 
                }
                else
                {
                    b.Text = "O"; // Player2
                    if (P2.Text.ToUpper() == "COMPUTER")
                    {
                        Computer_make_move(); // Computer  Player 2
                        b.Text = "X"; // After Computer move
                    }
                }
            }  // end if

        }

        private void RESETWINCOUNTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cntP1.Text = "0";
            cntP2.Text = "0";
            cntD.Text = "0";

        }


    }
}
