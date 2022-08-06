using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dietaverse.View
{
    public partial class SmallPhoto : Form
    {
        bool isPhotoClicked = false;
        public SmallPhoto()
        {
            InitializeComponent();
            description.Visible = false;
        }

        public void pictureBox1_Click(object sender, EventArgs e)
        {
            if (isPhotoClicked == false)
            {
                description.Visible = true;
                isPhotoClicked = true;
            }
            else if(isPhotoClicked == true)
            {
                description.Visible=false;
                isPhotoClicked=false;
            }
        }

        public void description_Click(object sender, EventArgs e)
        {
            description.Visible = false;
        }
    }
}
