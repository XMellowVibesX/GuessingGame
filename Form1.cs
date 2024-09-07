using System.Collections;
using System.Text;

namespace WordGuesser
{
    public partial class WordGuesser : Form
    {
        public WordGuesser()
        {
            InitializeComponent();
            rand = new Random();
        }

        Random rand;
        string[] words =
        {
            "Cute",
            "Pretty",
            "Ribbon",
            "Candy",
            "Chocolate"
        };
        string? word;
        int word_order;

        public void displayWord()
        {
            if(word_order < words.Length)
            {
                word = words[word_order].ToUpper();
                int word_length = word.Length;
                StringBuilder hiddenWord = new StringBuilder(word_length);
                int hide = word_length / 2;
                ArrayList hideLetters = new ArrayList();

                for(int i = 0; i < hide; i++)
                {
                    bool willLoop = true;
                    do
                    {
                        int randNum = rand.Next(word_length);
                        if(hideLetters.Contains(randNum))
                        {
                            hideLetters.Add(randNum);
                            willLoop = false;
                        }
                    } while(willLoop);
                }

                for (int i = 0; i < word_length; i++)
                {
                    if (hideLetters.Contains(word[i]))
                    {
                        hiddenWord.Append("?");
                    } else
                    {
                        hiddenWord.Append(word[i]);
                    }
                }

                wordToGuess.Text = hiddenWord.ToString();
            } else
            {
                refreshWord();
                displayWord();
            }

        }

        public void refreshWord()
        {
            words = words.OrderBy(x => rand.Next()).ToArray();
            word_order = 0;
        }

        private void WordGuesser_Load(object sender, EventArgs e)
        {
            rand = new Random();
            refreshWord();
            displayWord();
        }
        private void guessButton_Click(object sender, EventArgs e)
        {
            if(guessButton.Text.Equals("Run it back?"))
            {
                word_order++;
                displayWord();
                guessButton.Text = "Guess";
                wrongGuessList.Items.Clear();
            }

            if (!inputBox.Text.Equals(""))
                {
                if (inputBox.Text.ToUpper().Equals(word))
                {
                    wordToGuess.Text = word;
                    guessButton.Text = "Run it back?";
                    MessageBox.Show("Good job, mate!");
                } else
                {
                    wrongGuessList.Items.Add(inputBox.Text);
                    MessageBox.Show("Try again, mate!");
                }
                inputBox.Text = "";
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }
        
        private void wordToGuess_Click(object sender, EventArgs e)
        {
        }
        
    }
}
