using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genetic_Algorithm
{
    /// <summary>
    /// This class will try to find the max of -(x - 3.91)^2 + 30 and -(y - 9.82)^2 + 20
    /// </summary>
    class MyChromosone : Chromosone
    {
        public MyChromosone(double x, double y)
        {
            this.Genes = new Gene[2];
            Genes[0] = new Gene("x", x);
            Genes[1] = new Gene("y", y);
        }

        public static Chromosone GetRandom()
        {
            return new MyChromosone(Program.GetRandom(1, 10), Program.GetRandom(1, 10));
        }

        public override void CalculateFitness()
        {
            double ans1 = -Math.Pow(Genes[0].Value - 3.91, 2) + 30;
            double ans2 = -Math.Pow(Genes[1].Value - 9.82, 2) + 20;
            double fit = ans1 + ans2;
            Fitness = (float)fit;
        }

        public override Chromosone CrossOver(Chromosone b)
        {
            MyChromosone bb = b as MyChromosone;
            return new MyChromosone(Genes[0].Value, bb.Genes[1].Value);
        }

        public override void Mutate(Object obj)
        {
            int rand = Program.GetRandom(0, 1);
            double a = (double)obj;
            if (rand == 0) mutate(out Genes[0].Value, Genes[0].Value, a);
            else mutate(out Genes[1].Value, Genes[1].Value, a);
        }

        private void mutate(out double num, double value, double range)
        {
            int rand = Program.GetRandom(0, 1);
            if (rand == 0)
                num = value + range;
            else
                num = value - range;
        }
    }
}
