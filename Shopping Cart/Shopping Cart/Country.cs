using System;
using System.Collections.Generic;
using System.Text;

namespace Shopping_Cart
{
    class Country
    {
        public string Abbreviation { get; }
        public int Rate { get; }

        public Country(string abbreviation, int rate)
        {
            Abbreviation = abbreviation;
            Rate = rate;
        }
    }
}
