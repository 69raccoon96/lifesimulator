namespace Life_Simulator
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.NameAge = new System.Windows.Forms.Label();
            this.Energy = new System.Windows.Forms.Label();
            this.Money = new System.Windows.Forms.Label();
            this.HealthBar = new System.Windows.Forms.ProgressBar();
            this.HappyBar = new System.Windows.Forms.ProgressBar();
            this.Health = new System.Windows.Forms.Label();
            this.Happy = new System.Windows.Forms.Label();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.Flat = new System.Windows.Forms.Button();
            this.Car = new System.Windows.Forms.Button();
            this.Computer = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.TimeInInternet = new System.Windows.Forms.Button();
            this.WithFriends = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.Freelance = new System.Windows.Forms.Button();
            this.Work = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.GoCourses = new System.Windows.Forms.Button();
            this.ReadBooks = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.GetMoney = new System.Windows.Forms.Label();
            this.SpendMoney = new System.Windows.Forms.Label();
            this.SkipYear = new System.Windows.Forms.Button();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.Medicine = new System.Windows.Forms.Label();
            this.Design = new System.Windows.Forms.Label();
            this.Programming = new System.Windows.Forms.Label();
            this.English = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Credit = new System.Windows.Forms.Button();
            this.ReturnCredit = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.tabPage6.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // NameAge
            // 
            this.NameAge.AutoSize = true;
            this.NameAge.Location = new System.Drawing.Point(9, 7);
            this.NameAge.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.NameAge.Name = "NameAge";
            this.NameAge.Size = new System.Drawing.Size(54, 13);
            this.NameAge.TabIndex = 0;
            this.NameAge.Text = "NameAge";
            // 
            // Energy
            // 
            this.Energy.AutoSize = true;
            this.Energy.Location = new System.Drawing.Point(261, 7);
            this.Energy.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Energy.Name = "Energy";
            this.Energy.Size = new System.Drawing.Size(40, 13);
            this.Energy.TabIndex = 1;
            this.Energy.Text = "Energy";
            // 
            // Money
            // 
            this.Money.AutoSize = true;
            this.Money.Location = new System.Drawing.Point(490, 7);
            this.Money.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Money.Name = "Money";
            this.Money.Size = new System.Drawing.Size(39, 13);
            this.Money.TabIndex = 2;
            this.Money.Text = "Money";
            // 
            // HealthBar
            // 
            this.HealthBar.Location = new System.Drawing.Point(95, 33);
            this.HealthBar.Margin = new System.Windows.Forms.Padding(2);
            this.HealthBar.Name = "HealthBar";
            this.HealthBar.Size = new System.Drawing.Size(501, 24);
            this.HealthBar.TabIndex = 4;
            // 
            // HappyBar
            // 
            this.HappyBar.Location = new System.Drawing.Point(95, 62);
            this.HappyBar.Margin = new System.Windows.Forms.Padding(2);
            this.HappyBar.Name = "HappyBar";
            this.HappyBar.Size = new System.Drawing.Size(501, 26);
            this.HappyBar.TabIndex = 5;
            // 
            // Health
            // 
            this.Health.AutoSize = true;
            this.Health.Location = new System.Drawing.Point(9, 33);
            this.Health.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Health.Name = "Health";
            this.Health.Size = new System.Drawing.Size(56, 13);
            this.Health.TabIndex = 6;
            this.Health.Text = "Здоровье";
            this.Health.Click += new System.EventHandler(this.Label4_Click);
            // 
            // Happy
            // 
            this.Happy.AutoSize = true;
            this.Happy.Location = new System.Drawing.Point(9, 62);
            this.Happy.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Happy.Name = "Happy";
            this.Happy.Size = new System.Drawing.Size(48, 13);
            this.Happy.TabIndex = 7;
            this.Happy.Text = "Счастье";
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.Flat);
            this.tabPage6.Controls.Add(this.Car);
            this.tabPage6.Controls.Add(this.Computer);
            this.tabPage6.Controls.Add(this.label2);
            this.tabPage6.Controls.Add(this.listBox2);
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage6.Size = new System.Drawing.Size(589, 385);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "Имущество";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // Flat
            // 
            this.Flat.Location = new System.Drawing.Point(6, 102);
            this.Flat.Margin = new System.Windows.Forms.Padding(2);
            this.Flat.Name = "Flat";
            this.Flat.Size = new System.Drawing.Size(120, 39);
            this.Flat.TabIndex = 4;
            this.Flat.Text = "Квартира 1млн";
            this.Flat.UseVisualStyleBackColor = true;
            this.Flat.Click += new System.EventHandler(this.Flat_Click);
            // 
            // Car
            // 
            this.Car.Location = new System.Drawing.Point(6, 58);
            this.Car.Margin = new System.Windows.Forms.Padding(2);
            this.Car.Name = "Car";
            this.Car.Size = new System.Drawing.Size(120, 40);
            this.Car.TabIndex = 3;
            this.Car.Text = "Машина 100к";
            this.Car.UseVisualStyleBackColor = true;
            this.Car.Click += new System.EventHandler(this.Car_Click);
            // 
            // Computer
            // 
            this.Computer.Location = new System.Drawing.Point(6, 14);
            this.Computer.Margin = new System.Windows.Forms.Padding(2);
            this.Computer.Name = "Computer";
            this.Computer.Size = new System.Drawing.Size(120, 39);
            this.Computer.TabIndex = 2;
            this.Computer.Text = "Компьютер 10к";
            this.Computer.UseVisualStyleBackColor = true;
            this.Computer.Click += new System.EventHandler(this.Computer_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(438, 16);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Текущее имущество";
            this.label2.Click += new System.EventHandler(this.Label2_Click);
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(440, 41);
            this.listBox2.Margin = new System.Windows.Forms.Padding(2);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(143, 186);
            this.listBox2.TabIndex = 0;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.label1);
            this.tabPage4.Controls.Add(this.listBox1);
            this.tabPage4.Controls.Add(this.TimeInInternet);
            this.tabPage4.Controls.Add(this.WithFriends);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage4.Size = new System.Drawing.Size(589, 385);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Социум";
            this.tabPage4.UseVisualStyleBackColor = true;
            this.tabPage4.Click += new System.EventHandler(this.TabPage4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(382, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Текущие взаимоотношения";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(382, 40);
            this.listBox1.Margin = new System.Windows.Forms.Padding(2);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(201, 186);
            this.listBox1.TabIndex = 3;
            this.listBox1.Click += new System.EventHandler(this.listBox1_Click);
            // 
            // TimeInInternet
            // 
            this.TimeInInternet.Location = new System.Drawing.Point(6, 40);
            this.TimeInInternet.Margin = new System.Windows.Forms.Padding(2);
            this.TimeInInternet.Name = "TimeInInternet";
            this.TimeInInternet.Size = new System.Drawing.Size(166, 22);
            this.TimeInInternet.TabIndex = 2;
            this.TimeInInternet.Text = "Сидеть в интернете";
            this.TimeInInternet.UseVisualStyleBackColor = true;
            this.TimeInInternet.Click += new System.EventHandler(this.Button4_Click);
            // 
            // WithFriends
            // 
            this.WithFriends.Location = new System.Drawing.Point(6, 13);
            this.WithFriends.Margin = new System.Windows.Forms.Padding(2);
            this.WithFriends.Name = "WithFriends";
            this.WithFriends.Size = new System.Drawing.Size(166, 22);
            this.WithFriends.TabIndex = 1;
            this.WithFriends.Text = "Проводить время с друзьями";
            this.WithFriends.UseVisualStyleBackColor = true;
            this.WithFriends.Click += new System.EventHandler(this.Button3_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.button3);
            this.tabPage3.Controls.Add(this.ReturnCredit);
            this.tabPage3.Controls.Add(this.Credit);
            this.tabPage3.Controls.Add(this.Freelance);
            this.tabPage3.Controls.Add(this.Work);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage3.Size = new System.Drawing.Size(589, 385);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Источник денег";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // Freelance
            // 
            this.Freelance.Location = new System.Drawing.Point(4, 61);
            this.Freelance.Margin = new System.Windows.Forms.Padding(2);
            this.Freelance.Name = "Freelance";
            this.Freelance.Size = new System.Drawing.Size(125, 38);
            this.Freelance.TabIndex = 1;
            this.Freelance.Text = "Фриланс ";
            this.Freelance.UseVisualStyleBackColor = true;
            this.Freelance.Click += new System.EventHandler(this.Button7_Click);
            // 
            // Work
            // 
            this.Work.Location = new System.Drawing.Point(2, 18);
            this.Work.Margin = new System.Windows.Forms.Padding(2);
            this.Work.Name = "Work";
            this.Work.Size = new System.Drawing.Size(125, 38);
            this.Work.TabIndex = 0;
            this.Work.Text = "Устроиться на работу";
            this.Work.UseVisualStyleBackColor = true;
            this.Work.Click += new System.EventHandler(this.Work_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.GoCourses);
            this.tabPage2.Controls.Add(this.ReadBooks);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage2.Size = new System.Drawing.Size(589, 385);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Развитие";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // GoCourses
            // 
            this.GoCourses.Location = new System.Drawing.Point(6, 47);
            this.GoCourses.Margin = new System.Windows.Forms.Padding(2);
            this.GoCourses.Name = "GoCourses";
            this.GoCourses.Size = new System.Drawing.Size(129, 22);
            this.GoCourses.TabIndex = 1;
            this.GoCourses.Text = "Сходить на курсы";
            this.GoCourses.UseVisualStyleBackColor = true;
            this.GoCourses.Click += new System.EventHandler(this.Button2_Click);
            // 
            // ReadBooks
            // 
            this.ReadBooks.Location = new System.Drawing.Point(6, 20);
            this.ReadBooks.Margin = new System.Windows.Forms.Padding(2);
            this.ReadBooks.Name = "ReadBooks";
            this.ReadBooks.Size = new System.Drawing.Size(129, 22);
            this.ReadBooks.TabIndex = 0;
            this.ReadBooks.Text = "Читать книги";
            this.ReadBooks.UseVisualStyleBackColor = true;
            this.ReadBooks.Click += new System.EventHandler(this.Button1_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage6);
            this.tabControl1.Location = new System.Drawing.Point(2, 93);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(597, 411);
            this.tabControl1.TabIndex = 3;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.SpendMoney);
            this.groupBox2.Controls.Add(this.GetMoney);
            this.groupBox2.Location = new System.Drawing.Point(8, 199);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(186, 128);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Деньги";
            // 
            // GetMoney
            // 
            this.GetMoney.AutoSize = true;
            this.GetMoney.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GetMoney.ForeColor = System.Drawing.Color.Lime;
            this.GetMoney.Location = new System.Drawing.Point(14, 18);
            this.GetMoney.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.GetMoney.Name = "GetMoney";
            this.GetMoney.Size = new System.Drawing.Size(0, 24);
            this.GetMoney.TabIndex = 0;
            // 
            // SpendMoney
            // 
            this.SpendMoney.AutoSize = true;
            this.SpendMoney.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SpendMoney.ForeColor = System.Drawing.Color.Red;
            this.SpendMoney.Location = new System.Drawing.Point(14, 41);
            this.SpendMoney.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.SpendMoney.Name = "SpendMoney";
            this.SpendMoney.Size = new System.Drawing.Size(0, 24);
            this.SpendMoney.TabIndex = 1;
            // 
            // SkipYear
            // 
            this.SkipYear.Location = new System.Drawing.Point(462, 333);
            this.SkipYear.Margin = new System.Windows.Forms.Padding(2);
            this.SkipYear.Name = "SkipYear";
            this.SkipYear.Size = new System.Drawing.Size(117, 45);
            this.SkipYear.TabIndex = 5;
            this.SkipYear.Text = "Прожить год";
            this.SkipYear.UseVisualStyleBackColor = true;
            this.SkipYear.Click += new System.EventHandler(this.Button5_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Controls.Add(this.SkipYear);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage1.Size = new System.Drawing.Size(589, 385);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Главная";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.Medicine);
            this.groupBox3.Controls.Add(this.Design);
            this.groupBox3.Controls.Add(this.Programming);
            this.groupBox3.Controls.Add(this.English);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox3.Location = new System.Drawing.Point(8, 14);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(308, 181);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Навыки";
            // 
            // Medicine
            // 
            this.Medicine.AutoSize = true;
            this.Medicine.Location = new System.Drawing.Point(4, 118);
            this.Medicine.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Medicine.Name = "Medicine";
            this.Medicine.Size = new System.Drawing.Size(0, 29);
            this.Medicine.TabIndex = 3;
            // 
            // Design
            // 
            this.Design.AutoSize = true;
            this.Design.Location = new System.Drawing.Point(4, 89);
            this.Design.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Design.Name = "Design";
            this.Design.Size = new System.Drawing.Size(0, 29);
            this.Design.TabIndex = 2;
            // 
            // Programming
            // 
            this.Programming.AutoSize = true;
            this.Programming.Location = new System.Drawing.Point(4, 59);
            this.Programming.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Programming.Name = "Programming";
            this.Programming.Size = new System.Drawing.Size(0, 29);
            this.Programming.TabIndex = 1;
            // 
            // English
            // 
            this.English.AutoSize = true;
            this.English.Location = new System.Drawing.Point(4, 30);
            this.English.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.English.Name = "English";
            this.English.Size = new System.Drawing.Size(0, 29);
            this.English.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 73);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 22);
            this.button1.TabIndex = 2;
            this.button1.Text = "Пойти на турнички";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(6, 100);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(129, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Сходить в больницу";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // Credit
            // 
            this.Credit.Location = new System.Drawing.Point(6, 103);
            this.Credit.Margin = new System.Windows.Forms.Padding(2);
            this.Credit.Name = "Credit";
            this.Credit.Size = new System.Drawing.Size(125, 38);
            this.Credit.TabIndex = 2;
            this.Credit.Text = "Взять кредит";
            this.Credit.UseVisualStyleBackColor = true;
            this.Credit.Click += new System.EventHandler(this.Credit_Click);
            // 
            // ReturnCredit
            // 
            this.ReturnCredit.Location = new System.Drawing.Point(6, 103);
            this.ReturnCredit.Margin = new System.Windows.Forms.Padding(2);
            this.ReturnCredit.Name = "ReturnCredit";
            this.ReturnCredit.Size = new System.Drawing.Size(125, 38);
            this.ReturnCredit.TabIndex = 3;
            this.ReturnCredit.Text = "Вернуть кредит";
            this.ReturnCredit.UseVisualStyleBackColor = true;
            this.ReturnCredit.Click += new System.EventHandler(this.ReturnCredit_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(345, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "label3";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(2, 19);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(125, 38);
            this.button3.TabIndex = 4;
            this.button3.Text = "Уволиться";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 504);
            this.Controls.Add(this.Happy);
            this.Controls.Add(this.Health);
            this.Controls.Add(this.HappyBar);
            this.Controls.Add(this.HealthBar);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.Money);
            this.Controls.Add(this.Energy);
            this.Controls.Add(this.NameAge);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Life Simulator";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabPage6.ResumeLayout(false);
            this.tabPage6.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NameAge;
        private System.Windows.Forms.Label Energy;
        private System.Windows.Forms.Label Money;
        private System.Windows.Forms.ProgressBar HealthBar;
        private System.Windows.Forms.ProgressBar HappyBar;
        private System.Windows.Forms.Label Health;
        private System.Windows.Forms.Label Happy;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button TimeInInternet;
        private System.Windows.Forms.Button WithFriends;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button Freelance;
        private System.Windows.Forms.Button Work;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button GoCourses;
        private System.Windows.Forms.Button ReadBooks;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Button Flat;
        private System.Windows.Forms.Button Car;
        private System.Windows.Forms.Button Computer;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button SkipYear;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label GetMoney;
        private System.Windows.Forms.Label SpendMoney;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label Medicine;
        private System.Windows.Forms.Label Design;
        private System.Windows.Forms.Label Programming;
        private System.Windows.Forms.Label English;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button Credit;
        private System.Windows.Forms.Button ReturnCredit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button3;
    }
}

