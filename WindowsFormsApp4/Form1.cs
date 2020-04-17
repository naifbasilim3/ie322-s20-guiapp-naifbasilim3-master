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
    public partial class Form1 : Form
    {
        string username = "Naif";
        string mypassword = "1234";
        int attempt = 1;
        int maxattempts = 3;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BtnRandom_Click(object sender, EventArgs e)
        {
            frmRandom frm = new frmRandom();
            frm.ShowDialog();
        }

        private void BtnCombo_Click(object sender, EventArgs e)
        {
            FrmCombo frm = new FrmCombo();
            frm.ShowDialog();
        }

        private void BtnictureBox_Click(object sender, EventArgs e)
        {
            FrmImage frm = new FrmImage();
            frm.ShowDialog();
        }

        private void BtnRandomCombo_Click(object sender, EventArgs e)
        {
            FrmRandomCombo frm = new FrmRandomCombo();
            frm.ShowDialog();
        }

        private void BtnCheckBox_Click(object sender, EventArgs e)
        {
            FrmCheck frm = new FrmCheck();
            frm.ShowDialog();
        }

        private void BtnRadio_Click(object sender, EventArgs e)
        {
            Frmradio frm = new Frmradio();
            frm.ShowDialog();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {

            while (attempt <= 3)
            {
                if (TxtUser.Text != username)
                {
                    // username is incorrect
                    MessageBox.Show("Invalid username");
                    break;
                }
                else
                {
                    // username is correct 
                    // so check password
                    if (TxtPass.Text != "1234")

                    { // Incorrect password
                        MessageBox.Show("Incorrect password");

                    }

                }

            }
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
