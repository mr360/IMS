using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IMS.User;

namespace IMS.Instance
{
    public class ReportInstance
    {
        public ReportInstance(Staff s)
        {
            if (s.Role != JobRole.Management)
            {
                throw new System.ArgumentException("Invalid User! Cannot create instance!");
            }
        }

        
    }
}
