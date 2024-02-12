using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChilloxBurger
{
    public class VegetableBurger : AbstractBurger
    {
        public VegetableBurger(string burgerType)
        {
            this.burgerType = burgerType;
        }

        public override void display()
        {
            Console.WriteLine($"Please Select {this.burgerType} Burger Property.");
        }

        public VegetableBurger(CustomizeBurger customizeBurger, CostManager costManager)
        {
            decimal customizationCost = costManager.CustomizationCost(customizeBurger.getCustomizedList());
            vegetableBurgerCost = costManager.VegetableBurgerCost(customizationCost);
            Console.WriteLine($"Your vegetable burger cost is {vegetableBurgerCost}");
        }


        public override decimal cost(decimal cost)
        {
            decimal totalCost = beefCost +
                                this.BunCost +
                                this.CheeseCost +
                                this.SpicyCost +
                                this.FrenchFriesCost +
                                this.ShakesCost;
            return 0;
        }
    }
}
