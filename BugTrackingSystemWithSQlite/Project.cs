using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BugTrackingSystemWithSQlite
{
    class Project : Table
    {
        public Project():base("ProjectList","Project")
        {
        
        }        
    }
}
