using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game_Kiem_Tra_Mat
{
    public partial class Form1 : Form
    {
        int time = 20;
        int level = 1;
        int score = 0;
        int error = 0;

        private int gridSize = 2;

        public Form1()
        {
            InitializeComponent();
            //InitializeGrid();
            //AddButtonsToGrid();
        }

       

        private void InitializeGrid()
        {
            this.tableLayoutPanel1.ColumnCount = gridSize;
            this.tableLayoutPanel1.RowCount = gridSize;
            this.tableLayoutPanel1.ColumnStyles.Clear();
            this.tableLayoutPanel1.RowStyles.Clear();

            for (int i = 0; i < gridSize; i++)
            {
                this.tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100 / gridSize));
                this.tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100 / gridSize));
            }
        }

        private void AddButtonsToGrid()
        {
            this.tableLayoutPanel1.Controls.Clear();

            //Random coordinate of the isolated box.
            Random isolatedBox = new Random();
            int i_ran = isolatedBox.Next(0, gridSize);
            int j_ran = isolatedBox.Next(0, gridSize);

            //Random a Color for all of the boxes
            Random randomColor = new Random();
            int randomRed = randomColor.Next(200);
            int randomGreen = randomColor.Next(200);
            int randomBlue = randomColor.Next(200);
            Color ColorForAllBox = Color.FromArgb(randomRed, randomGreen, randomBlue);


            for (int row = 0; row < gridSize; row++)
            {
                for (int col = 0; col < gridSize; col++)
                {
                    if(row == i_ran && col==j_ran)
                    {
                        //Make color of the isolated box fade.
                        int DifferentBoxRed = randomRed + 20;
                        int DifferentBoxGreen = randomGreen + 20;
                        int DifferentBoxBlue = randomBlue + 20;
                        Color ColorFoDifferentBox = Color.FromArgb(DifferentBoxRed, DifferentBoxGreen, DifferentBoxBlue);
                        
                        //Create and set color for the isolated box
                        var button = new Button();
                        button.Text = string.Format("{0}{1}", row, col);
                        button.ForeColor = ColorFoDifferentBox;
                        button.BackColor = ColorFoDifferentBox;
                        button.Dock = DockStyle.Fill;
                        this.tableLayoutPanel1.Controls.Add(button, col, row);
                        button.Click += Button_Click;
                    }
                    else
                    {
                        //Create and set color for alike boxes
                        var button = new Button();
                        button.Text = string.Format("{0}{1}", row, col);
                        button.BackColor = ColorForAllBox;
                        button.ForeColor = ColorForAllBox;
                        button.Dock = DockStyle.Fill;
                        this.tableLayoutPanel1.Controls.Add(button, col, row);
                        button.Click += Button_Click1;                      
                    }
                    
                }
            }
        }

        //Event when click on the wrong box
        private void Button_Click1(object sender, EventArgs e)
        {
            
            if(time <= 0)
            {
                GameOverForm gameover = new GameOverForm();
                gameover.ShowDialog();
            }    
            if(time > 0)
            {
                time = time - 3;
                error++;
                textBox_Error.Text = error.ToString();
            }    
            //MessageBox.Show("Hello, this is false");
        }

        //Event when click on the right box
        private void Button_Click(object sender, EventArgs e)
        {

            if (time <= 0)
            {
                GameOverForm gameover = new GameOverForm();
                gameover.ShowDialog();
            }
            if(time > 0)
            {
                time = 20;
                score = score + 5;
                textBox_Score.Text = score.ToString();
                if (gridSize <= 10)
                {
                    gridSize = gridSize + 1;
                    InitializeGrid();
                    
                }
                AddButtonsToGrid();
            }    
            //MessageBox.Show("Hello, this is true");
        }

        private void timer_GameOver_Tick(object sender, EventArgs e)
        {
            label_Time.Text = "Time: " + Convert.ToString(time);
            time--;
            if(time <= 0) 
            {
                time = 0;
                label_Time.Text = "Time: " + Convert.ToString(time);
                timer_GameOver.Stop();
                //MessageBox.Show("Time's up!!!");
                GameOverForm gameOver = new GameOverForm();
                gameOver.ShowDialog();
            }
        }

        private void playButton_Click(object sender, EventArgs e)
        {
            InitializeGrid();
            AddButtonsToGrid();
            timer_GameOver.Start();

        }

        private void textBox_Score_TextChanged(object sender, EventArgs e)
        {
            if(textBox_Score.Text == "25" || textBox_Score.Text == "50" || textBox_Score.Text == "75" || textBox_Score.Text == "100")
            {
                //MessageBox.Show("Changed");
                progressBar_level.PerformStep();
            }
        }
    }
}

