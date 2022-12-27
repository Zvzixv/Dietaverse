using Dietaverse.Database;
using Dietaverse.Model;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Dietaverse.View
{
    public partial class Settings : Form
    {
        MainForm mainform;
        bool pass1wasclicked = false;
        bool pass2wasclicked = false;
        users user;
        public Settings(MainForm mf, users u)
        {
            InitializeComponent();
            mainform = mf;
            user = u;
        }

        private void logoutbutton_Click(object sender, EventArgs e)
        {
            Launch launchform = new Launch(mainform) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true, FormBorderStyle = FormBorderStyle.None };
            mainform.ChangeForm(launchform);
        }

        private void pass1textBox_Validated(object sender, EventArgs e)
        {
            if (!pass1wasclicked)
            {
                pass1textBox.Text = "";
                pass1wasclicked = true;
                pass1textBox.Font = new Font(pass1textBox.Font, FontStyle.Regular);
                pass1textBox.PasswordChar = '*';
                pass1textBox.UseSystemPasswordChar = true;
            }
        }

        private void pass1textBox_Leave(object sender, EventArgs e)
        {
            if(pass1wasclicked && pass1textBox.TextLength == 0 )
            {
                pass1textBox.Text = "Wpisz nowe hasło";
                pass1wasclicked = false;
                pass1textBox.UseSystemPasswordChar = false;
                pass1textBox.PasswordChar = '\0';
            }
        }

        private void pass2textBox_Validated(object sender, EventArgs e)
        {
            if (!pass2wasclicked)
            {
                pass2textBox.Text = "";
                pass2wasclicked = true;
                pass2textBox.Font = new Font(pass2textBox.Font, FontStyle.Regular);
                pass2textBox.PasswordChar = '*';
                pass2textBox.UseSystemPasswordChar = true;
            }
        }

        private void pass2textBox_Leave(object sender, EventArgs e)
        {
            if (pass2wasclicked && pass2textBox.TextLength == 0)
            {
                pass2textBox.Text = "Wpisz nowe hasło";
                pass2wasclicked = false;
                pass2textBox.UseSystemPasswordChar = false;
                pass2textBox.PasswordChar = '\0';
            }

        }

        private void changePasswordbutton_Click(object sender, EventArgs e)
        {
            if (pass1textBox.Text == "" || pass2textBox.Text =="")
            {
                string message = "Rekordy są puste";
                MessageBox.Show(this, message, "Błędna wartość", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (pass1textBox.Text != pass2textBox.Text)
            {
                string message = "Hasła się różnią";
                MessageBox.Show(this, message, "Błędna wartość", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Users use = new Users();
            use.ChangePassword(user.name, pass1textBox.Text);

            MessageBox.Show("Hasła zostały zmienione");
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            Users u = new Users();
            u.DeleteAccount(user);
            logoutbutton_Click(sender, e);
        }
    }
}
