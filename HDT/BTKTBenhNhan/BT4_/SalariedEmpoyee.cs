using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT4_
{
    internal class SalariedEmpoyee : Employee
    {
        private double _comRate;
        private double _grossSale;
        private double _basic;

        public SalariedEmpoyee(int empCode, string firstName, string lastName,double comRate, double grossSale, double basic) : base(empCode, firstName, lastName)
        {
            _comRate = comRate;
            _grossSale = grossSale;
            _basic = basic;
        }

        public double ComRate { get => _comRate; set => _comRate = value; }
        public double GrossSale { get => _grossSale; set => _grossSale = value; }
        public double Basic { get => _basic; set => _basic = value; }

        public override string toString()
        {
            return ($"Ma EmpCode: {this.EmpCode,-15}\nHo va Ten:{"",-5}{this.FirstName} {this.LastName}\n{"",-10}CommissionRate: {this._comRate}\n{"",-10}GrossSale: {this._grossSale}\n{"",-5}Luong nhan duoc:{pay()}");
        }

        public override double pay()
        {
            return this._basic + (this._comRate * this._grossSale);
        }
    }
}
