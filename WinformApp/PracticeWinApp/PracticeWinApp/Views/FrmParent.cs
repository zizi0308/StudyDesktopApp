﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticeWinApp.Views
{
    public partial class FrmParent : Form
    {
        public FrmParent()
        {
            InitializeComponent();
        }

        private void FrmParent_Load(object sender, EventArgs e)
        {
            this.ClientSize = new Size(800, 600);

            FrmChild frm = new FrmChild();
            this.AddOwnedForm(frm); // 부모창 위에 자식창이 올라가있게하는 메서드

            frm.Show();
        }
    }
}
