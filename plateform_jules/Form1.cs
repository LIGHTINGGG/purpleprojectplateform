using System.Security.Cryptography.X509Certificates;

namespace plateform_jules
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();  //initialisation
        }
        int avancer = 10;    
        int vitessejump = 5;
        bool left = false;
        bool right = false;
        bool jump = false;
        int point = 0;
        string wintexter = "";
       // bool gravity = true;
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e) // évenement
        {
            if (jump == true)
            {
                pictureBox1.Top -= 10;
            }

            if (jump == false)
            {
                pictureBox1.Top += 10;
            }
            if (left == true)
            {
                pictureBox1.Left += avancer;
            }
            if (right == true)
            {
                pictureBox1.Left -= avancer;
            }
            foreach (Control n in this.Controls)
            {
                if ((string)n.Tag == "plateform" && n is PictureBox && pictureBox1.Bounds.IntersectsWith(n.Bounds))
                {

                    pictureBox1.Top = n.Top - pictureBox1.Height;

                }
            }
            if (pictureBox1.Bounds.IntersectsWith(piece1.Bounds))
            {
                piece1.Top += 1000;
                point += 1;
                piece1.Visible = false;
                score.Text = ": "+point;
            }
            if (pictureBox1.Bounds.IntersectsWith(piece2.Bounds))
            {
                piece2.Top += 1000;
                point += 1;
                piece2.Visible = false;
                score.Text = ": " + point;
            }
            if (pictureBox1.Bounds.IntersectsWith(piece3.Bounds))
            {
                piece3.Top += 1000;
                point += 1;
                piece3.Visible = false;
                score.Text = ": " + point;
            }
            if (pictureBox1.Bounds.IntersectsWith(winpic.Bounds))
            {
                pictureBox1.Top += 1000;
                wintext.Visible = true;
            }
        }
            
        private void press(object sender, KeyEventArgs e) // quand la touche est préssée
        {
            if (e.KeyCode == Keys.Up)
            {
                 jump = true;
                 
            }
            if (e.KeyCode == Keys.Right)
            {
                left = true;
                pictureBox1.Load("droite.png");

            }
            if (e.KeyCode == Keys.Left)
            {
                right = true;
                pictureBox1.Load("retourner.png");

            }
            if (e.KeyCode == Keys.R)
            {
                Application.Restart();

            }



        }

        private void nopress(object sender, KeyEventArgs e) // quand la touche est relachée
        {
            if (e.KeyCode == Keys.Up)
            {
                jump = false;

            }
            if (e.KeyCode == Keys.Right)
            {
                left = false;
                pictureBox1.Load("stable.png");
            }
            if (e.KeyCode == Keys.Left)
            {
                right = false;
                pictureBox1.Load("stable.png");
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}