using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;

namespace ProgPoe.Classes
{
    /// <summary>
    /// stores a recipe which consists of an array of ingredients and an array of Instructions(steps)
    /// </summary>
    internal class Recipe
    {

        private Ingredient[] Ingredients;
        private string[] Steps;
        private string RecipeName;

        /// <summary>
        /// paramiterised constructor
        /// </summary>
        /// <param name="name"></param>
        /// <param name="NumberOfIngredients"></param>
        /// <param name="NumberOfSteps"></param>
        public Recipe(string name, int NumberOfIngredients, int NumberOfSteps)
        {
            this.RecipeName = name;
            Ingredients = new Ingredient[NumberOfIngredients];
            Steps = new string[NumberOfIngredients];
        }

        /// <summary>
        /// default constructor
        /// </summary>
        public Recipe()
        {
            //this doesnt instantiate arrays
            // will require a method to input their lengths
        }

        /// <summary>
        /// prints the entire recipe to the console
        /// </summary>
        public void PrintRecipe()
        {
            //redo this so its all fancy
            for (int i = 0; i < Ingredients.Length; i++)
            {
                var currentIngredient = this.Ingredients[i];
                Console.WriteLine(currentIngredient.Name() + " " + Convert.ToString(currentIngredient.Amount()) + " " + currentIngredient.Unit());
            }
        }

        public void ScaleRecipe(Recipe myRecipe,double scale )
        {
            foreach (var ingredient in myRecipe.Ingredients)
            {
                //ingredient array is private so idk if this will work

                ingredient.SetScale(scale);


            }
        }


        public void InputIngredients()
        {
            for (int i = 0;i < Ingredients.Length;i++)
            {
                Console.WriteLine("enter ingredient name:");
                var name = Console.ReadLine();

                Console.WriteLine("enter the unit of mesurement for " +  name);
                var unit = Console.ReadLine();

                Console.WriteLine("enter the number/amount of " + name);
                var amount = Convert.ToDouble(Console.ReadLine());

                Ingredients[i] = new Ingredient(name, 1, amount, unit);
            }
        }

    }
}
