using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgPoe.Classes
{
    internal class Worker
    {
        
        public Worker()
        {
        
        }

        public void Run()
        {
            Console.WriteLine("enter the name of the recipe:");
            var name = Console.ReadLine();

            Console.WriteLine("enter the number of ingredients:");
            var numIngredients = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("enter the number of steps:");
            var numSteps = Convert.ToInt32(Console.ReadLine());

            Recipe MyRecipe = new Recipe(name, numIngredients, numSteps);
            MyRecipe.InputIngredients();


            MyRecipe.PrintRecipe();
            Console.ReadLine();












        }


    }
}
