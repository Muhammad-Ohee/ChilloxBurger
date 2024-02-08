using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChilloxBurger
{
    public class CostManager : AbstractBurger
    {
        public override decimal cost(decimal cost)
        {
            return cost;
        }

        public decimal customizationCost(int[] customizeBurgerArray)
        {
            BunCost = (customizeBurgerArray[0] == 0) ? 40 :
                      (customizeBurgerArray[0] == 1) ? 50 : 0;

            CheeseCost = (customizeBurgerArray[1] == 0) ? 0 :
                         (customizeBurgerArray[1] == 1) ? 10 :
                         (customizeBurgerArray[1] == 2) ? 20 : 0;

            SpicyCost = (customizeBurgerArray[2] == 0) ? 0 :
                        (customizeBurgerArray[2] == 1) ? 20 :
                        (customizeBurgerArray[2] == 2) ? 40 :
                        (customizeBurgerArray[2] == 3) ? 60 : 0;

            FrenchFriesCost = (customizeBurgerArray[3] == 1) ? 70 :
                              (customizeBurgerArray[3] == 2) ? 120 : 0;

            ShakesCost = (customizeBurgerArray[4] == 1) ? 140 :
                         (customizeBurgerArray[4] == 2) ? 160 :
                         (customizeBurgerArray[4] == 3) ? 170 : 0;
            return BunCost + CheeseCost + SpicyCost + FrenchFriesCost + ShakesCost;
        }
        
        

        public decimal chickenBurgerCost(decimal customizationCost)
        { 
            return chickenCost + customizationCost;
        }

        public decimal beefBurgerCost(decimal customizationCost)
        {
            return beefCost + customizationCost;
        }

        public decimal vegetableBurgerCost(decimal customizationCost)
        {
            return vegetableCost + customizationCost;
        }
    }
}
