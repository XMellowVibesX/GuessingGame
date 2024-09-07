namespace WordGuesser
{
    partial class WordGuesser
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
            guessButton = new Button();
            inputBox = new TextBox();
            wrongGuessList = new ListBox();
            resultDisplay = new Label();
            wordToGuess = new Label();
            SuspendLayout();
            // 
            // guessButton
            // 
            guessButton.BackColor = Color.DarkSeaGreen;
            guessButton.FlatStyle = FlatStyle.Flat;
            guessButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            guessButton.ForeColor = Color.White;
            guessButton.Location = new Point(186, 135);
            guessButton.Name = "guessButton";
            guessButton.Size = new Size(132, 48);
            guessButton.TabIndex = 0;
            guessButton.Text = "Guess";
            guessButton.UseVisualStyleBackColor = false;
            guessButton.Click += guessButton_Click;
            // 
            // inputBox
            // 
            inputBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            inputBox.Location = new Point(47, 91);
            inputBox.Name = "inputBox";
            inputBox.Size = new Size(400, 34);
            inputBox.TabIndex = 2;
            inputBox.TextChanged += textBox1_TextChanged;
            // 
            // wrongGuessList
            // 
            wrongGuessList.FormattingEnabled = true;
            wrongGuessList.Location = new Point(503, 59);
            wrongGuessList.Name = "wrongGuessList";
            wrongGuessList.Size = new Size(190, 124);
            wrongGuessList.TabIndex = 3;
            // 
            // resultDisplay
            // 
            resultDisplay.AutoSize = true;
            resultDisplay.BackColor = Color.DarkSeaGreen;
            resultDisplay.FlatStyle = FlatStyle.Flat;
            resultDisplay.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            resultDisplay.ForeColor = Color.White;
            resultDisplay.Location = new Point(503, 12);
            resultDisplay.Name = "resultDisplay";
            resultDisplay.Padding = new Padding(60, 3, 60, 3);
            resultDisplay.Size = new Size(190, 34);
            resultDisplay.TabIndex = 4;
            resultDisplay.Text = "label1";
            resultDisplay.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // wordToGuess
            // 
            wordToGuess.AutoSize = true;
            wordToGuess.BackColor = Color.DarkSeaGreen;
            wordToGuess.FlatStyle = FlatStyle.Flat;
            wordToGuess.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            wordToGuess.ForeColor = Color.White;
            wordToGuess.Location = new Point(120, 12);
            wordToGuess.Name = "wordToGuess";
            wordToGuess.Padding = new Padding(100, 20, 100, 20);
            wordToGuess.Size = new Size(270, 68);
            wordToGuess.TabIndex = 5;
            wordToGuess.Text = "label1";
            wordToGuess.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // WordGuesser
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(707, 197);
            Controls.Add(wordToGuess);
            Controls.Add(resultDisplay);
            Controls.Add(wrongGuessList);
            Controls.Add(inputBox);
            Controls.Add(guessButton);
            Name = "WordGuesser";
            Text = "WORD GUESSER";
            Load += WordGuesser_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button guessButton;
        private Label wordToGuess;
        private TextBox inputBox;
        private ListBox wrongGuessList;
        private Label resultDisplay;
        private Label wordToGuess;
    }
}
