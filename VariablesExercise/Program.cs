namespace VariablesExercise
{
    public class Program
    {
        static void Main(string[] args)
        {

            // Step 1:
            string dinnerType = "Tacos";
            int tacoCount = 3;
            char eatTacos = 'y';
            bool initiateEating = true;
            double price = 2.0;
            decimal bundlePrice = 1.5m;


            // Step 2:
            Console.WriteLine($"Tonight I want to eat {dinnerType}.\n" +
                              $"I plan to eat {tacoCount} tacos.\n" +
                              $"y/n should I start eating now? ... {eatTacos}.\n" +
                              $"System check: Am I clear to start eating? {initiateEating}.\n" +
                              $"Note: Tacos cost {price} if you buy them individually.\n" +
                              $"Note: Tacos cost {bundlePrice} if you buy them 3 at a time.\n");
        }
    }
}
