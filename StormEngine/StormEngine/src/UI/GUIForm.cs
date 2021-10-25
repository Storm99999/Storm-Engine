using StormEngine.src.Engine;
using StormEngine.src.Functions;
using StormEngine.src.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StormEngine
{
    public partial class UI : Form
    {
        public UI()
        {
            InitializeComponent();
            panel1.BackColor = Variables.backgroundColor;
            menuStrip1.BackColor = Variables.backgroundColor;
            this.Text = Variables.Title;
            Variables.currPlayer = "O";

        }
        public static string currPlayer = "X";
        public static EngineBox msg = new EngineBox();


        private void A1_Click(object sender, EventArgs e)
        {
            
            if (Variables.isTurn == true)
            {
                if (A1.Enabled == true)
                {
                    Checker.IsWinner(A1, A2, A3, A4, B1, B2, B3, B4, C1, C2, C3, C4);
                    if (Variables.currPlayer != null)
                    {
                        A1.Text = Variables.currPlayer;
                        A1.Enabled = false;
                        timer1_Tick(sender, e);
                    }
                    else
                    {
                        msg.Show();
                        msg.Show("Engine Error: The Creator Didn't Select A Player..", "Error");
                    }
                    Variables.isTurn = false;
                }
                else
                {
                    MessageBox.Show("Dude you cannot do that idiot.");
                }
            }
            else
            {
                MessageBox.Show("Not your turn.");
            }
        }
        // Most pain in the ass i've ever done
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Checker.IsWinner(A1, A2, A3, A4, B1, B2, B3, B4, C1, C2, C3, C4))
            {
                timer1.Stop();
                new WinScreen().Show();
            }
            if (Checker.IsWinnerAI(A1, A2, A3, A4, B1, B2, B3, B4, C1, C2, C3, C4))
            {
                timer1.Stop();
                msg.Show();
                msg.Show("Too bad!", "You Lost!");
            }
            if (Variables.isTurn == false)
            {
                foreach (Control control in Controls)
                {
                    if (RandomField() == 0)
                    {
                        if (A1.Enabled == true)
                        {
                            A1.Text = "X";
                            A1.Enabled = false;
                            Variables.isTurn = true;
                        }
                        else
                        {
                             if (A2.Enabled == true)
                            {
                                A2.Text = "X";
                                A2.Enabled = false;
                                Variables.isTurn = true;
                            }
                            else
                            {
                                if (A3.Enabled == true)
                                {
                                    A3.Text = "X";
                                    A3.Enabled = false;
                                    Variables.isTurn = true;
                                }
                                else
                                {
                                    if (A4.Enabled == true)
                                    {
                                        // I'll speed/cut this part out and post it on github
                                        A4.Text = "X";
                                        A4.Enabled = false;
                                        Variables.isTurn = true;
                                    }
                                    else
                                    {
                                        if (B1.Enabled == true)
                                        {
                                            B1.Text = "X";
                                            B1.Enabled = false;
                                            Variables.isTurn = true;
                                        }
                                        else
                                        {
                                            if (B2.Enabled == true)
                                            {
                                                B2.Text = "X";
                                                B2.Enabled = false;
                                                Variables.isTurn = true;
                                            }
                                            else
                                            {
                                                if (B3.Enabled == true)
                                                {
                                                    B3.Text = "X";
                                                    B3.Enabled = false;
                                                    Variables.isTurn = true;
                                                }
                                                else
                                                {
                                                    if (B4.Enabled == true)
                                                    {
                                                        B4.Text = "X";
                                                        B4.Enabled = false;
                                                        Variables.isTurn = true;
                                                    }
                                                    else
                                                    {
                                                        if (C1.Enabled == true)
                                                        {
                                                            C1.Text = "X";
                                                            C1.Enabled = false;
                                                            Variables.isTurn = true;
                                                        }
                                                        else
                                                        {
                                                            if (C2.Enabled == true)
                                                            {
                                                                C2.Text = "X";
                                                                C2.Enabled = false;
                                                                Variables.isTurn = true;
                                                            }
                                                            else
                                                            {
                                                                if (C3.Enabled == true)
                                                                {
                                                                    C3.Text = "X";
                                                                    C3.Enabled = false;
                                                                    Variables.isTurn = true;
                                                                }
                                                                else
                                                                {
                                                                    if (C4.Enabled == true)
                                                                    {
                                                                        C4.Text = "X";
                                                                        C4.Enabled = false;
                                                                        Variables.isTurn = true;
                                                                    }
                                                                    else
                                                                    {
                                                                        
                                                                        MessageBox.Show("X has no way to end the game within A minute.");
                                                                    }
                                                                }
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
        private static Random random = new Random();
        public static int RandomField()
        {
            int c;
            c = random.Next(0, 0);
            return c;
        }

        private void A2_Click(object sender, EventArgs e)
        {
            if (Variables.isTurn == true)
            {
                if (A2.Enabled == true)
                {
                    Checker.IsWinner(A1, A2, A3, A4, B1, B2, B3, B4, C1, C2, C3, C4);
                    if (Variables.currPlayer != null)
                    {
                        A2.Text = Variables.currPlayer;
                        A2.Enabled = false;
                        timer1_Tick(sender, e);
                    }
                    else
                    {
                        MessageBox.Show("Error");
                    }
                    Variables.isTurn = false;
                }
                else
                {
                    MessageBox.Show("Dude you cannot do that idiot.");
                }
            }
            else
            {
                MessageBox.Show("Not your turn.");
            }
        }

        private void A3_Click(object sender, EventArgs e)
        {
            if (Variables.isTurn == true)
            {
                if (A3.Enabled == true)
                {
                    Checker.IsWinner(A1, A2, A3, A4, B1, B2, B3, B4, C1, C2, C3, C4);
                    if (Variables.currPlayer != null)
                    {
                        A3.Text = Variables.currPlayer;
                        A3.Enabled = false;
                        timer1_Tick(sender, e);
                    }
                    else
                    {
                        MessageBox.Show("Error");
                    }
                                        
                    Variables.isTurn = false;
                }
                else
                {
                    MessageBox.Show("Dude you cannot do that idiot.");
                }
            }
            else
            {
                MessageBox.Show("Not your turn.");
            }
        }

        private void A4_Click(object sender, EventArgs e)
        {
            if (Variables.isTurn == true)
            {
                if (A4.Enabled == true)
                {
                    Checker.IsWinner(A1, A2, A3, A4, B1, B2, B3, B4, C1, C2, C3, C4);
                    if (Variables.currPlayer != null)
                    {
                        A4.Text = Variables.currPlayer;
                        A4.Enabled = false;
                        timer1_Tick(sender, e);
                    }
                    else
                    {
                        MessageBox.Show("Error");
                    }
                    Variables.isTurn = false;
                }
                else
                {
                    MessageBox.Show("Dude you cannot do that idiot.");
                }
            }
            else
            {
                MessageBox.Show("Not your turn.");
            }
        }

        private void B1_Click(object sender, EventArgs e)
        {
            if (Variables.isTurn == true)
            {
                if (B1.Enabled == true)
                {
                    Checker.IsWinner(A1, A2, A3, A4, B1, B2, B3, B4, C1, C2, C3, C4);
                    if (Variables.currPlayer != null)
                    {
                        B1.Text = Variables.currPlayer;
                        B1.Enabled = false;
                        timer1_Tick(sender, e);
                    }
                    else
                    {
                        MessageBox.Show("Error");
                    }
                    Variables.isTurn = false;
                }
                else
                {
                    MessageBox.Show("Dude you cannot do that idiot.");
                }
            }
            else
            {
                MessageBox.Show("Not your turn.");
            }
        }

        private void B2_Click(object sender, EventArgs e)
        {
            if (Variables.isTurn == true)
            {
                if (B2.Enabled == true)
                {
                    Checker.IsWinner(A1, A2, A3, A4, B1, B2, B3, B4, C1, C2, C3, C4);
                    if (Variables.currPlayer != null)
                    {
                        B2.Text = Variables.currPlayer;
                        B2.Enabled = false;
                        timer1_Tick(sender, e);
                    }
                    else
                    {
                        MessageBox.Show("Error");
                    }
                    Variables.isTurn = false;
                }
                else
                {
                    MessageBox.Show("Dude you cannot do that idiot.");
                }
            }
            else
            {
                MessageBox.Show("Not your turn.");
            }
        }

        private void B3_Click(object sender, EventArgs e)
        {
            if (Variables.isTurn == true)
            {
                if (B3.Enabled == true)
                {
                    Checker.IsWinner(A1, A2, A3, A4, B1, B2, B3, B4, C1, C2, C3, C4);
                    if (Variables.currPlayer != null)
                    {
                        B3.Text = Variables.currPlayer;
                        B3.Enabled = false;
                        timer1_Tick(sender, e);
                    }
                    else
                    {
                        MessageBox.Show("Error");
                    }
                    Variables.isTurn = false;
                }
                else
                {
                    MessageBox.Show("Dude you cannot do that idiot.");
                }
            }
            else
            {
                MessageBox.Show("Not your turn.");
            }
        }

        private void B4_Click(object sender, EventArgs e)
        {
            if (Variables.isTurn == true)
            {
                if (B4.Enabled == true)
                {
                    Checker.IsWinner(A1, A2, A3, A4, B1, B2, B3, B4, C1, C2, C3, C4);
                    if (Variables.currPlayer != null)
                    {
                        B4.Text = Variables.currPlayer;
                        B4.Enabled = false;
                        timer1_Tick(sender, e);
                    }
                    else
                    {
                        MessageBox.Show("Error");
                    }
                    Variables.isTurn = false;
                }
                else
                {
                    MessageBox.Show("Dude you cannot do that idiot.");
                }
            }
            else
            {
                MessageBox.Show("Not your turn.");
            }
        }

        private void C1_Click(object sender, EventArgs e)
        {
            if (Variables.isTurn == true)
            {
                if (C1.Enabled == true)
                {
                    Checker.IsWinner(A1, A2, A3, A4, B1, B2, B3, B4, C1, C2, C3, C4);
                    if (Variables.currPlayer != null)
                    {
                        C1.Text = Variables.currPlayer;
                        C1.Enabled = false;
                        timer1_Tick(sender, e);
                    }
                    else
                    {
                        MessageBox.Show("Error");
                    }
                    Variables.isTurn = false;
                }
                else
                {
                    MessageBox.Show("Dude you cannot do that idiot.");
                }
            }
            else
            {
                MessageBox.Show("Not your turn.");
            }
        }

        private void C2_Click(object sender, EventArgs e)
        {
            if (Variables.isTurn == true)
            {
                if (C2.Enabled == true)
                {
                    Checker.IsWinner(A1, A2, A3, A4, B1, B2, B3, B4, C1, C2, C3, C4);
                    if (Variables.currPlayer != null)
                    {
                        C2.Text = Variables.currPlayer;
                        C2.Enabled = false;
                        timer1_Tick(sender, e);
                    }
                    else
                    {
                        MessageBox.Show("Error");
                    }
                    Variables.isTurn = false;
                }
                else
                {
                    MessageBox.Show("Dude you cannot do that idiot.");
                }
            }
            else
            {
                MessageBox.Show("Not your turn.");
            }
        }

        private void C3_Click(object sender, EventArgs e)
        {
            if (Variables.isTurn == true)
            {
                if (C3.Enabled == true)
                {
                    Checker.IsWinner(A1, A2, A3, A4, B1, B2, B3, B4, C1, C2, C3, C4);
                    if (Variables.currPlayer != null)
                    {
                        C3.Text = Variables.currPlayer;
                        C3.Enabled = false;
                        timer1_Tick(sender, e);
                    }
                    else
                    {
                        MessageBox.Show("Error");
                    }
                    Variables.isTurn = false;
                }
                else
                {
                    MessageBox.Show("Dude you cannot do that idiot.");
                }
            }
            else
            {
                MessageBox.Show("Not your turn.");
            }
        }

        private void C4_Click(object sender, EventArgs e)
        {
            if (Variables.isTurn == true)
            {
                if (C4.Enabled == true)
                {
                    Checker.IsWinner(A1, A2, A3, A4, B1, B2, B3, B4, C1, C2, C3, C4);
                    if (Variables.currPlayer != null)
                    {
                        C4.Text = Variables.currPlayer;
                        C4.Enabled = false;
                        timer1_Tick(sender, e);
                    }
                    else
                    {
                        MessageBox.Show("Error");
                    }
                    Variables.isTurn = false;
                }
                else
                {
                    MessageBox.Show("Dude you cannot do that idiot.");
                }
            }
            else
            {
                MessageBox.Show("Not your turn.");
            }
        }

        private void restartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}
