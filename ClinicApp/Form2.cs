using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bunifu.UI.WinForms.BunifuAnimatorNS;
namespace Bunifu_cards
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

private async void Form2_Load(object sender, EventArgs e)
{
    await Task.Delay(500);
    bunifuTransition1.ShowSync(bunifuCards1, false, Animation.Mosaic);
    bunifuTransition1.ShowSync(bunifuCards2, false, Animation.ScaleAndHorizSlide);
    bunifuTransition1.ShowSync(bunifuCards3, false, Animation.Mosaic);
    bunifuTransition1.ShowSync(bunifuCards4, false, Animation.Mosaic);
}
    }
}
