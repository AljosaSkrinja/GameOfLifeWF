using System.Windows.Forms;
using System;
using System.Data;

namespace WinFormsApp2
{
    public partial class Game : Form
    {
        int[,] grid = new int[40, 40];
        public Game()
        {
            InitializeComponent();
        }

        private void StartGame_Click(object sender, EventArgs e)
        {
            DisplayGrid.DataSource = GenerateRandomGrid(40, 40);
        }
        private int[,] GenerateRandomGrid(int width, int height)//------------------------- random start
        {
            int[,] grid = new int[width, height];

            Random rand = new Random();
            for (int x = 0; x < width; x++)
            {
                for (int y = 0; y < height; y++)
                {
                    grid[x, y] = rand.Next(2);
                }
            }
            return grid;
        }

        private void DisplayGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
    }
}