using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextViewerApp
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            DlgSelectText.FileName = "Select a text file";
            DlgSelectText.Filter = "Text files (*.txt)|*.txt"; // Text files (*.txt) 확장자에 적어주는 부분 << txt파일만 선택할 수 있게
            DlgSelectText.Title = "Open text file";
        }

        private void BtnSelectFile_Click(object sender, EventArgs e)
        {
            if (DlgSelectText.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    var filePath = DlgSelectText.FileName;

                    using (FileStream fs = File.Open(filePath, FileMode.Open))
                    {
                        Process.Start("notepad.exe", filePath);
                    }
                }
                catch (SecurityException ex)
                {
                    MessageBox.Show($"{ex.Message}");
                }
            }
        }
    }
}
