using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChilloxBurger
{
    public class CustomizeBurger
    {
        public int selectBun()
        {
            Console.WriteLine("Which Bun: Sesame Bun(0) or Brioche Bun(1)");
            string bun = Console.ReadLine();
            int bunNumber;
            Int32.TryParse(bun, out bunNumber);
            return bunNumber;
        }

        public int selectCheese()
        {
            Console.WriteLine("How much cheese: Less Sauce(0) or Regular Sauce(1) or More Sauce(2)");
            string cheese = Console.ReadLine();
            int cheeseNumber;
            Int32.TryParse(cheese, out cheeseNumber);
            return cheeseNumber;
        }

        public int selectSpicy()
        {
            Console.WriteLine("How much spicy: Mild(0) or Spicy(1) or Very Spicy(2) or Naga(3)");
            string spicy = Console.ReadLine();
            int spicyNumber;
            Int32.TryParse(spicy, out spicyNumber);
            return spicyNumber;
        }

        public int selectFrenchFries()
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
            return frenchFriesNumber;
        }

        public int selectShakes()
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
            return shakesNumber;
        }

        public int[] getCustomizeArray()
        {
            int[] customizationArray = new int[5];
            customizationArray[0] = selectBun(); // 0 or 1
            customizationArray[1] = selectCheese(); // 0 or 1 or 2
            customizationArray[2] = selectSpicy(); // 0 or 1 or 2 or 3
            customizationArray[3] = selectFrenchFries(); // 1 or 2
            customizationArray[4] = selectShakes(); // 1 or 2 or 3

            return customizationArray;
        }
    }
}
