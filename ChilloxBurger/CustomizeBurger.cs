using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChilloxBurger
{
    public class CustomizeBurger
    {
        List<int> customizedBurger = new List<int>();
        public void selectBun()
        {
            Console.WriteLine("Which Bun: Sesame Bun(0) or Brioche Bun(1)");
            string bun = Console.ReadLine();
            int bunNumber;
            Int32.TryParse(bun, out bunNumber);
            customizedBurger.Add(bunNumber);
        }

        public void selectCheese()
        {
            Console.WriteLine("How much cheese: Less Sauce(0) or Regular Sauce(1) or More Sauce(2)");
            string cheese = Console.ReadLine();
            int cheeseNumber;
            Int32.TryParse(cheese, out cheeseNumber);
            customizedBurger.Add(cheeseNumber);
        }

        public void selectSpicy()
        {
            Console.WriteLine("How much spicy: Mild(0) or Spicy(1) or Very Spicy(2) or Naga(3)");
            string spicy = Console.ReadLine();
            int spicyNumber;
            Int32.TryParse(spicy, out spicyNumber);
            customizedBurger.Add(spicyNumber);
        }

        public void selectFrenchFries()
        {
            Console.WriteLine("Wanna try out french fries: Yes or No");
            string frenchFries = Console.ReadLine().ToUpper();
            int frenchFriesNumber = 0;
            if (frenchFries == "YES")
            {
                Console.WriteLine("Small(1) or Big(2)?");
                string frenchFriesSize = Console.ReadLine();
                Int32.TryParse(frenchFriesSize, out frenchFriesNumber);
            }
            customizedBurger.Add(frenchFriesNumber);
        }

        public void selectShakes()
        {
            Console.WriteLine("Have some cold shakes: Yes or No");
            string shakes = Console.ReadLine().ToUpper();
            int shakesNumber = 0;
            if (shakes == "YES")
            {
                Console.WriteLine("Cold(1) or Oreo(2) or Munch(3)?");
                string shakesType = Console.ReadLine();
                Int32.TryParse(shakesType, out shakesNumber);
            }
            customizedBurger.Add(shakesNumber);
        }

        public List<int> getCustomizedList()
        {
            selectBun(); // 0 or 1
            selectCheese(); // 0 or 1 or 2
            selectSpicy(); // 0 or 1 or 2 or 3
            selectFrenchFries(); // 1 or 2
            selectShakes(); // 1 or 2 or 3

            return customizedBurger;
        }
    }
}
