using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaCalories
{
    public static class DoughValidator
    {
        private static Dictionary<string, double> flourTypes;
        private static Dictionary<string, double> bakingTechnique;

        public static bool IsValidFlourType(string type)
        {
            if (flourTypes == null || bakingTechnique == null)
            {
                Initialize();
            }
            
            return flourTypes.ContainsKey(type.ToLower());
        }
        public static bool IsValidBakingTechnique(string technique)
        {
            if ( flourTypes == null || bakingTechnique == null)
            {
                Initialize();
            }

            return bakingTechnique.ContainsKey(technique.ToLower());
        }

        public static double GetFlourModifier(string type)
            => flourTypes[type.ToLower()];

        public static double GetBakingModifier(string type)
            => bakingTechnique[type.ToLower()];

        private static void Initialize()
        {
            flourTypes = new Dictionary<string, double>();
            bakingTechnique = new Dictionary<string, double>();

            flourTypes.Add("white", 1.5);
            flourTypes.Add("wholegrain", 1);

            bakingTechnique.Add("crispy", 0.9);
            bakingTechnique.Add("chewy", 1.1);
            bakingTechnique.Add("homemade", 1);
        }
    }
}
