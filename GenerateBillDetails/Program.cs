using System;

namespace GenerateBillDetails
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of pizzas bought: ");
            int pizza = Convert.ToInt32(Console.ReadLine());
            decimal costOfPizzas = pizza * 200;

            Console.Write("Enter the number of puffs bought: ");
            int puff = Convert.ToInt32(Console.ReadLine());
            decimal costOfPuffs = puff * 40;

            Console.Write("Enter the number of pepsi bought: ");
            int pepsi = Convert.ToInt32(Console.ReadLine());
            decimal costOfPespsi = pepsi * 120;

            Console.WriteLine(Environment.NewLine + "Bill Details" + Environment.NewLine);

            decimal totalPrice = costOfPizzas + costOfPuffs + costOfPespsi;
            decimal gst = (totalPrice * 12) / 100;
            decimal cess = (totalPrice * 5) / 100;
            Console.WriteLine("Cost of Pizzas: " + costOfPizzas);
            Console.WriteLine("Cost of Puffs: " + costOfPuffs);
            Console.WriteLine("Cost of Pepsis: " + costOfPespsi);
            Console.WriteLine("GST 12%: " + gst);
            Console.WriteLine("CESS 5%: " + cess);
            Console.WriteLine("Total Price: " + totalPrice);
        }
    }
}
