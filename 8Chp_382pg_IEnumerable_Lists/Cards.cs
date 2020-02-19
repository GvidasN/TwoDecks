using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8Chp_382pg_IEnumerable_Lists
{
    class Cards
    {
        public Suit suit { get; set; }
        public Value value { get; set; }

        public string Name
        {
            get
            {
                return value.ToString() + " of " + suit.ToString();
            }
        }

        public Cards(Suit suit, Value value)
        {
            this.suit = suit;
            this.value = value;
        }
    }
}
