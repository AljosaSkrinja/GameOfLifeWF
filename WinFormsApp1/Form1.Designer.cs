namespace WinFormsApp1
{
    partial class Form1
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
            pictureBox1 = new PictureBox();
            Start = new Button();
            Stop = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.BackColor = SystemColors.Control;
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(634, 355);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // Start
            // 
            Start.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            Start.BackColor = SystemColors.ActiveCaption;
            Start.ForeColor = SystemColors.ActiveCaptionText;
            Start.Location = new Point(12, 361);
            Start.Name = "Start";
            Start.Size = new Size(222, 28);
            Start.TabIndex = 1;
            Start.Text = "Start Game";
            Start.UseVisualStyleBackColor = false;
            Start.Click += Start_Click;
            // 
            // Stop
            // 
            Stop.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            Stop.BackColor = SystemColors.ActiveCaption;
            Stop.ForeColor = SystemColors.ActiveCaptionText;
            Stop.Location = new Point(420, 361);
            Stop.Name = "Stop";
            Stop.Size = new Size(202, 28);
            Stop.TabIndex = 2;
            Stop.Text = "End Game";
            Stop.UseVisualStyleBackColor = false;
            Stop.Click += Stop_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(634, 396);
            Controls.Add(Stop);
            Controls.Add(Start);
            Controls.Add(pictureBox1);
            ForeColor = SystemColors.Control;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Button Start;
        private Button Stop;
        private Button GenerateRandGrid;
    }
}