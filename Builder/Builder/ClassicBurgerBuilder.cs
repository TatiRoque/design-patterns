using Builder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class ClassicBurgerBuilder : IBurgerBuilder
    {
        private Burger _burger = new Burger();

        public IBurgerBuilder WithBread(string bread)
        {
            _burger.Bread = bread;
            return this;
        }

        public IBurgerBuilder WithBeef(string beef)
        {
            _burger.Beef = beef;
            return this;
        }

        public IBurgerBuilder WithCheese(bool cheese = true)
        {
            _burger.Cheese = cheese;
            return this;
        }

        public IBurgerBuilder WithLettuce(bool lettuce = true)
        {
            _burger.Lettuce = lettuce;
            return this;
        }

        public IBurgerBuilder WithTomato(bool tomato = true)
        {
            _burger.Tomato = tomato;
            return this;
        }

        public IBurgerBuilder WithOnion(bool onion = true)
        {
            _burger.Onion = onion;
            return this;
        }

        public IBurgerBuilder WithSauce(string sauce)
        {
            _burger.Sauce = sauce;
            return this;
        }

        public Burger Build()
        {
            if (string.IsNullOrWhiteSpace(_burger.Bread))
                throw new InvalidOperationException("The burger must have bread.");

            if (string.IsNullOrWhiteSpace(_burger.Beef))
                throw new InvalidOperationException("The burger must have at least one beef patty.");

            Burger result = _burger;

            _burger = new Burger();

            return result;
        }
    }
}
