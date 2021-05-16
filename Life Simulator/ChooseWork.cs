using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LittleTetris;

namespace Life_Simulator
{
    public partial class ChooseWork : Form
    {
        private Player player;
        private Player.skills skills;
        public ChooseWork(Player player, Player.skills skills)
        {
            this.skills = skills;
            this.player = player;
            InitializeComponent();
        }

        private void ChooseWork_Load(object sender, EventArgs e)
        {
            foreach (var VARIABLE in Form1.currentWorks)
            {
                var line = VARIABLE.name + " Зарплата: " + VARIABLE.salary + " Требуемый навык: " + VARIABLE.skill;
                listBox1.Items.Add(line);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = listBox1.SelectedIndex;
            if (index != -1)
            {
                int currentSkil = 0;
                var currentJob = Form1.currentWorks[index];
                var line = currentJob.name.Split(' ')[1];
                switch (line)
                {
                    case "Программист":
                        currentSkil = skills.programming;
                        break;
                    case "Медик":
                        currentSkil = skills.medicine;
                        break;
                    case "Переводчик":
                        currentSkil = skills.english;
                        break;
                    case "Дизайнер":
                        currentSkil = skills.design;
                        break;
                }

                int dif = currentJob.skill - currentSkil;
                if (dif <= 0)
                {
                    MessageBox.Show("Вы приняты на работу", "Поздравляем", MessageBoxButtons.OK);
                    player.work = currentJob;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Для успешного собеседования вам нужно разместить " + dif + " фигур");
                    CallTetris();
                    if (Form1.ALive >= dif)
                    {
                        MessageBox.Show("Вы приняты на работу", "Поздравляем", MessageBoxButtons.OK);
                        player.work = currentJob;
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Вы провалились", "Сожалеем");
                        player.happy -= 10;
                    }
                }

                Form1.ALive = 0;
            }
        }
        public void CallTetris()
        {
            var form = new GetWork();

            try
            {
                form.ShowDialog();
            }
            catch
            {
                form.Close();
            }
        }
    }
}
