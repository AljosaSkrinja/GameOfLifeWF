using System.Windows.Forms;

namespace WinForm
{
    public partial class GameOfLife : Form
    {
        private const int rows = 20;
        private const int cols = 40;
        private const int speed = 500;
        private bool[,] grid = new bool[rows, cols];
        private Bitmap bitmap = new Bitmap(cols, rows);

        public GameOfLife()
        {

        }
        private void Random()
        {
            Random rand = new Random();
            for (int x = 0; x < rows; x++)
            {
                for (int y = 0; y < cols; y++)
                {
                    grid[x, y] = rand.Next(2) == 0;
                }
            }
        }
        private void BoolToBitmap()
        {
            for (int x = 0; x < rows; x++)
            {
                for (int y = 0; y < cols; y++)
                {
                    Color color = grid[x, y] ? Color.Black : Color.White;
                    bitmap.SetPixel(y, x, color);
                }
            }
            pictureBox1.Image = bitmap;
        }
        private void Game()
        {
            while (true)
            {
                bool[,] newGen = new bool[rows, cols];
                for (int x = 0; x < rows; x++)
                {
                    for (int y = 0; y < cols; y++)
                    {
                        int liveNeighbors = 0;
                        for (int i = x - 1; i <= x + 1; i++)
                        {
                            for (int j = y - 1; j <= y + 1; j++)
                            {
                                bool inRange = (i >= 0 && i < rows && j >= 0 && j < cols);
                                bool currentCell = (i != x || j != y);

                                if (currentCell && inRange && grid[i, j])
                                    liveNeighbors++;
                            }
                        }
                        //Magic rules:
                        //1.st rule:  Vsaka živa (live) celica, ki ima manj kot 2 (liveNeighbors < 2) živa soseda, umre
                        //2.nd rule:  Vsaka živa (live) celica, ki ima 2 ali 3 (liveNeighbors == 2||3) žive sosede, živi naprej.
                        //3.rd rule:  Vsaka živa (live) celica, ki ima več, kot 3 (liveNeighbors > 3) žive sosede umre.
                        //4.th rule:  Vsaka mrtva (dead) celica, ki ima natančno 3 (liveNeighbors == 3) žive sosede postane živa.
                        newGen[x, y] = (grid[x, y]) ? (liveNeighbors == 2 || liveNeighbors == 3) : (liveNeighbors == 3);
                    }
                }
                grid = newGen;

                Thread.Sleep(speed);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pictureBox1.Load();
        }

        private void button1_Click(object sender, EventArgs e)
        {
        const int rows = 20;
        const int cols = 40;
        const int speed = 500;
        bool[,] grid = new bool[rows, cols];
        Bitmap bitmap = new Bitmap(cols, rows);

            // Set the image in the PictureBox control
            pictureBox1.Image = bitmap;

            // Run the game of life simulation
            while (true)
            {
                bool[,] newGen = new bool[rows, cols];
                for (int x = 0; x < rows; x++)
                {
                    for (int y = 0; y < cols; y++)
                    {
                        int liveNeighbors = 0;
                        for (int i = x - 1; i <= x + 1; i++)
                        {
                            for (int j = y - 1; j <= y + 1; j++)
                            {
                                bool inRange = (i >= 0 && i < rows && j >= 0 && j < cols);
                                bool currentCell = (i != x || j != y);

                                if (currentCell && inRange && grid[i, j])
                                    liveNeighbors++;
                            }
                        }
                        //Magic rules:
                        //1.st rule:  Vsaka živa (live) celica, ki ima manj kot 2 (liveNeighbors < 2) živa soseda, umre
                        //2.nd rule:  Vsaka živa (live) celica, ki ima 2 ali 3 (liveNeighbors == 2||3) žive sosede, živi naprej.
                        //3.rd rule:  Vsaka živa (live) celica, ki ima več, kot 3 (liveNeighbors > 3) žive sosede umre.
                        //4.th rule:  Vsaka mrtva (dead) celica, ki ima natančno 3 (liveNeighbors == 3) žive sosede postane živa.
                        newGen[x, y] = (grid[x, y]) ? (liveNeighbors == 2 || liveNeighbors == 3) : (liveNeighbors == 3);
                    }
                }
                grid = newGen;
                Thread.Sleep(speed);
            }
        }
    }
}