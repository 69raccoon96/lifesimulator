using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Life_Simulator
{
    public class Persons
    {
        // Выделить общее у Player и Persons в отдельный класс (Person)
        public string name;
        public string lName;
        public int age;
        public bool male;
        public int relation = 5;
        public Bitmap face;
        public Bitmap lips;
        public Bitmap eys;
        public Bitmap nose;
        public int yearsWithoutAttention;
        public Persons(string name, string lName, int age, bool male)
        {
            this.name = name;
            this.lName = lName;
            this.age = age;
            this.male = male;
            var gener = new FaceGenerator();
            var faceComponents = FaceGenerator.GenFace(male);
            this.face = faceComponents[0];
            this.lips = faceComponents[3];
            this.eys = faceComponents[1];
            this.nose = faceComponents[2];
            yearsWithoutAttention = 0;
        }
    }
}
