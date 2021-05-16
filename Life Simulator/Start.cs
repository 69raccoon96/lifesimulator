using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Life_Simulator
{
    public partial class Start : Form
    {
        bool male = true;
        public Start()
        {
            InitializeComponent();
        }

        private void TextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                GoNext();
        }
        public void GoNext()
        {
            Form1 main = new Form1(this.textBox1, male);
            this.Hide();
            main.Show();

        }
        private void Start_Load(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            male = true;
        }

        private void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            male = false;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            GoNext();
        }
    }
}
