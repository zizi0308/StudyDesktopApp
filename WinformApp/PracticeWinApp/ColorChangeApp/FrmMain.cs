using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ColorChangeApp
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }
        
        private void Trackbar_Scroll(object sender, EventArgs e) // 같은 스크롤 이벤트라면 하나로 통합하는것이 더 경제적이다
        {
            TxtRed.Text = TrbRed.Value.ToString();
            TxtGreen.Text = TrbGreen.Value.ToString();
            TxtBlue.Text = TrbBlue.Value.ToString();

            PnlResult.BackColor = Color.FromArgb(TrbRed.Value, TrbGreen.Value, TrbBlue.Value);
        }

        private void BtnOpen_Click(object sender, EventArgs e)
        {
            /*OpenFileDialog dialog = new OpenFileDialog();
            dialog.ShowDialog(); 직접 코딩하는 방법 */
            openFileDialog1.ShowDialog(); // 도구상자에서 Dialog 드래그한 뒤 코딩하는 방법
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
        }

        private void BtnColor_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
        }
    }
}
