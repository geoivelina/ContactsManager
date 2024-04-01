using System;
using System.Drawing;
using System.Windows.Forms;

namespace ContactsManager
{
    public partial class LoginRegisterForm : Form
    {
        public LoginRegisterForm()
        {
            InitializeComponent();
        }

        private void LoginRegisterForm_Load(object sender, EventArgs e)
        {
            //dispaly image on the pandel(close andminimize)

            minimizePanel.BackgroundImage = Image.FromFile("../../Images/minimize.png");
            closePanel.BackgroundImage = Image.FromFile("../../Images/close.png");
        }


        //Login Btn
        private void loginBtn_Click(object sender, EventArgs e)
        {

        }


        //Register Btn
        private void registerBtn_Click(object sender, EventArgs e)
        {

        }

        //Brows Picture Btn
        private void registerUploadPictureBtn_Click(object sender, EventArgs e)
        {
            //select and display image in the imageBox

            OpenFileDialog opd = new OpenFileDialog();
            opd.Filter = "Select Image(*.jpg; *.png; *.gif) | *.jpg; *.png; *.gif";

            if (opd.ShowDialog() == DialogResult.OK)
            {
                registerPictureBox.Image = Image.FromFile(opd.FileName);
            }
        }

        //Go to Register section
        private void goToRegisterLable_Click(object sender, EventArgs e)
        {
            timer1.Start();
            goToRegisterLable.Enabled = false;
            goToLoginLable.Enabled = false;
        }


        //Go to Login Section
        private void goToLoginLable_Click(object sender, EventArgs e)
        {
            timer2.Start();
            goToLoginLable.Enabled = false;
            goToRegisterLable.Enabled = false;
        }


        //Minimize Btn
        private void loginMinimizeBtn_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }


        //Close Btn
        private void loginCloseBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        //then this times starts will slide to Register Section
        private void timer1_Tick(object sender, EventArgs e)
        {
            //first 320 is where Login section
            if (panel2.Location.X > -320)
            {
                panel2.Location = new Point(panel2.Location.X - 10, panel2.Location.Y);
            }
            else
            {
                timer1.Stop();
                goToLoginLable.Enabled = true;
                goToRegisterLable.Enabled = true;
            }
        }

        //then this times starts will slide to Login Section
        private void timer2_Tick(object sender, EventArgs e)
        {
            if (panel2.Location.X < 0)
            {
                panel2.Location = new Point(panel2.Location.X + 10, panel2.Location.Y);
            }
            else
            {
                timer2.Stop();
                goToLoginLable.Enabled = true;
                goToRegisterLable.Enabled = true;
            }
        }
    }
}
