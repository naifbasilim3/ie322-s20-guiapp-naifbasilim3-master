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
    public partial class FrmRandomCombo : Form
    {
        public FrmRandomCombo()

        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            for (int i = 0; i < r.Next(1, 50) - 1; i++)
            {
                CmbRandom.Items.Add(r.Next(1, 1000));
            }
        }

        private void FrnRandomCombo_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CmbRandom_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BtnGenerate2_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            for (int i = 0; i < r.Next(1, 50) - 1; i++)
            {
                CmbRandom2.Items.Add(r.Next(1, 100));
            }
        }
    }
}
