using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ukrposhta.Interfaces;

namespace Ukrposhta
{
    class Departments : IDepartments
    {
        public int Id { get; set; }
        public string DepartmentName { get; set; }
    }
}
