using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChilloxBurger
{
    public abstract class AbstractBurger : IBurger
    {
        public abstract decimal cost();

        public virtual void display()
        {
            Console.WriteLine("Welcome to Chillox Burger.");
        }

        //public abstract string BurgerSelect();
        //public abstract string BunSelect();
        //public abstract string cheeseSelect();
        //public abstract string spicySelect();
        //public abstract string frenchFriesSelect();
        //public abstract string shakesSelect();


    }
}
