using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BettingRoulette
{
    public class Roulette
    {
        public long Id { get; set; }
        public string Status { get; set; }
        public Bet Bets { get; set; }

        public Roulette()
        {

        }
    }
}
