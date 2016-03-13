using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genetic_Algorithm
{
    abstract class Chromosone
    {
        public Gene[] Genes { get; protected set; }

        public float Fitness { get; protected set; }

        public abstract Chromosone CrossOver(Chromosone b);

        public abstract void CalculateFitness();

        public abstract void Mutate(Object obj);

        #region Operators
        public static bool operator >(Chromosone left, Chromosone right)
        {
            return left.Fitness > right.Fitness;
        }

        public static bool operator >=(Chromosone left, Chromosone right)
        {
            return left.Fitness >= right.Fitness;
        }

        public static bool operator <(Chromosone left, Chromosone right)
        {
            return left.Fitness < right.Fitness;
        }

        public static bool operator <=(Chromosone left, Chromosone right)
        {
            return left.Fitness <= right.Fitness;
        }

        public static bool operator ==(Chromosone left, Chromosone right)
        {
            return left.Fitness == right.Fitness;
        }

        public static bool operator !=(Chromosone left, Chromosone right)
        {
            return left.Fitness != right.Fitness;
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
        #endregion
    }

    public struct Gene
    {
        public double Value;
        public string Name;
        public Gene(string name, double value)
        {
            Value = value;
            Name = name;
        }
    }
}
