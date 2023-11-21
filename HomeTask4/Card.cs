using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask4
{
    public struct Card
    {
        public Enum.Suit Suit { get; set; }
        public Enum.Rank Rank { get; set; }

        public override string ToString()
        {
            return $"{Rank} of {Suit}";
        }
    }
}
