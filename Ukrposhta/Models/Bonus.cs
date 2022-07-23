using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ukrposhta.Interfaces;

namespace Ukrposhta
{
    class Bonus : IBonus
    {
        public int Id { get; set; }
        public string Grade { get; set; }
        public string Percent { get; set; }

    }
}
