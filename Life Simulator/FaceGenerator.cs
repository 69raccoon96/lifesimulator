using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Life_Simulator
{
    class FaceGenerator
    {
        public static List<Bitmap> noses = new List<Bitmap>();
        public static List<Bitmap> fases = new List<Bitmap>();
        public static List<Bitmap> lips = new List<Bitmap>();
        public static List<Bitmap> eys = new List<Bitmap>();
        static Random gen = new Random();
        public FaceGenerator()
        {
            noses.Add(Properties.Resources.nose);
            noses.Add(Properties.Resources.nose2);
            noses.Add(Properties.Resources.nose3);
            fases.Add(Properties.Resources.man_face);
            fases.Add(Properties.Resources.woman_face);
            eys.Add(Properties.Resources.eys);
            eys.Add(Properties.Resources.eys2);
            eys.Add(Properties.Resources.eys3);
            lips.Add(Properties.Resources.lips);
            lips.Add(Properties.Resources.lips2);
            lips.Add(Properties.Resources.lips3);
        }

        public static Bitmap[] GenFace(bool male)
        {
            var result = new Bitmap[4];
            int nose = gen.Next(0, noses.Count);
            int lip = gen.Next(0, lips.Count);
            int eye = gen.Next(0, eys.Count);
            if (male)
                result[0] = fases[0];
            else
                result[0] = fases[1];
            result[1] = eys[eye];
            result[2] = noses[nose];
            result[3] = lips[lip];
            return result;
        }
    }
}
