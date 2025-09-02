using System;
using System.Collections.Generic;
using System.Linq;
using Builder;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class Recipes
    {
        public Burger Classic(IBurgerBuilder builder)
        {
            return builder
                .WithBread("classic bun")
                .WithBeef("single patty")
                .WithCheese()
                .WithSauce("ketchup")
                .Build();
        }

        public Burger DoubleCheddar(IBurgerBuilder builder)
        {
            return builder
                .WithBread("brioche bun")
                .WithBeef("double patty")
                .WithCheese()
                .WithOnion()
                .WithSauce("cheddar sauce")
                .Build();
        }

    }
}
