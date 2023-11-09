using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ONeilloGameV3
{
    public partial class Form1 : Form
    {
        private const int boardSize = 8;
        private const int cellSize = 50;
        private int[,] board = new int[boardSize, boardSize];
        private int currentPlayer = 1;
        private int blackCount = 2;
        private int whiteCount = 2;
        private Timer updateTimer;

        public Form1()
        {
            InitializeComponent();
            FormComponents();
            InitialiseBoard();
            SetBoard();
            updateTimer = new Timer();
            updateTimer.Interval = 1000 / 60; // 60 FPS refresh rate
            updateTimer.Tick += new EventHandler((s, e) => { UpdateBoard(); });
            updateTimer.Start();
        }

        private void FormComponents() // set the characteristics of the form
        {
            int width = (boardSize * cellSize) + 20; // declare the form's width, allow for padding
            int height = boardSize * cellSize + cellSize * 4; // declare the form's height, allow for info panel to be displayed at the bottom. transferred to design specs

            this.Text = "ONeillo V3"; // set the name of the form at the top of the application
            this.BackColor = Color.Green; // set the background of the form to green (matches cell colours)
            this.Size = new Size(width, height); // create a new size for the form, initialising the width and height variables declared previously

            infoPanel.Visible = false; // at first, we do not want the infoPanel to be visible

            if (informationPanelToolStripMenuItem.Checked )
            {
                infoPanel.Visible = true;
            }
        }

        private void InitialiseBoard()
        {
            board[3, 4] = board[4, 3] = 1; // set starting black counters
            board[3, 3] = board[4, 4] = 2; // set starting white counters
        }

        private void SetBoard() // this function will create and display the buttons in a list format to represent the board
        {
            List<Button> buttons = new List<Button>(); // create a new list for the buttons to be stored to

            for (int row = 0; row < boardSize; row++) // iterate over each row in the size of the board
            {
                for (int col = 0; col < boardSize; col++) // iterate over each column in the size of the board
                {
                    Button button = new Button(); // for every individual position on the board, create a new button
                    button.Size = new Size(cellSize, cellSize); // set the button size to the size of the cells (50x50)
                    button.Location = new Point(col * cellSize, row * cellSize + 30); // set the locations of the buttons, giving each a unique location to be found by
                    button.Click += new EventHandler(CellClicked); // creating an event handler to handle the event of a click. when the user clicks a cell, whatever is found in the CellClicked function will run
                    button.Name = "btn_" + row + "_" + col; // set the name of the button to btn_2_4 etc.

                    if (board[row, col] == 1) // if the current cell has a value of 1
                    {
                        button.BackColor = Color.Black; // set a black counter to it
                    }
                    else if (board[row, col] == 2) // if the current cell has a value of 2
                    {
                        button.BackColor = Color.White; // set a white counter to it
                    }
                    else
                    {
                        if (ValidMove(row, col))
                        {
                            button.BackColor = Color.LightGreen; // change cell colour for a valid move
                        }

                        else // it is an empty cell
                        {
                            button.BackColor = Color.Green; // set it to empty (green)
                        }
                    }

                    buttons.Add(button); // add button control to form
                }
            }

            Controls.AddRange(buttons.ToArray());
        }

        private void CellClicked(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            int row = button.Location.Y / cellSize;
            int col = button.Location.X / cellSize;

            if (ValidMove(row, col))
            {
                MakeMove(row, col);

                UpdateBoard(); // update the board on the UI thread

                if (GameOver())
                {
                    GameOverMessage();
                }
                else
                {
                    SwitchPlayer();
                }
            }
        }

        private void MakeMove(int row, int col)
        {
            int[] directionRow = { -1, -1, -1, 0, 1, 1, 1, 0 };
            int[] directionCol = { -1, 0, 1, 1, 1, 0, -1, -1 };

            int newCount = 0;

            board[row, col] = currentPlayer;

            

            for (int i = 0; i < 8; i++)
            {
                int r = row + directionRow[i];
                int c = col + directionCol[i];
                bool foundOpponent = false;

                if (r < 0 || r >= boardSize || c < 0 || c >= boardSize || board[r, c] != OtherPlayer())
                {
                    continue;
                }

                while (true)
                {
                    r += directionRow[i];
                    c += directionCol[i];

                    if (r < 0 || r >= boardSize || c < 0 || c >= boardSize)
                    {
                        break;
                    }

                    if (board[r, c] == 0)
                    {
                        break;
                    }

                    if (board[r, c] == currentPlayer)
                    {
                        while (r != row || c != col)
                        {
                            r -= directionRow[i];
                            c -= directionCol[i];
                            board[r, c] = currentPlayer;
                            newCount++;
                        }
                        break;
                    }
                }
            }

            if (currentPlayer == 1)
            {
                blackCount += newCount + 1;
            }
            else
            {
                whiteCount += newCount + 1;
            }
            /*if (currentPlayer == 1)
            {
                currentPlayer = 2;
            }
            else
            {
                currentPlayer = 1;
            }*/
        }

        private bool ValidMove(int row, int col)
        {
            if (board[row, col] != 0)
            {
                return false;
            }

            int[] directionRow = { -1, -1, -1, 0, 1, 1, 1, 0 };
            int[] directionCol = { -1, 0, 1, 1, 1, 0, -1, -1 };
            bool isValidMove = false;

            for (int i = 0; i < 8; i++)
            {
                int r = row + directionRow[i];
                int c = col + directionCol[i];
                bool foundOpponent = false;

                if (r < 0 || r >= boardSize || c < 0 || c >= boardSize || board[r, c] != OtherPlayer())
                {
                    continue;
                }

                while (true)
                {
                    r += directionRow[i];
                    c += directionCol[i];

                    if (r < 0 || r >= boardSize || c < 0 || c >= boardSize)
                    {
                        break;
                    }

                    if (board[r, c] == 0)
                    {
                        break;
                    }

                    if (board[r, c] == currentPlayer)
                    {
                        isValidMove = true;
                        break;
                    }
                }
            }

            return isValidMove;
        }

        private void UpdateBoard()
        {
            player1ScoreLabel.Text = "Current Score:" + blackCount.ToString();
            player2ScoreLabel.Text = "Current Score:" + whiteCount.ToString();

            for (int row = 0; row < boardSize; row++)
            {
                for (int col = 0; col < boardSize; col++)
                {
                    Button button = (Button)Controls.Find("btn_" + row + "_" + col, true).FirstOrDefault();

                    if (button != null)
                    {
                        if (board[row, col] == 1)
                        {
                            button.BackColor = Color.Black;
                            button.Enabled = false;
                        }
                        else if (board[row, col] == 2)
                        {
                            button.BackColor = Color.White;
                            button.Enabled = false;
                        }
                        else
                        {
                            if (ValidMove(row, col))
                            {
                                button.BackColor = Color.LightGreen;
                                //button.Enabled = ValidMove(row, col);
                                button.Enabled = true;
                            }
                            else
                            {
                                button.BackColor = Color.Green;
                                button.Enabled = false;
                            }
                        }
                    }
                }
            }
        }

        private bool GameOver()
        {
            for (int row = 0; row < boardSize; row++)
            {
                for (int col = 0; col < boardSize; col++)
                {
                    if (ValidMove(row, col))
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        private void GameOverMessage()
        {
            for (int row = 0; row < boardSize; row++)
            {
                for (int col = 0; col < boardSize; col++)
                {
                    if (board[row, col] == 1)
                    {
                        blackCount++;
                    }
                    else if (board[row, col] == 2)
                    {
                        whiteCount++;
                    }
                }
            }

            if (blackCount > whiteCount)
            {
                MessageBox.Show("Black wins!"); // textbox1,2.
            }
            else if (whiteCount > blackCount)
            {
                MessageBox.Show("White wins!");
            }
            else
            {
                MessageBox.Show("Draw!");
            }
        }

        private void SwitchPlayer()
        {
            currentPlayer = OtherPlayer();
            statusLabel1.Text = "Current player: " + (currentPlayer == 1 ? "Black" : "White");
        }

        private int OtherPlayer()
        {
            return currentPlayer == 1 ? 2 : 1;
        }

        private void informationPanelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            infoPanel.Visible = informationPanelToolStripMenuItem.Checked;
        }

        private void newGameMenuItem_Click(object sender, EventArgs e)
        {
            ClearButtons();
            InitialiseBoard();
            SetBoard();
        }

        /*private void ClearButtons()
        {
            foreach (Control control in Controls) // loop through every control
            {
                //check if the control is a button with the right name format
                //if (control is Button && control.Name.StartsWith("btn_"))

                if (control is Button && control.BackColor != Color.Green)
                {
                    Controls.Remove(control); // remove the control from the form
                    control.Dispose();
                }
            }

            blackCount = 0;
            whiteCount = 0;
        }*/

        private void ClearButtons()
        {
            foreach (Control control in Controls)
            {
                Button button = control as Button;
                if (button != null)
                {
                    int row, col;
                    if (int.TryParse(button.Name.Split('_')[1], out row) && int.TryParse(button.Name.Split('_')[2], out col))
                    {
                        board[row, col] = 0; // reset the value of the board cell
                        button.Enabled = false; // disable the button
                        button.BackColor = Color.Green; // reset the button color to green
                    }
                }
            }

            blackCount = 2;
            whiteCount = 2;
        }

        private void gameToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void newGameTab_Click(object sender, EventArgs e)
        {
            ClearButtons();
            InitialiseBoard();
            SetBoard();
            UpdateBoard();
            blackCount = 2;
            whiteCount = 2;
        }
    }
}