using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class Burger
    {
        public string Bread { get; internal set; } = "";
        public string Beef { get; internal set; } = "";
        public string Sauce { get; internal set; } = "";
        public bool Cheese { get; internal set; }
        public bool Lettuce { get; internal set; }
        public bool Tomato { get; internal set; }
        public bool Onion { get; internal set; }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine("---Ingredients---");
            sb.AppendLine($"° Bread: {Bread}");
            sb.AppendLine($"° Beef: {Beef}");

            if (!string.IsNullOrEmpty(Sauce))
            {
                sb.AppendLine($"° Sauce: {Sauce}");
            }
            if (Cheese == true) { sb.AppendLine($"° Cheese: {Cheese}"); }
            if (Lettuce == true) { sb.AppendLine($"° Lettuce: {Lettuce}"); }
            if (Tomato == true) { sb.AppendLine($"° Tomato: {Tomato}"); }
            if (Onion == true) { sb.AppendLine($"° Onion: {Onion}"); }
            return sb.ToString();

        }
    }
}
