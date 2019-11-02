using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AsunaInject
{
    public partial class menuFrm : Form
    {
        public menuFrm()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void bunifuTileButton1_Click(object sender, EventArgs e)
        {
            chtLoader chtLoad = new chtLoader();
            chtLoad.Show();
            this.Hide();
        }

        private void bunifuTileButton3_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Wow You Found The Secret", "Asuna Secrets",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void bunifuTileButton2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Welcome To Asuna Loader An Open Source Cheat Loader Based Of Bunifu", "Asuna Info",
            MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void bunifuTileButton4_Click(object sender, EventArgs e)
        {

        }
    }
}
