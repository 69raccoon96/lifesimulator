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
    public partial class ChooseSubject : Form
    {
        public ChooseSubject()
        {
            InitializeComponent();
        }

        private void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            Form1.subject = radioButton1.Text;
        }

        private void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            Form1.subject = radioButton2.Text;
        }

        private void RadioButton3_CheckedChanged(object sender, EventArgs e)
        {
            Form1.subject = radioButton3.Text;
        }

        private void RadioButton4_CheckedChanged(object sender, EventArgs e)
        {
            Form1.subject = radioButton4.Text;
        }

        private void Button1_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Form1.subject = "";
            this.Close();
        }

        private void ChooseSubject_Load(object sender, EventArgs e)
        {

        }
    }
}
