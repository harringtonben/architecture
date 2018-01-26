using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace architecture.Departments
{
    interface IOnCall
    {
        bool OnCall { get; set; }

        string IsOnCall();
    }
}
