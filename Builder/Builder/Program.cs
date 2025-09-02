using System;

namespace Builder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var builder = new ClassicBurgerBuilder();
                var recipes = new Recipes();
                var classic = recipes.Classic(builder);
                Console.WriteLine(classic);
                var doubleCheddar = recipes.DoubleCheddar(builder);
                Console.WriteLine(doubleCheddar);

                var custom = new ClassicBurgerBuilder()
                    .WithBread("Multigrain")
                        .WithBeef("Turkey")
                        .WithCheese()
                        .WithLettuce()
                        .WithTomato()
                        .WithOnion()
                        .WithSauce("Mayo")
                        .Build();
                Console.WriteLine(custom);
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine($"Error building burger: {ex.Message}");
            }
        }
    }
}
