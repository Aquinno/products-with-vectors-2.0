using System.Globalization;
namespace PraticaVetores2._2 {
    internal class Program {
        static void Main(string[] args) {
            Console.Write("How many products? ");
            int n = int.Parse(Console.ReadLine());
            Product[] vect = new Product[n];

            for (int i = 0; i < n; i++) {
                Console.Write($"Name {i + 1}º Product:");
                string name = Console.ReadLine();
                Console.Write($"Price {i + 1}º Product:");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                vect[i] = new Product { Name = name, Price = price };
            }
            double sum = 0.0;
            for (int i = 0; i < n; i++) {
                sum += vect[i].Price;
            }
            double avg = sum / n;
            Console.WriteLine($"Average Price: {avg.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}
