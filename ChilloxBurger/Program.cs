//Console.WriteLine("Hello, World!");

namespace ChilloxBurger
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Chillox Burger.");
            bool love = true;
            while (love)
            {
                Console.WriteLine("Hello Sir,");
                Console.WriteLine("How can I serve you?");
                Console.WriteLine("Do you need a burger? \"Yes or No\" ");
                
                string answer = Console.ReadLine().ToUpper();
                if (answer == "YES")
                {
                    Console.WriteLine("You want \"chicken or beef\"?");
                    string answerBurger = Console.ReadLine().ToUpper();
                    if (answerBurger == "CHICKEN")
                    {
                        ChickenBurger chickenBurger = new ChickenBurger("Chicken");
                        chickenBurger.display();
                        ChickenBurgerCost cost1 = new ChickenBurgerCost();
                        Console.WriteLine();
                        Console.WriteLine($"Your total cost of chicken burger is: {cost1.getCost()} BDT");
                        Console.WriteLine();
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
                        BeefBurger beefBurger = new BeefBurger("Beef");
                        beefBurger.display();
                        BeefBurgerCost cost1 = new BeefBurgerCost();
                        Console.WriteLine();
                        Console.WriteLine($"Your total cost of beef burger is: {cost1.getCost()} BDT");
                        Console.WriteLine();
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