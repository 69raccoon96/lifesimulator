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
    public partial class Form1 : Form
    {
        public static string subject = "";
        Player player;
        Player.skills skills;
        ChooseSubject subjectForm = new ChooseSubject();
        NameGenerator generator = new NameGenerator();
        public static int listBoxName;
        public static int ALive = 0;
        NameGenerator gen = new NameGenerator();
        Random random = new Random();
        public static List<Job> currentWorks = new List<Job>();
        public static JobGenerator genJob = new JobGenerator();
        public Form1()
        {
            InitializeComponent();

        }
        public Form1(TextBox name, bool male)
        {

            InitializeComponent();
            label3.Text = "Безработный";
            button3.Visible = false;
            player = new Player(name.Text, 15, 500, 12, 30, 50, male);
            skills = new Player.skills();
            skills.design = 0;
            skills.programming = 0;
            skills.medicine = 0;
            skills.english = 0;
            ReturnCredit.Visible = false;
            for (int i = 0; i < 5; i++)
                player.friends.Add(gen.GeneratePerson(player.age));
            UpdateButtons();
            UpdateData();
            for (int i = 0; i < 10; i++)
                currentWorks.Add(genJob.JobGen());
        }
        public void UpdateData()
        {
            NameAge.Text = player.name + " " + player.age + " лет";
            Energy.Text = "Энергия " + player.energy;
            Money.Text = "Деньги " + player.money;
            if (player.health > 100)
                player.health = 100;
            if (player.health < 0)
            {
                player.health = 0;
                MessageBox.Show("Вам срочно нужно лечение!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            HealthBar.Value = player.health;
            if (player.happy > 100)
                player.happy = 100;
            if (player.happy < 0)
            {
                player.happy = 0;
                MessageBox.Show("Вы впадаете в депрессию!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            HappyBar.Value = player.happy;
            GetMoney.Text = "Доходы - " + player.getmoney;
            SpendMoney.Text = "Расходы - " + player.spendmoney;
            Programming.Text = "Программирование " + skills.programming;
            English.Text = "Английский язык " + skills.english;
            Medicine.Text = "Медицина " + skills.medicine;
            Design.Text = "Дизайн " + skills.design;

            listBox1.Items.Clear();
            for (int i = 0; i < player.friends.Count; i++)
            {
                var current = player.friends[i];
                var line = current.lName + " " + current.name + " " + current.age + " лет";
                listBox1.Items.Add(line);
            }
            listBox2.Items.Clear();
            for (int i = 0; i < player.inventory.Count; i++)
            {
                listBox2.Items.Add(player.inventory[i]);
            }


        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            if (player.energy == 0)
                MessageBox.Show("Вы потратили всю энергию", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                player.health += 10;
                player.energy -= 1;
            }
            UpdateData();
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            if (Check(0))
                TrainSkills(5, 5, 0);
        }
        private void Button2_Click(object sender, EventArgs e)
        {
            if (Check(500))
                TrainSkills(0, 10, 500);
        }
        public void TrainSkills(int happy, int profit, int cost)
        {
            string[] sub = { "Английский язык", "Программирование", "Дизайн", "Медицина" };
            ChangeForm(sub);
            subjectForm.ShowDialog();
            switch (subject)
            {
                case "Английский язык":
                    skills.english += profit;
                    break;
                case "Программирование":
                    skills.programming += profit;
                    break;
                case "Дизайн":
                    skills.design += profit;
                    break;
                case "Медицина":
                    skills.medicine += profit;
                    break;
            }
            if (subject != "")
            {
                player.energy -= 1;
                player.happy -= happy;
                player.money -= cost;
                player.spendmoney += cost;
                UpdateData();
            }
        }
        public bool Check(double cost)
        {
            if (player.money - cost < 0)
            {
                MessageBox.Show("Вам не хватает денег", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (player.happy == 0)
            {
                MessageBox.Show("Вы слишком подавлены, чтобы делать это", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (player.health == 0)
            {
                MessageBox.Show("Вы слишком больны, чтобы делать это", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (player.energy == 0)
            {
                MessageBox.Show("Вы потратили всю энергию", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }
        private void Button3_Click(object sender, EventArgs e)
        {
            if (player.energy - 1 < 0)
                return;
            var person = random.Next(-1, player.friends.Count);
            if (person != -1)
            {

                player.friends[person].relation += 5;
                if (player.friends[person].relation > 100)
                    player.friends[person].relation = 100;
                player.friends[person].yearsWithoutAttention = 0;
            }

            player.happy += 10;
            player.energy -= 1;
            var newfriend = random.Next(0, 2);
            if (newfriend == 1)
                player.friends.Add(generator.GeneratePerson(player.age));
            UpdateData();

        }
        public void UpdateButtons()
        {
            if (player.age < 16)
            {
                Work.Enabled = false;
            }
            else
                Work.Enabled = true;
            if (player.age < 18 || player.work.name == null)
                Credit.Enabled = false;
            else
            {
                Credit.Enabled = true;
            }
            if (player.age < 18 || player.inventory.Contains("Квартира"))
            {
                Flat.Enabled = false;
            }
            else
            {
                Flat.Enabled = true;
            }
            if (player.age < 16 || player.inventory.Contains("Машина"))
            {

                Car.Enabled = false;
            }
            else
            {
                Car.Enabled = true;
            }
            if (player.age < 14 || player.inventory.Contains("Компьютер"))
            {
                Computer.Enabled = false;
            }
            else
            {
                Computer.Enabled = true;
            }
        }
        private void Button5_Click(object sender, EventArgs e)
        {
            if (player.health == 0 || player.happy == 0)
            {
                MessageBox.Show("К сожалению вы умерли", "Игра окончена", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Application.Exit();
            }

            if (player.debt != 0)
            {
                player.yearLeft -= 1;
                if (player.yearLeft == 0)
                {
                    MessageBox.Show("Вы отправляетесь в тюрьму на 5 лет", "Вы не выплатили кредит",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    player.debt = 0;
                    player.yearLeft = 0;
                    for (int i = 0; i < 5; i++)
                        UpdateYear();
                    return;
                }
                MessageBox.Show("У вас осталось " + player.yearLeft + " лет, чтобы выплатить кредит", "Внимание",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

            UpdateYear();

        }

        public void UpdateYear()
        {
            var current = player.friends.GetRange(0, player.friends.Count);
            foreach (var friend in current)
            {
                friend.age++;
                if (player.crash == friend)
                    friend.yearsWithoutAttention = 0;
                friend.yearsWithoutAttention++;
                if (friend.yearsWithoutAttention == 4)
                    player.friends.Remove(friend);
            }

            player.health -= player.age / 10;
            player.money += player.work.salary;
            player.age += 1;
            player.spendmoney = 0;
            player.getmoney = 0;
            player.getmoney += player.work.salary;
            player.energy = 15;
            currentWorks.Clear();
            for (int i = 0; i < 10; i++)
                currentWorks.Add(genJob.JobGen());
            UpdateButtons();
            UpdateData();

        }
        private void Button7_Click(object sender, EventArgs e)
        {
            string[] work = { "Перевести текст", "Написать программу", "Сделать дизайн", "Подметать больницу" };
            ChangeForm(work);
            subjectForm.ShowDialog();
            switch (subject)
            {
                case "Перевести текст":
                    CheckSkills(ref skills.english);
                    break;
                case "Написать программу":
                    CheckSkills(ref skills.programming);
                    break;
                case "Сделать дизайн":
                    CheckSkills(ref skills.design);
                    break;
                case "Подметать больницу":
                    CheckSkills(ref skills.medicine);
                    break;
            }


        }
        public void CheckSkills(ref int skill)
        {
            int happy = 0;
            int cost = 0;
            if (skill < 10)
            {
                MessageBox.Show("Ваш навык слишком слабо развит", "Вы не получили денег", MessageBoxButtons.OK, MessageBoxIcon.Information);
                happy = -10;
                cost = 0;
            }
            if (skill > 10 && skill < 50)
            {
                cost = 100;
                MessageBox.Show("Вы заработали " + cost, "Деньги получены", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (skill > 50)
            {
                cost = 1000;
                MessageBox.Show("Вы заработали " + cost, "Деньги получены", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (subject != "")
            {
                player.energy -= 1;
                player.happy += happy;
                player.money += cost;
                player.getmoney += cost;
                UpdateData();
            }
        }
        public void ChangeForm(string[] subjects)
        {
            var current = (subjectForm.Controls["groupBox1"] as GroupBox);
            int i = 0;
            foreach (var tb in current.Controls.OfType<RadioButton>())
            {
                tb.Text = subjects[i];
                tb.Checked = false;
                i++;
            }
        }
        private void Computer_Click(object sender, EventArgs e)
        {
            if (player.money - 10000 < 0)
            {
                MessageBox.Show("Вам не хватает денег", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                player.happy += 10;
                player.inventory.Add("Компьютер");
                player.money -= 10000;
                player.spendmoney += 10000;
            }
            UpdateButtons();
            UpdateData();
        }
        private void Button4_Click(object sender, EventArgs e)
        {
            if (player.energy - 1 < 0)
                return;
            player.health -= 10;
            player.happy += 5;
            player.energy -= 1;
            var skill = random.Next(0, 5);
            if (skill < 2)
            {
                skills.programming += 1;

            }
            UpdateData();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void GroupBox1_Enter(object sender, EventArgs e)
        {

        }



        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void TabPage4_Click(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_Click(object sender, EventArgs e)
        {

            listBoxName = listBox1.SelectedIndex;
            if (listBoxName != -1)
            {
                var form = new Profile(player.friends[listBoxName], player);
                form.Show();
                UpdateData();
            }

        }

        private void Work_Click(object sender, EventArgs e)
        {
            var form = new ChooseWork(player, skills);
            form.ShowDialog();
            if (player.work.name != null)
            {
                label3.Text = player.work.name + "\n Зарплата: " + player.work.salary;
                Work.Visible = false;
                button3.Visible = true;
            }

            UpdateData();
        }


        private void button2_Click_1(object sender, EventArgs e)
        {
            if (Check(1000))
            {
                player.health += 50;
                player.money -= 1000;
                player.spendmoney += 1000;
                player.energy -= 1;
                UpdateData();
            }
        }

        private void Credit_Click(object sender, EventArgs e)
        {
            if (Check(0))
            {
                if (player.debt != 0)
                    MessageBox.Show("У вас уже есть кредит", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    var form = new Credit(player);
                    form.ShowDialog();
                    UpdateData();
                    if (player.debt != 0)
                    {
                        Credit.Visible = false;
                        ReturnCredit.Visible = true;
                    }
                }
            }
        }

        private void ReturnCredit_Click(object sender, EventArgs e)
        {
            if (Check(player.debt))
            {
                player.spendmoney += player.debt;
                player.money -= player.debt;
                player.debt = 0;
                player.yearLeft = 0;
                UpdateData();
                ReturnCredit.Visible = false;
                Credit.Visible = true;

            }
        }

        private void Car_Click(object sender, EventArgs e)
        {
            if (player.money - 100000 < 0)
            {
                MessageBox.Show("Вам не хватает денег", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                player.happy += 30;
                player.inventory.Add("Машина");
                player.money -= 100000;
                player.spendmoney += 100000;
            }
            UpdateButtons();
            UpdateData();
        }

        private void Flat_Click(object sender, EventArgs e)
        {
            if (player.money - 1000000 < 0)
            {
                MessageBox.Show("Вам не хватает денег", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                player.happy += 50;
                player.inventory.Add("Квартира");
                player.money -= 1000000;
                player.spendmoney += 1000000;
            }
            UpdateButtons();
            UpdateData();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Work.Visible = true;
            player.work = new Job();
            button3.Visible = false;
            label3.Text = "Безработный";

        }
    }
}
