using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Life_Simulator
{
    class NameGenerator
    {
        // модификаторы доступа
        string[] MaleNames, FemaleNames,MaleLNames,FemaleLNames,MaleOt,FemaleOt;
        static Random gen = new Random();
        public NameGenerator()
        {
            MaleNames = Separete(Properties.Resources.baseMenName);
            FemaleNames = Separete(Properties.Resources.baseWomenName);
            MaleLNames = Separete(Properties.Resources.baseMenFam);
            FemaleLNames = Separete(Properties.Resources.baseWomenFam);
        }
        public string[] Separete(string line)
        {
            return line.Split(new char[] { '|', '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);
        }
        public Persons GeneratePerson(int current)
        {
            // gender?
            var choose = gen.Next(0, 2);
            string name, lName;
            if(choose == 0)
            {
                name = MaleNames[gen.Next(0, MaleNames.Length)];
                lName = MaleLNames[gen.Next(0, MaleLNames.Length)];
            }else
            {
                name = FemaleNames[gen.Next(0, FemaleNames.Length)];
                lName = FemaleLNames[gen.Next(0, FemaleLNames.Length)];
            }
            var age = current + gen.Next(-5, 5);
            return new Persons(name, lName, age, choose == 0 ? true : false);
        }
    }
}
