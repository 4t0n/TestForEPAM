using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BugTrackingSystemWithSQlite
{
    class User: Table
    {
        public User() : base("UserList", "User")
        {

        }
    }
}
