using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgPoe.Classes
{
    internal class Ingredient
    {
        private String IngredientName;
        private float IngredientScale = 1;
        private float IngredientAmount;
        private string IngredientMesurementUnit = "tablespoon";

        public Ingredient()
        {

        }

        public Ingredient(string name, float scale, float amount, string mesurementUnit)
        {
            IngredientName = name;
            IngredientScale = scale;
            IngredientAmount = amount;
            IngredientMesurementUnit = mesurementUnit;
        }

        public String Name(String name)
        {
            IngredientName = name;
            return IngredientName;
        }

        public float Amount(float amount)
        {
            IngredientAmount = amount;
            return IngredientAmount * IngredientScale;
        }

        public float SetScale(float scale)
        {
            IngredientScale = scale;
            return IngredientScale;
        }


    }
}
