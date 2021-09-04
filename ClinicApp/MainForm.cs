using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bunifu_cards
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
     
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            
           
        }

        private void bunifuRadioButton1_CheckedChanged2(object sender, Bunifu.UI.WinForms.BunifuRadioButton.CheckedChangedEventArgs e)
        {
            if (e.Checked)
            {
                bunifuCards5.Visible = false;
                bunifuCards6.Visible = false;
                bunifuCards7.Visible = false;
                bunifuCards8.Visible = false;
                bunifuPages1.SelectTab(0);             
                bunifuTransition1.Show(bunifuCards1, false, Bunifu.UI.WinForms.BunifuAnimatorNS.Animation.Leaf);
                bunifuTransition1.Show(bunifuCards2, false, Bunifu.UI.WinForms.BunifuAnimatorNS.Animation.Mosaic);
                bunifuTransition1.Show(bunifuCards3, false, Bunifu.UI.WinForms.BunifuAnimatorNS.Animation.Mosaic);
                bunifuTransition1.Show(bunifuCards4, false, Bunifu.UI.WinForms.BunifuAnimatorNS.Animation.Mosaic);
            }
          
        }

        private void bunifuRadioButton2_CheckedChanged2(object sender, Bunifu.UI.WinForms.BunifuRadioButton.CheckedChangedEventArgs e)
        {
            if (e.Checked)
            {
                bunifuCards1.Visible = false;
                bunifuCards2.Visible = false;
                bunifuCards3.Visible = false;
                bunifuCards4.Visible = false;

                bunifuPages1.SelectTab(1);           
                bunifuTransition1.Show(bunifuCards8, false, Bunifu.UI.WinForms.BunifuAnimatorNS.Animation.Mosaic);
                bunifuTransition1.Show(bunifuCards7, false, Bunifu.UI.WinForms.BunifuAnimatorNS.Animation.Mosaic);
                bunifuTransition1.Show(bunifuCards6, false, Bunifu.UI.WinForms.BunifuAnimatorNS.Animation.Mosaic);
                bunifuTransition1.Show(bunifuCards5, false, Bunifu.UI.WinForms.BunifuAnimatorNS.Animation.Mosaic);

              
              
            }
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void bunifuLabel22_Click(object sender, EventArgs e)
        {

        }
    }
}
