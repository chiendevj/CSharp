using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOP_DE3
{
    public abstract class Employee
    {
        // fields
        private string _employeeID;
        private Person _person = new Person();
        private static int _countOfEmployee = 0;
        private DateTime _startDate;

        // properties
        public string EmployeeID { get => _employeeID; set => _employeeID = value; }
        public Person Person { get => _person; set => _person = value; }
        public static int CountOfEmployee { get => _countOfEmployee; set => _countOfEmployee = value; }
        public DateTime StartDate { get => _startDate; set => _startDate = value; }

        // constructor
        public Employee()
        {
            this._employeeID = "";
            this._startDate = DateTime.Now;
            this._person = new Person();
            _countOfEmployee++;
        }

        public Employee(string empoyeeID, Person ps, DateTime startDate)
        {
            this._employeeID = empoyeeID;
            _person = ps;
            this._startDate = startDate;
            _countOfEmployee++;
        }

        public Employee(string empoyeeID, Person ps)
        {
            this._employeeID = empoyeeID;
            this._person = ps;
            _countOfEmployee++;
        }
        // method
        public override string ToString()
        {
            return ($"{this._employeeID}#{this._person}#{this._startDate.ToString("dd/MM/yyyy")}");
        }
    }
    
}