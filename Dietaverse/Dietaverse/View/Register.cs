using Dietaverse.Database;
using Dietaverse.Model;
using System;
using System.Windows.Forms;

namespace Dietaverse.View
{
    public partial class Register : Form
    {
        MainForm mainform;
        string un;
        double weight;
        string pass1;
        string pass2;
        Users newuser = new Users();
        DailySummary summary = new DailySummary();
        public Register(MainForm mf)
        {
            InitializeComponent();
            mainform = mf;
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            if(userNametextBox.Text!= "" && weighttextBox.Text!="" && passwordtextBox.Text!= "" && password2textBox.Text!="")//sprawdz czy username jest wolny 
            {
                un = userNametextBox.Text;
                if(!double.TryParse(weighttextBox.Text, out weight))
                {
                    string message = "Waga ma mieć wartość numeryczną";
                    MessageBox.Show(this, message, "Błędna wartość", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                pass1 = passwordtextBox.Text;
                pass2=password2textBox.Text;

                if(pass1!=pass2)
                {
                    string message = "Hasła się różnią";
                    MessageBox.Show(this, message, "Błędna wartość", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                try
                {
                    users u = newuser.CreateAccount(un, weight, pass1);
                    summary.Update(weight, 0, u, "");

                }
                catch (CreateAccountFailException ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }

                MessageBox.Show(this, "Zarejestrowano", "Gotowe", MessageBoxButtons.OK, MessageBoxIcon.None);


                Launch launchform = new Launch(mainform) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true, FormBorderStyle = FormBorderStyle.None };
                mainform.ChangeForm(launchform);
            }
            else
            {
                string message = "Rekordu są puste";
                MessageBox.Show(this, message, "Błędna wartość", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void backbutton_Click(object sender, EventArgs e)
        {
            Launch launchform = new Launch(mainform) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true, FormBorderStyle = FormBorderStyle.None };
            mainform.ChangeForm(launchform);
        }


    }
}
