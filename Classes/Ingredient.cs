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
        private Double IngredientScale = 1;
        private Double IngredientAmount;
        private string IngredientMesurementUnit = "tablespoon";

        public Ingredient()
        {

        }

        public Ingredient(string name, float scale, double amount, string mesurementUnit)
        {
            this.IngredientName = name;
            this.IngredientScale = scale;
            this.IngredientAmount = amount;
            this.IngredientMesurementUnit = mesurementUnit;
        }

        public String Name(String name)
        {
            this.IngredientName = name;
            return this.IngredientName;
        }

        public String Name()
        {
            return this.IngredientName;
        }

        public double Amount(double amount)
        {
            this.IngredientAmount = amount;
            return this.IngredientAmount * this.IngredientScale;
        }

        public double Amount()
        {
            return this.IngredientAmount * this.IngredientScale;
        }

        public double SetScale(double scale)
        {
            this.IngredientScale = scale;
            return this.IngredientScale;
        }

        public double Scale()
        {
            return this.IngredientScale;
        }


        public String Unit(string unit)
        {
            this.IngredientMesurementUnit = unit;
            return this.IngredientMesurementUnit;
        }

        public String Unit()
        {
            return this.IngredientMesurementUnit;
        }

    }
}
