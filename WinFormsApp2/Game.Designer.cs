namespace WinFormsApp2
{
    partial class Game
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            StartGame = new Button();
            button2 = new Button();
            DisplayGrid = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)DisplayGrid).BeginInit();
            SuspendLayout();
            // 
            // StartGame
            // 
            StartGame.Location = new Point(462, 20);
            StartGame.Name = "StartGame";
            StartGame.Size = new Size(112, 39);
            StartGame.TabIndex = 0;
            StartGame.Text = "Start Game";
            StartGame.UseVisualStyleBackColor = true;
            StartGame.Click += StartGame_Click;
            // 
            // button2
            // 
            button2.Location = new Point(462, 79);
            button2.Name = "button2";
            button2.Size = new Size(112, 41);
            button2.TabIndex = 1;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            // 
            // DisplayGrid
            // 
            DisplayGrid.AllowUserToDeleteRows = false;
            DisplayGrid.AllowUserToResizeColumns = false;
            DisplayGrid.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(255, 224, 192);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(255, 192, 192);
            DisplayGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            DisplayGrid.BackgroundColor = SystemColors.Window;
            DisplayGrid.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            DisplayGrid.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            DisplayGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DisplayGrid.GridColor = SystemColors.ActiveBorder;
            DisplayGrid.Location = new Point(12, 12);
            DisplayGrid.MaximumSize = new Size(400, 400);
            DisplayGrid.MinimumSize = new Size(400, 400);
            DisplayGrid.Name = "DisplayGrid";
            DisplayGrid.RowTemplate.Height = 25;
            DisplayGrid.ScrollBars = ScrollBars.None;
            DisplayGrid.SelectionMode = DataGridViewSelectionMode.CellSelect;
            DisplayGrid.Size = new Size(400, 400);
            DisplayGrid.TabIndex = 2;
            DisplayGrid.CellContentClick += DisplayGrid_CellContentClick;
            // 
            // Game
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(DisplayGrid);
            Controls.Add(button2);
            Controls.Add(StartGame);
            Name = "Game";
            Text = "Game of life";
            ((System.ComponentModel.ISupportInitialize)DisplayGrid).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button StartGame;
        private Button button2;
        private DataGridView DisplayGrid;
    }
}