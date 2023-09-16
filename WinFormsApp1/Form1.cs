using System.Drawing;
using System.Reflection.Metadata;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private CancellationTokenSource tokenSrc;// stops async code
        private bool[,] grid;


        public Form1()
        {
            InitializeComponent();//------------------------- default 
        }

        private void RednerLoop(CancellationToken cancellationToken)//------------------------- Makes grid frames
        {
            while (!cancellationToken.IsCancellationRequested)
            {
                pictureBox1.Image = ConvertGridToBitmap(grid);
                grid = EvolveNextGenerationGrid(grid);
            }
        }

        private static bool[,] GenerateRandomGrid(int width, int height)//------------------------- random start
        {
            bool[,] grid = new bool[width, height];

            Random rand = new Random();
            for (int x = 0; x < width; x++)
            {
                for (int y = 0; y < height; y++)
                {
                    grid[x, y] = rand.Next(2) == 0;
                }
            }
            return grid;
        }

        private bool[,] EvolveNextGenerationGrid(bool[,] initialGrid)//------------------------- nextGenetarion
        {
            int width = initialGrid.GetLength(0);
            int height = initialGrid.GetLength(1);
            bool[,] nextGenGrid = new bool[width, height];
            for (int x = 0; x < width; x++)
            {
                for (int y = 0; y < height; y++)
                {
                    int liveNeighbors = CountLiveNeighbours(initialGrid, x, y);
                    nextGenGrid[x, y] = (initialGrid[x, y]) ? WillCellSurvive(liveNeighbors) : WillCellBecomeAlive(liveNeighbors);
                }
            }

            return nextGenGrid;
        }

        private bool WillCellSurvive(int neighborsCount)//------------------------- if cell is alive check if it dies 
        {
            return neighborsCount == 2 || neighborsCount == 3;
        }

        private bool WillCellBecomeAlive(int neighborsCount)//------------------------- if cell is dead check if it gets revived
        {
            return neighborsCount == 3;
        }

        private int CountLiveNeighbours(bool[,] grid, int positionX, int positionY)//------------------------- Checks neighbors for every cell in grid
        {
            int liveNeighbors = 0;
            for (int i = positionX - 1; i <= positionX + 1; i++)
            {
                for (int j = positionY - 1; j <= positionY + 1; j++)
                {
                    bool isCellInArray = (i >= 0 && i < grid.GetLength(0) && j >= 0 && j < grid.GetLength(1));
                    bool isCurrentCell = (i != positionX || j != positionY);

                    if (isCurrentCell && isCellInArray && grid[i, j])
                        liveNeighbors++;
                }
            }

            return liveNeighbors;
        }


        private Bitmap ConvertGridToBitmap(bool[,] grid)//------------------------- Converts grid to bitmap
        {

            Bitmap bitmap = new Bitmap(grid.GetLength(0), grid.GetLength(1));

            for (int x = 0; x < grid.GetLength(0); x++)
            {
                for (int y = 0; y < grid.GetLength(1); y++)
                {
                    bitmap.SetPixel(x, y, grid[x, y] ? Color.Black : Color.White);
                }
            }

            return bitmap;
        }

        private void Start_Click(object sender, EventArgs e)
        {
            grid = GenerateRandomGrid(pictureBox1.Width, pictureBox1.Height);

            tokenSrc = new CancellationTokenSource();
            Task.Run(() => RednerLoop(tokenSrc.Token));//------------------------- Magic with lambda expression
        }

        private void Stop_Click(object sender, EventArgs e)
        {
            tokenSrc.Cancel();
        }
    }
}