using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genetic_Algorithm
{
    class Genetic_Algorithm
    {
        private Chromosone[] chromosones;
        private int mutationRate;
        private Object mutationRange;

        public Genetic_Algorithm(Chromosone[] chromo, int mutation_rate, Object mutation_range)
        {
            this.chromosones = chromo;
            Quicksort.Sort(chromosones);
            this.mutationRate = mutation_rate;
            this.mutationRange = mutation_range;
        }

        public void Solve()
        {

        }

        public void Next()
        {
            int halfway = chromosones.Length / 2;
            for (int i = halfway; i < chromosones.Length; i += 2)
            {
                chromosones[i] = chromosones[i - halfway].CrossOver(chromosones[i - halfway + 1]);
            }

            foreach (Chromosone c in chromosones)
            {
                if (Program.GetRandom(0, 100) <= mutationRate)
                    c.Mutate(mutationRange);
                c.CalculateFitness();
            }

            Quicksort.Sort(chromosones);
        }

        public string Log(int num)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < num; i++ )
            {
                sb.Append(string.Format("Csone {0}: {1}", i, chromosones[i].Fitness));
                foreach (Gene g in chromosones[i].Genes)
                    sb.Append(string.Format(" , {0}: {1}", g.Name, g.Value));
                sb.Append("\n");
            }
            sb.Append("\n");
            return sb.ToString();
        }
    }
}
