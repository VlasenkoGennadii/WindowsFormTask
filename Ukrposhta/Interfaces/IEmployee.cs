using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ukrposhta.Interfaces
{
    interface IEmployee
    {
        int Id { get; set; }
         string FirstName { get; set; }
         string LastName { get; set; }
         string MiddleName { get; set; }
         string Phone { get; set; }
         string Address { get; set; }
         int Position { get; set; }
         string Bonus { get; set; }
    }
}
