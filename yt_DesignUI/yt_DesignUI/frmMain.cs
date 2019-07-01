using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace yt_DesignUI
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();

            Animator.Start();
        }

        private void yt_Button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Моя кнопка!");
        }
    }
}
