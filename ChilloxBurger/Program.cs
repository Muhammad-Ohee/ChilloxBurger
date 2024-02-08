//Console.WriteLine("Hello, World!");

namespace ChilloxBurger
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Chillox Burger.");

            CustomizeBurger customizeBurger = new CustomizeBurger();
            CostManager costManager = new CostManager();

            bool love = true;
            while (love)
            {
                Console.WriteLine("Hello Sir,");
                Console.WriteLine("How can I serve you?");
                Console.WriteLine("Do you need a burger? \"Yes or No\" ");
                
                string answer = Console.ReadLine().ToUpper();
                if (answer == "YES")
                {
                    Console.WriteLine("You want \"chicken or beef or vegetable\"?");
                    string answerBurger = Console.ReadLine().ToUpper();
                    if (answerBurger == "CHICKEN")
                    {
                        ChickenBurger chickenDisplay = new ChickenBurger("Chicken");
                        chickenDisplay.display();
                        ChickenBurger finalCostOfChickenBurger = new ChickenBurger(customizeBurger, costManager);

                        Console.WriteLine("Wanna buy another one? Yes or No");
                        string ans = Console.ReadLine().ToUpper();
                        if(ans == "YES")
                        {
                            Console.Clear();
                            continue;
                        }
                        else
                        {
                            Console.WriteLine();
                            Console.WriteLine("Thnak you for coming to chillox.");
                            Console.WriteLine("Have a nice day, Sir.");
                            love = false;
                        }
                    }
                    else if (answerBurger == "BEEF")
                    {
                        BeefBurger beefDisplay = new BeefBurger("Beef");
                        beefDisplay.display();

                        BeefBurger finalCostOfBeefBurger = new BeefBurger(customizeBurger, costManager);

                        Console.WriteLine("Wanna buy another one? Yes or No");
                        string ans = Console.ReadLine().ToUpper();
                        if (ans == "YES")
                        {
                            Console.Clear();
                            continue;
                        }
                        else
                        {
                            Console.WriteLine();
                            Console.WriteLine("Thnak you for coming to chillox.");
                            Console.WriteLine("Have a nice day, Sir.");
                            love = false;
                        }
                    }
                    else if (answerBurger == "VEGETABLE")
                    {
                        VegetableBurger beefDisplay = new VegetableBurger("Vegetable");
                        beefDisplay.display();

                        VegetableBurger finalCostOfVegetableBurger = new VegetableBurger(customizeBurger, costManager);

                        Console.WriteLine("Wanna buy another one? Yes or No");
                        string ans = Console.ReadLine().ToUpper();
                        if (ans == "YES")
                        {
                            Console.Clear();
                            continue;
                        }
                        else
                        {
                            Console.WriteLine();
                            Console.WriteLine("Thnak you for coming to chillox.");
                            Console.WriteLine("Have a nice day, Sir.");
                            love = false;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Wrong Input.");
                    }
                }
                else if (answer == "NO")
                {
                    Console.WriteLine("Thnak you for coming to chillox.");
                    Console.WriteLine("Have a nice day, Sir.");
                    love = false;
                }
                else 
                {
                    Console.WriteLine("Wrong Input.");
                    Console.Clear();
                }
                //love = false;
            }
        }
    }
}