using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ChilloxBurger
{
    public class ChickenBurger : AbstractBurger
    {
        public ChickenBurger(string burgerType)
        {
            this.burgerType = burgerType;
        }

        public override void display()
        {
            Console.WriteLine($"Please Select {this.burgerType} Burger Property.");
        }

        public ChickenBurger(CustomizeBurger customizeBurger, CostManager costManager)
        {
            List<int> customizedList = customizeBurger.getCustomizedList();
            decimal customizationCost = costManager.CustomizationCost(customizedList);
            chickenBurgerCost = costManager.ChickenBurgerCost(customizationCost);
            Console.WriteLine($"Your chicken burger cost is {chickenBurgerCost}");
        }
        
        public override decimal cost(decimal cost)
        {
            decimal totalCost = chickenCost +
                                this.BunCost +
                                this.CheeseCost +
                                this.SpicyCost +
                                this.FrenchFriesCost +
                                this.ShakesCost;
            return 0;
        }
    }
}
