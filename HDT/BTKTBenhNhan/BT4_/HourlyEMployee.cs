using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT4_
{
    internal class HourlyEMployee : Employee
    {
        private double _rate;
        private double _workingHour;

        public HourlyEMployee(int empCode, string firstName, string lastName, double rate, double workingHour) : base(empCode, firstName, lastName)
        {
            _rate = rate;
            _workingHour = workingHour;
        }

        public double Rate { get => _rate; set => _rate = value; }
        public double WorkingHour { get => _workingHour; set => _workingHour = value; }

        public override string toString()
        {
            return ($"Ma EmpCode: {this.EmpCode,-15}\nHo va Ten:{"",-5}{this.FirstName} {this.LastName}\n{"",-10}Rate: {this._rate}\n{"",-10}WorkingHours: {this._workingHour}\n{"",-5}Luong nhan duoc: {pay()}");
        }

        public override double pay()
        {
            return this._rate * this._workingHour;
        }



    }
}
