using StormEngine.src.Engine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StormEngine.src.Functions
{
    class Checker
    {
        public static bool IsWinner(Button A1, Button A2, Button A3, Button A4, Button B1, Button B2, Button B3, Button B4, Button C1, Button C2, Button C3, Button C4)
        {
            if (A1.Text == Variables.currPlayer && A2.Text == Variables.currPlayer && A3.Text == Variables.currPlayer && A4.Text == Variables.currPlayer)
            {
                // For now we'll just show a msg box
                
                return true;
            }
            if (B1.Text == Variables.currPlayer && B2.Text == Variables.currPlayer && B3.Text == Variables.currPlayer && B4.Text == Variables.currPlayer)
            {
                // For now we'll just show a msg box
                
                return true;
            }
            if (C1.Text == Variables.currPlayer && C2.Text == Variables.currPlayer && C3.Text == Variables.currPlayer && C4.Text == Variables.currPlayer)
            {
                // For now we'll just show a msg box
                
                return true;
            }
            return false;
        }

        public static bool IsWinnerAI(Button A1, Button A2, Button A3, Button A4, Button B1, Button B2, Button B3, Button B4, Button C1, Button C2, Button C3, Button C4)
        {
            if (A1.Text == "X" && A2.Text == "X" && A3.Text == "X" && A4.Text == "X")
            {
                // For now we'll just show a msg box

                return true;
            }
            if (B1.Text == "X" && B2.Text == "X" && B3.Text == "X" && B4.Text == "X")
            {
                // For now we'll just show a msg box

                return true;
            }
            if (C1.Text == "X" && C2.Text == "X" && C3.Text == "X" && C4.Text == "X")
            {
                // For now we'll just show a msg box

                return true;
            }
            return false;
        }
    }
}
