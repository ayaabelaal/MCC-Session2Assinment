using System;
using System.Collections.Generic;
using System.Text;

namespace Session2Assiments
{
    public class Manager:Employee
    {
        public double bonus { get; set; }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Bonus: {bonus}");
        }
    }
}
