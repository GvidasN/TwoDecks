using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8Chp_382pg_IEnumerable_Lists
{
    class CardComparer_BySuit:IComparer<Cards>
    {
        public int Compare(Cards x, Cards y)
        {
            if (x.suit > y.suit) return 1;
            if (x.suit < y.suit) return -1;
            if (x.value < y.value) return -1;
            if (x.value > y.value) return 1;
            return 0;
        }
    }
}
