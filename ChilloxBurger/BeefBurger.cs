using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChilloxBurger
{
    public class BeefBurger : AbstractBurger
    {
        public BeefBurger(string burgerType)
        {
            this.burgerType = burgerType;
        }

        public override void display()
        {
            Console.WriteLine($"Please Select {this.burgerType} Burger Property.");
        }

        public BeefBurger(CustomizeBurger customizeBurger, CostManager costManager)
        {
            decimal customizationCost = costManager.CustomizationCost(customizeBurger.getCustomizedList());
            beefBurgerCost = costManager.BeefBurgerCost(customizationCost);
            Console.WriteLine($"Your beef burger cost is {beefBurgerCost}");
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
