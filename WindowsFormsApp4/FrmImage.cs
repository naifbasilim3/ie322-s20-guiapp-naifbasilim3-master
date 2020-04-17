using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class FrmImage : Form
    {
        public FrmImage()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void BtnLoadImage_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile("C:\\IE322_1845041\\WindowsFormsApp4.3128910");

        }

        

        private void BtnLoadImage_Click_1(object sender, EventArgs e)
        {

        }

        private void FrmImage_Load(object sender, EventArgs e)
        {

        }
    }
}
