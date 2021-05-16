using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Life_Simulator
{
    public class Player
    {
        // Посмотреть семинар Домашних И., положить модели в папку Domains, создать проект для тестов, написать тесты
        // Сделать свойствами, выставить ограничения на нижнюю и верхнюю границу у свойств (длина имени, минимальный возраст и т.п.)
        // Выделить сущности из вкладок в форме (развитие, социум, ...)
        // Отделить лоигку от представления, т.е. у игрока сделать методы
        // добавить метод развиться - принимает на вход одну из моделей развития, которая содержит в себе затраты и т.д.
        // результат метода  - изменить состояние игрока
        public string name;
        public int energy;
        public double money;
        public int age;
        public int happy;
        public int health;
        public bool male = true;
        public double getmoney = 0;
        public double spendmoney = 0;
        public Job work = new Job();
        public double debt = 0;
        public int yearLeft;
        public List<string> inventory = new List<string>();
        public List<Persons> friends = new List<Persons>();
        public Persons crash = null;
        public Player(string name, int energy, double money, int age, int happy, int health, bool male)
        {
            this.name = name;
            this.energy = energy;
            this.money = money;
            this.age = age;
            this.happy = happy;
            this.health = health;
            this.male = male;
        }
        public struct skills
        {
            public int programming;
            public int design;
            public int english;
            public int medicine;
        }
    }

}
