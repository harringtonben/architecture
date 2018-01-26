using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace architecture.Departments
{
    interface ISecurity
    {
        bool SecurityClearance { get; set; }

        void IsCleared();

    }
}
