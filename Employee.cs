using System;
using System.Collections.Generic;
using System.Text;

namespace Session2Assiments
{
    public class Employee
    {
        #region Q1 --------------------
        public string Name { get; set; }
        public int Age { get; set; }
        //public double Salary { get; set; }
        #endregion

        #region Q2 --------------------
        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}, Salary: {Salary}");
        }

        public double CalculateAnnualSalary()
        {
            return Salary * 12;
        }
        #endregion

        #region Q3 --------------------
        private double salary;

        public double Salary
        {
            set {
                if (value >= 0)
                {
                    salary = value;
                }
            }
            get { return salary; }
        }
        #endregion
    }
}
