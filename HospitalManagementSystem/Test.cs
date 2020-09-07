using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementSystem
{
    class Test
    {
        public static bool IsEmpty(params string[] args)
        {
            if (args.Length == 0) return true;
            return args.Any(p => string.IsNullOrEmpty(p));
        }
    }
}
