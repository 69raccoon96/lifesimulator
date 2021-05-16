using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Life_Simulator
{
    public struct Job
    {
        public string name;
        public double salary;
        public int skill;
        public string direction;
    }
    public class JobGenerator
    {
        public List<string> jobs;
        public List<string> levels;
        Random rnd = new Random();
        public JobGenerator()
        {
            jobs = new List<string>();
            levels = new List<string>();
            jobs.Add("Программист");
            jobs.Add("Медик");
            jobs.Add("Переводчик");
            jobs.Add("Дизайнер");
            levels.Add("Начинающий");
            levels.Add("Опытный");
            levels.Add("Профессиональный");
        }

        public Job JobGen()
        {
            string j = jobs[rnd.Next(0, jobs.Count)];
            string l = levels[rnd.Next(0, levels.Count)];
            var job = new Job();
            job.name = l + " " + j;
            job.direction = j;
            switch (l)
            {
                case "Начинающий":
                    job.skill = 20;
                    job.salary = rnd.Next(5000, 15000);
                    break;
                case "Опытный":
                    job.skill = 50;
                    job.salary = rnd.Next(15000, 40000);
                    break;
                case "Профессиональный":
                    job.skill = 80;
                    job.salary = rnd.Next(60000, 150000);
                    break;
            }

            return job;
        }
    }
}
