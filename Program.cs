
using Testing_01.BLL;

namespace Testing_01
    
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region user inputs
            Console.WriteLine("Operation: ");
            string operation = Console.ReadLine() ?? string.Empty;

            Console.Write("Valeur 1: ");
            double valeur1 = double.Parse(Console.ReadLine());

            Console.Write("Valeur 2: ");
            double valeur2 = double.Parse(Console.ReadLine());
            #endregion

            #region operation
            Calculator calculator = new Calculator();
            switch(operation){
                case "+":
                    Console.WriteLine("Resulte : " + calculator.Add(valeur1, valeur2));
                    break;
                case "-":
                    Console.WriteLine("Resulte : " + calculator.Substract(valeur1, valeur2));
                    break;
                case "*":
                    Console.WriteLine("Resulte : " + calculator.Multiply(valeur1, valeur2));
                    break;
                case "/":
                    Console.WriteLine("Resulte : " + calculator.Divide(valeur1, valeur2));
                    break;
                default:
                    Console.WriteLine("mauvais opérateur");
                    break;
            }
            #endregion

        }
    }
}