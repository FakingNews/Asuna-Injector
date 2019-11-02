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
    public partial class chtLoader : Form
    {
        public chtLoader()
        {
            InitializeComponent();
        }
        string exeName;

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstCheats.SelectedIndex == 0) 
            {
                lblGame.Text = "Counter-Strike: Global Offensive";
                label7.Text = "Version 1.0";
                lblStatus.Text = "Undetected";
                lblStatus.ForeColor = Color.LimeGreen;
            }
            else if (lstCheats.SelectedIndex == 1)
            {
                lblGame.Text = "Left 4 Dead 2";
                label7.Text = "Version 1.0";
                lblStatus.Text = "Undetected";
                lblStatus.ForeColor = Color.LimeGreen;
            }
            else if (lstCheats.SelectedIndex == 2)
            {
                lblGame.Text = "Rust";
                label7.Text = "Version 1.0";
                lblStatus.Text = "Undetected";
                lblStatus.ForeColor = Color.LimeGreen;
            }
            else if (lstCheats.SelectedIndex == 3)
            {
                lblGame.Text = "Fortnite";
                label7.Text = "Version 1.0";
                lblStatus.Text = "Detected";
                lblStatus.ForeColor = Color.Red;
            }
            else if (lstCheats.SelectedIndex == 4)
            {
                lblGame.Text = "Borderlands 3";
                label7.Text = "Version 1.0";
                lblStatus.Text = "Undetected";
                lblStatus.ForeColor = Color.LimeGreen;
            }
            else if (lstCheats.SelectedIndex == 5)
            {
                lblGame.Text = "Rainbow Six Siege";
                label7.Text = "Version 1.0";
                lblStatus.Text = "Detected";
                lblStatus.ForeColor = Color.Red;
            }
            else if (lstCheats.SelectedIndex == 6)
            {
                lblGame.Text = "Z1 Battle Royale";
                label7.Text = "Version 1.0";
                lblStatus.Text = "Undetected";
                lblStatus.ForeColor = Color.LimeGreen;
            }
            else if (lstCheats.SelectedIndex == 7)
            {
                lblGame.Text = "Dayz";
                label7.Text = "Version 1.0";
                lblStatus.Text = "Undetected";
                lblStatus.ForeColor = Color.LimeGreen;
            }
            else if (lstCheats.SelectedIndex == 8)
            {
                lblGame.Text = "7 Days To Die";
                label7.Text = "Version 1.0";
                lblStatus.Text = "Undetected";
                lblStatus.ForeColor = Color.LimeGreen;
            }
            else if (lstCheats.SelectedIndex == 9)
            {
                lblGame.Text = "Garrys Mod";
                label7.Text = "Version 1.0";
                lblStatus.Text = "Undetected";
                lblStatus.ForeColor = Color.LimeGreen;
            }
        }
        private void chtLoader_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void bunifuTileButton1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
