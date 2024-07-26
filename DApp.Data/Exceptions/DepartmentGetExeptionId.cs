using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DApp.Data.Exceptions
{
    public class DepartmentGetExeptionId : Exception
    {
        public DepartmentGetExeptionId(string message) : base(message)
        {

        }
    }
}
