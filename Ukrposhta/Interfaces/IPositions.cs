using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ukrposhta.Interfaces
{
    interface IPositions
    {
         int Id { get; set; }
         string Position { get; set; }
         decimal Salary { get; set; }
         string DepartmentName { get; set; }
    }
}
