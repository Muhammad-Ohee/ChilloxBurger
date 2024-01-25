using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChilloxBurger
{
    public class BeefBurger : AbstractBurger
    {
        private readonly string burgerType;
        private decimal beefCost = 120;

        private readonly int selectBun;
        private decimal BunCost;

        private readonly int selectCheese;
        private decimal CheeseCost;

        private readonly int selectSpicy;
        private decimal SpicyCost;

        private readonly int selectFrenchFries;
        private decimal FrenchFriesCost;

        private readonly int selectShakes;
        private decimal ShakesCost;

        public BeefBurger(string burgerType)
        {
            this.burgerType = burgerType;
        }
        public BeefBurger(int selectBun, int selectCheese, int selectSpicy, int selectFrenchFries, int selectShakes)
        {
            this.selectBun = selectBun;
            if (this.selectBun == 0) // Sesame Bun
                this.BunCost = 40;
            else if (this.selectBun == 1) // Brioche Bun
                this.BunCost = 50;

            this.selectCheese = selectCheese;
            if (this.selectCheese == 0) // Less
                this.CheeseCost = 0;
            else if (this.selectCheese == 1) //Regular
                this.CheeseCost = 10;
            else if (this.selectCheese == 2) // More
                this.CheeseCost = 20;

            this.selectSpicy = selectSpicy;
            if (this.selectSpicy == 0) //Mild
                this.SpicyCost = 0;
            else if (this.selectSpicy == 1) // Spicy
                this.SpicyCost = 20;
            else if (this.selectSpicy == 2) // Very Spicy
                this.SpicyCost = 40;
            else if (this.selectSpicy == 3) //Naga
                this.SpicyCost = 60;


            this.selectFrenchFries = selectFrenchFries;
            if (this.selectFrenchFries == 0) // NO
                this.FrenchFriesCost = 0;
            else if (this.selectFrenchFries == 1) // Yes and Small Size
                this.FrenchFriesCost = 70;
            else if (this.selectFrenchFries == 2) // Yes and Big Size
                this.FrenchFriesCost = 120;

            this.selectShakes = selectShakes;
            if (this.selectShakes == 0) // No
                this.ShakesCost = 0;
            else if (this.selectShakes == 1) // Yes and Cold
                this.ShakesCost = 140;
            else if (this.selectShakes == 2) // Yes and Oreo
                this.ShakesCost = 160;
            else if (this.selectShakes == 3) // Yes and Munch
                this.ShakesCost = 170;
        }

        public override decimal cost()
        {
            decimal totalCost = beefCost +
                                this.BunCost +
                                this.CheeseCost +
                                this.SpicyCost +
                                this.FrenchFriesCost +
                                this.ShakesCost;
            return totalCost;
        }


        public override void display()
        {
            //Console.WriteLine("Welcome to Chillox Burger.");
            Console.WriteLine($"Please select {this.burgerType} property.");
        }

    }
}
