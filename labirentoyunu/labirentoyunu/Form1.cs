using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace labirentoyunu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label18_MouseEnter(object sender, EventArgs e)
        {
            MessageBox.Show("duvara dokundunuz!!");
        }

        private void label19_Click(object sender, EventArgs e)
        {
            MessageBox.Show("tebrikler,kazandınız!!");
        }
    }
}
