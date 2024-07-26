using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DApp.Data.Entities
{
    public class Department
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public decimal Budget { get; set; }

        public DateTime StartDate { get; set; }
        public int Administrator { get; set; }
    }
}
