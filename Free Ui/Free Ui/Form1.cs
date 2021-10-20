using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Free_Ui
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            home1.BringToFront(); // This Will Bring From Into Main Form
        }

        private void gunaButton3_Click(object sender, EventArgs e)
        {
            cool1.BringToFront(); //Brings Cool Form Into Here From pages
        }

        private void gunaButton4_Click(object sender, EventArgs e)
        {
            idk1.BringToFront();//dose same thing bring From into Main Form From pages Xd
        }
    }
}
