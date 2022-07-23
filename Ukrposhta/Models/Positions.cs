using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ukrposhta.Interfaces;

namespace Ukrposhta
{
    class Positions : IPositions
    {
        public int Id { get; set; }
        public string Position { get; set; }
        public decimal Salary { get; set; }
        public string DepartmentName { get; set; }
    }
}
