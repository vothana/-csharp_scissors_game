using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;
using Microsoft.VisualBasic;

namespace scissors_game
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //lblWinner.Parent = youWinSupricePic;
            lblWinner.BackColor = Color.Transparent;
        }

        private void btnRock_Click(object sender, EventArgs e)
        {
            string aChoice;
            string yourChoice = "rock";
            clearGif();

            aChoice = alienChoice();
            setPic(yourChoice);
           //setGif();
           //MessageBox.Show(aChoice);
           // Thread.Sleep(4000);
           setAlienPicChoice(aChoice);
            int point = whoWin(yourChoice, aChoice);
            sumPoint(point);
        }

        private void btnPaper_Click(object sender, EventArgs e)
        {
            string aChoice;
            string yourChoice = "paper";
            clearGif();

            aChoice = alienChoice();
            setPic(yourChoice);
            //setGif();
            //MessageBox.Show(aChoice);
            // Thread.Sleep(4000);
            setAlienPicChoice(aChoice);
            int point = whoWin(yourChoice, aChoice);
            sumPoint(point);
        }

        private void btnScissors_Click(object sender, EventArgs e)
        {
            string aChoice;
            string yourChoice = "scissors";
            clearGif();

            aChoice = alienChoice();
            setPic(yourChoice);
            //setGif();
            //MessageBox.Show(aChoice);
            // Thread.Sleep(4000);
            setAlienPicChoice(aChoice);
            int point = whoWin(yourChoice, aChoice);
            sumPoint(point);
        }

        private string alienChoice()
        {
            string alienChoice;
            int index;

            string[] arr = { "rock", "paper", "scissors"};
            Random random = new Random();

            index = random.Next(arr.Length);
            alienChoice = arr[index];

            return alienChoice;
        }


        private void setAlienPicChoice(string alienChoice)
        {
            switch (alienChoice)
            {
                case ("paper"):
                    this.alienChoicePic.Image = new Bitmap(scissors_game.Properties.Resources.p_paper);
                    break;
                case ("rock"):
                    this.alienChoicePic.Image = new Bitmap(scissors_game.Properties.Resources.p_rock);
                    break;
                case ("scissors"):
                    this.alienChoicePic.Image = new Bitmap(scissors_game.Properties.Resources.c_scissors);
                    break;
            }
        }

        private void setGif()
        {
            this.alienChoicePic.Image =  Image.FromFile
               (System.Environment.GetFolderPath
               (System.Environment.SpecialFolder.Personal)
               + @"\Animate.gif");
        }

        private void setPic(string yourChoice)
        {
            switch (yourChoice)
            {
                case ("paper"):
                    this.yourChoicePic.Image = new Bitmap(scissors_game.Properties.Resources.p_paper_you);
                    break;
                case ("rock"):
                    this.yourChoicePic.Image = new Bitmap(scissors_game.Properties.Resources.p_rock_you);
                    break;
                case ("scissors"):
                    this.yourChoicePic.Image = new Bitmap(scissors_game.Properties.Resources.c_scissors_you);
                    break;
            }
        }

        private int whoWin(string yourChoice, string alienChoice)
        {
            if(yourChoice == alienChoice)
            {
                this.lblWinner.Text = "Both tier !";
                return 0;
            }
            else if(yourChoice == "rock" && alienChoice == "scissors")
            {
                this.lblWinner.Text = "You Win !";
                winnerSuprise();
                return 1;
            }
            else if(yourChoice == "rock" && alienChoice == "paper")
            {
                this.lblWinner.Text = "You Lose !";
                return -1;
            }
            else if (yourChoice == "paper" && alienChoice == "scissors")
            {
                this.lblWinner.Text = "You Lose !";
                return -1;
            }
            else if (yourChoice == "paper" && alienChoice == "rock")
            {
                this.lblWinner.Text = "You Win !";
                winnerSuprise();
                return 1;
            }
            else if (yourChoice == "scissors" && alienChoice == "paper")
            {
                this.lblWinner.Text = "You Win !";
                winnerSuprise();
                return 1;
            }
            else if (yourChoice == "scissors" && alienChoice == "rock")
            {
                this.lblWinner.Text = "You Lose !";
                return -1;
            }
            return 0;
        }

        private void winnerSuprise()
        {
            this.youWinSupricePic.Visible = true;
        }
        private void clearGif()
        {
            this.youWinSupricePic.Visible = false;
        }

        private void sumPoint(int point)
        {
            int a = int.Parse(yourPoint.Text);
            int b = int.Parse(alienPoint.Text);
            if(point == -1)
            {
                yourPoint.Text = (a-1).ToString();
                alienPoint.Text = (b + 1).ToString();
                checkPoint();
            }
            else if(point == 1)
            {
                yourPoint.Text = (a + 1).ToString();
                alienPoint.Text = (b - 1).ToString();
                checkPoint();
            }
                
        }
        private void checkPoint()
        {
            if(yourPoint.Text == "3")
            {
                showDialog("You win this game !");
            }
            else if (alienPoint.Text == "3")
            {
                showDialog("Alien win this game");
            }
        }

        private void showDialog(string text)
        {
            CustomDialog form = new CustomDialog(text);
            form.ShowDialog();

            if(form.DialogResult == DialogResult.Yes)
            {
                yourPoint.Text = "0";
                alienPoint.Text = "0";
                lblWinner.Text = "___";
                this.youWinSupricePic.Visible = false;
                yourChoicePic.Image = new Bitmap(scissors_game.Properties.Resources.You);
                alienChoicePic.Image = new Bitmap(scissors_game.Properties.Resources.Alien);
            }else if(form.DialogResult == DialogResult.No)
            {
                Close();
            }
        }
    }
}

//string input = Interaction.InputBox("Prompt", "Title", "Default", 10, 10);

//DialogResult dialogResult = MessageBox.Show("Sure", "Some Title", MessageBoxButtons.YesNo);
//if (dialogResult == DialogResult.Yes)

