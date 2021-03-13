using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScoreCalcApp
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void BtnResult_Click(object sender, EventArgs e)
        {
            double sum = double.Parse(Txt경제학원론.Text)
                + double.Parse(Txt국제경제학.Text)
                + double.Parse(Txt시사경제론.Text);

            double avg = sum / 3;
            
            TxtTotal.Text = sum.ToString();
            TxtAvg.Text = avg.ToString("0.0");
        }
    }
}
