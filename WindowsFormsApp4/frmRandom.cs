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
    public partial class frmRandom : Form
    {
        Random Y = new Random();
        public frmRandom()
        {
            InitializeComponent();
        }

        private void frmRandom_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            BtnNumber.Text = Convert.ToString(Y.Next(1, 100));
        }
    }
}
