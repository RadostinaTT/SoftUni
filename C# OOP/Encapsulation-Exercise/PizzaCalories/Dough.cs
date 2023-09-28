using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaCalories
{
    public class Dough
    {
        private string flourType;
        private string bakingTechnique;
        private double weight;

        public Dough(string flourType, string bakingTechnique, double weight)
        {
            this.BakingTechnique = bakingTechnique;
            this.FlourType = flourType;
            this.Weight = weight;

        }
        private string FlourType
        {
            get
            {
                return flourType;
            }
            set
            {
                if (!DoughValidator.IsValidFlourType(value))
                {
                    throw new Exception("Invalid type of dough.");
                }
                flourType = value;
            }
        }
        private string BakingTechnique
        {
            get
            {
                return bakingTechnique;
            }
            set
            {
                if (!DoughValidator.IsValidBakingTechnique(value))
                {
                    throw new Exception("Invalid type of dough.");
                }
                bakingTechnique = value;
            }
        }

        public double Weight
        {
            get
            {
                return this.weight;
            }
            set
            {
                if (weight < 0 || weight > 200)
                {
                    throw new ArgumentException("Dough weight should be in the range [1..200].");
                }
                this.weight = value;
            }
        }

        
        public double GetTotalCalories()
        {
            return this.weight
                * 2
                * DoughValidator.GetBakingModifier(this.bakingTechnique)
                * DoughValidator.GetFlourModifier(this.flourType);
        }
    }
}
