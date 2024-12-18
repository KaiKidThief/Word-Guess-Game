using System.Collections;
using System.Text;
namespace frmGuessWord

{

    public partial class Form1 : Form
    {
        private int numLives = 3;

        public Form1()
        {
            InitializeComponent();

        }


        public void Form1_Load(object sender, EventArgs e)
        {

            string[] words = { "flashlight", "desktop", "keyboard", "monitor" };

            Random random = new Random();
            int randomwords = random.Next(words.Length);

            string wordToGuess = words[randomwords];

            lblWordToGuess.Text = new string('?', wordToGuess.Length);

            numLives = 3;
            lblLives.Text = "Lives: " + numLives;

        }

        public void btnCheck_Click(object sender, EventArgs e)
        {
            string[] words = { "flashlight", "desktop", "keyboard", "monitor" };

            ArrayList ans = new ArrayList();
            ans.Add(words[0]);
            ans.Add(words[1]);
            ans.Add(words[2]);
            ans.Add(words[3]);

            string guess = txtGuess.Text.Trim().ToLower();

            if (ans.Contains(guess))
            {
                lblWordToGuess.Text = guess;
                MessageBox.Show("Sugooii!!!, You Guess The Word!!!");

            }
            else
            {
                lstWrongGuesses.Items.Add(guess);
                MessageBox.Show("Wrong Guess");
                txtGuess.Clear();
                txtGuess.Focus();
                numLives--;
                lblLives.Text = "Lives: " + numLives;

            }

            if(numLives == 0)
            {
                MessageBox.Show("Sorry Game Over You use your lives!!!");
                btnCheck.Enabled = false;
            }

        }
    }
}