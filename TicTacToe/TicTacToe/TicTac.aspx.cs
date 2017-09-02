using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TicTacToe
{
    public partial class TicTac : System.Web.UI.Page
    {
        private readonly string _turn = "turn";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Label1.Text = "Please Start a Game";
                ViewState[_turn] = "X";
                foreach(Control button in form1.Controls)
                {
                    if(button.GetType()==typeof(Button)&&((Button)button).Text!="Restart")
                    {
                        ((Button)button).Text = "-";
                    }
                }
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Button pressedButton = (Button)sender;
            string winner;
            if ((string)ViewState[_turn] == "O")
            {
                ViewState[_turn] = "X";
                Label1.Text = "X move";
                pressedButton.Text = "X";
            }
            else
            {
                ViewState[_turn] = "O";
                Label1.Text = "O move";
                pressedButton.Text = "O";
            }
            if (WinningCondition(out winner))
            {
                Label1.Text = "Congrats " + winner + " is the winner";
                DeactivateButtons();
            }
            else if(IsDraw())
            {
                Label1.Text = "Game Draw";

            }
        }

        private bool IsDraw()
        {
            foreach (Control button in form1.Controls)
            {
                if (button.GetType() == typeof(Button) && ((Button)button).Text != "Restart")
                {
                    if (((Button)button).Text == "-")
                        return false;
                }
            }
            return true;
        }

        protected bool WinningCondition(out string winner)
        {
            if ((Button1.Text == "X" && Button2.Text == "X" && Button3.Text == "X") || (Button4.Text == "X" && Button5.Text == "X" && Button6.Text == "X") || (Button7.Text == "X" && Button8.Text == "X" && Button9.Text == "X") || (Button1.Text == "X" && Button5.Text == "X" && Button9.Text == "X") || (Button3.Text == "X" && Button5.Text == "X" && Button7.Text == "X"))
            {
                winner = "X";
                return true;
            }
            else if ((Button1.Text == "O" && Button2.Text == "O" && Button3.Text == "O") || (Button4.Text == "O" && Button5.Text == "O" && Button6.Text == "O") || (Button7.Text == "O" && Button8.Text == "O" && Button9.Text == "O") || (Button1.Text == "O" && Button5.Text == "O" && Button9.Text == "O") || (Button3.Text == "O" && Button5.Text == "O" && Button7.Text == "O"))
            {
                winner = "O";
                return true;
            }
            winner = " ";
            return false;
        }
        protected void RestartButton_Click(object sender, EventArgs e)
        {
            Label1.Text = "Start Again";
            foreach (Control button in form1.Controls)
            {
                if (button.GetType() == typeof(Button) && ((Button)button).Text != "Restart")
                {
                    ((Button)button).Text = "-";
                }
            }


        }
        public void DeactivateButtons()
        {
            Button1.Enabled = false;
            Button2.Enabled = false;
            Button3.Enabled = false;
            Button4.Enabled = false;
            Button5.Enabled = false;
            Button6.Enabled = false;
            Button7.Enabled = false;
            Button8.Enabled = false;
            Button9.Enabled = false;
        }
    }
}