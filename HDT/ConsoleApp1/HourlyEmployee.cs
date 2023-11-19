using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ONTAPCUOIKI3
{
    public class HourlyEmployee : Employee,IPay
    {
        private long hourlySalary;
        private int workingHourly;

        public int OffDays{
        get;
        set;
       }
        
        public long HourlySalary{
            get{
                return this.hourlySalary;
            }

            set{
                this.hourlySalary = value;
            }
        }

        public int WorkingHourly{
            get{
                return this.workingHourly;
            }

            set{
                this.workingHourly = value;
            }
        }

        public HourlyEmployee(string id, Person contact, DateTime startDate, long hourlySalary = 0) : base(id, contact, startDate)
        {
            this.hourlySalary = hourlySalary;
        }

        public long GetSalary(int offDays)
        {
            return 1;
        }
        
    }
}