using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ONTAPCUOIKI3
{
    public class SalaryEmployee : Employee, IPay
    {
        private long monthlySalary;
        private float rate = 1.0f;

        public int OffDays{
            get;
            set;
        }

        public long MonthlySalary{
            get {
                return this.monthlySalary;
            }

            set{
                this.monthlySalary = value;
            }
        }

        public float Rate{
            get {
                return this.rate;
            }

            set{
                this.rate = value;
            }
        }

        public SalaryEmployee(string id, Person contact, DateTime startDate, long monthlySalary = 0) : base(id, contact, startDate)
        {
            this.monthlySalary = monthlySalary;
        }
		
        public long GetSalary(int offDays)
        {
            return 1;
        }
		
    }
}