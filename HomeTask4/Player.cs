using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask4
{
    public class Player
    {
        public int Points { get; private set; }

        public void AddPoints(int points)
        {
            Points += points;
        }

        public void ResetPoints()
        {
            Points = 0;
        }
    }
}
