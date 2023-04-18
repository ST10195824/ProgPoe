using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgPoe.Classes
{
    internal class Recipe
    {
        private Ingredient[] Ingredients;



        public Recipe(int NumberOfIngredients)
        {
            Ingredients = new Ingredient[NumberOfIngredients];
        }
    }
}
