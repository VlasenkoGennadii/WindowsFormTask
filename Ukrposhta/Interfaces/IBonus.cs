using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ukrposhta.Interfaces
{
    interface IBonus
    {
        int Id { get; set; }
        string Grade { get; set; }
        string Percent { get; set; }
    }
}
