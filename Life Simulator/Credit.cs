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
    public partial class Credit : Form
    {
        private Player player;
        public double currentSum = 0;
        public Credit(Player player)
        {
            InitializeComponent();
            button1.Enabled = false;
            this.player = player;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text.Length != 0)
            {
                double.TryParse(textBox1.Text, out double current);
                if (current > 0)
                {
                    currentSum = current;
                    label2.Text = "Вам нужно будет вернуть: \n" + (current + current * 0.1);
                    button1.Enabled = true;
                }
            }

            if (textBox1.Text.Length == 0)
            {
                label2.Text = "Вам нужно будет вернуть: \n" + 0;
                currentSum = 0;
                button1.Enabled = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            player.debt = 0;
            player.yearLeft = 0;
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            player.debt = currentSum + currentSum * 0.1;
            player.money += currentSum;
            player.yearLeft = 5;
            player.getmoney += currentSum;
            this.Close();
        }
    }
}
