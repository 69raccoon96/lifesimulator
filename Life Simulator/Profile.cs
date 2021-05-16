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
    public partial class Profile : Form
    {
        private Persons person;
        private Player player;
        private static List<Image> image;
        private static List<Rectangle> rect;
        private Form1 form;
        public Profile(Persons person, Player player)
        {

            InitializeComponent();
            this.person = person;
            this.player = player;
            foreach (Form f in Application.OpenForms)
                if (f is Form1)
                    form = f as Form1;
        }

        private void Profile_Load(object sender, EventArgs e)
        {
            if (player.male == person.male || player.crash != null || player.age < 14 && person.age < 14)
                button3.Hide();
            if (player.crash == person)
                button3.Text = "Расстаться";
            CheckButton();
            image = new List<Image>();
            rect = new List<Rectangle>();
            image.Add(person.face);
            rect.Add(new Rectangle(0, 0, 150, 150));
            image.Add(person.eys);
            rect.Add(new Rectangle(53, 40, 40, 40));
            image.Add(person.nose);
            rect.Add(new Rectangle(60, 80, 25, 25));
            image.Add(person.lips);
            rect.Add(new Rectangle(55, 105, 35, 25));
            label1.Text = person.lName + " " + person.name + "\n" + person.age + " лет";
            progressBar1.Value = person.relation;
        }

        private void Profile_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            for (int i = 0; i < image.Count; i++)
                g.DrawImage(image[i], rect[i]);
        }

        private void CheckButton()
        {
            if (person.relation < 75)
                button3.Enabled = false;
            else
                button3.Enabled = true;
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (form.Check(100))
            {
                person.relation += 5;
                CheckBar();
                progressBar1.Value = person.relation;
                player.energy -= 1;
                person.yearsWithoutAttention = 0;
            }
            form.UpdateData();
            CheckButton();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (form.Check(100))
            {
                person.relation += 20;
                CheckBar();
                progressBar1.Value = person.relation;
                player.money -= 100;
                person.yearsWithoutAttention = 0;
            }
            form.UpdateData();
            CheckButton();
        }

        public void CheckBar()
        {
            if (person.relation > 100)
                person.relation = 100;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (player.crash == null)
            {
                player.crash = person;
                button3.Text = "Расстаться";
            }
            else
            {
                player.crash = null;
                button3.Text = "Предложить встречаться";
                person.relation -= 50;
            }
        }
    }
}
