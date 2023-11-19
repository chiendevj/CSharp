using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ONTAPCUOIKI3
{
    public interface IPay
    {
        long GetSalary(int offDays);
        int OffDays{
            get;
            set;
        }
    }
}