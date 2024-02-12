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

        public decimal CustomizationCost(List<int> customizedBurgerList)
        {   
            BunCost = (customizedBurgerList[0] == 0) ? 40 :
                      (customizedBurgerList[0] == 1) ? 50 : 0;

            CheeseCost = (customizedBurgerList[1] == 0) ? 0 :
                         (customizedBurgerList[1] == 1) ? 10 :
                         (customizedBurgerList[1] == 2) ? 20 : 0;

            SpicyCost = (customizedBurgerList[2] == 0) ? 0 :
                        (customizedBurgerList[2] == 1) ? 20 :
                        (customizedBurgerList[2] == 2) ? 40 :
                        (customizedBurgerList[2] == 3) ? 60 : 0;

            FrenchFriesCost = (customizedBurgerList[3] == 1) ? 70 :
                              (customizedBurgerList[3] == 2) ? 120 : 0;

            ShakesCost = (customizedBurgerList[4] == 1) ? 140 :
                         (customizedBurgerList[4] == 2) ? 160 :
                         (customizedBurgerList[4] == 3) ? 170 : 0;
            return BunCost + CheeseCost + SpicyCost + FrenchFriesCost + ShakesCost;
        }



        public decimal ChickenBurgerCost(decimal customizationCost)
        { 
            return chickenCost + customizationCost;
        }

        public decimal BeefBurgerCost(decimal customizationCost)
        {
            return beefCost + customizationCost;
        }

        public decimal VegetableBurgerCost(decimal customizationCost)
        {
            return vegetableCost + customizationCost;
        }
    }
}
