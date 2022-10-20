
namespace LIbrary
{
    public class calculator
    {
        public static double firstValue()
        {
            double firstValue;
            Console.WriteLine("Enter first value.");
            firstValue = Convert.ToDouble(Console.ReadLine());
            return firstValue;
        }

        public static double secondValue()
        {
            double secondValue;
            Console.WriteLine("Enter second value.");
            secondValue = Convert.ToDouble(Console.ReadLine());
            return secondValue;
        }

        public static string chooseAction ()
        { 
            Console.WriteLine("Choose one of the action: div, add, sub, mult.");
            string action = Console.ReadLine();
            return action;
            
        }

        public static string Menu()
        {
            Console.WriteLine("Choose one of the action: \n\n1.Continue claculatings? \n\t2.Output five last results? \n\t\t3.Repeat last action. \n\t\t\t 4.Exit the program.");
            string cont = Console.ReadLine();
            return cont;
        }

    }
}