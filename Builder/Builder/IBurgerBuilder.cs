using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public interface IBurgerBuilder
    {
        IBurgerBuilder WithBread(string bread);
        IBurgerBuilder WithBeef(string beef);
        IBurgerBuilder WithCheese(bool hasCheese = true);
        IBurgerBuilder WithLettuce(bool hasLettuce = true);
        IBurgerBuilder WithTomato(bool hasTomato = true);
        IBurgerBuilder WithOnion(bool hasOnion = true);
        IBurgerBuilder WithSauce(string sauce);
        Burger Build();

    }
}
