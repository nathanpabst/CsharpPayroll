using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpPayroll
{
    class Manager : Staff
    {
        private const float managerHourlyRate = 50;

        public int Allowance { get; private set; }

        public Manager(string name) : base(name, managerHourlyRate) { }

        public override void CalculatePayment()
        {
            base.CalculatePayment();
            Allowance = 0;

            if (HoursWorked > 160)
            {
                Allowance = 1000;
                TotalPay = BasicPay + Allowance;
            }
        }

        public override string ToString()
        {
            return "\nNameOfStaff = " + NameOfStaff + "\nManagerHourlyRate = " + managerHourlyRate + "\nHoursWorked = " + HoursWorked + "\nBasicPay = " + BasicPay + "\nAllowance = " + Allowance + "\nTotalPay = " + TotalPay;
        }
    }
}
