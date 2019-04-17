using System;
using System.Collections.Generic;

namespace AbstractAndInterfaceClassExample
{
    class Employee : Person, IPayroll
    {
        private List<Decimal> paychecks;

        private Decimal salary;

        public Decimal Salary
        {
            get { return salary; }
            set { salary = value; }
        }

        private Decimal average;

        public Employee(
            string firstName,
            string lastName,
            string streetAddress,
            string city,
            string state,
            string zipCode,
            string phone,
            Decimal salary
            ) : base(
                firstName,
                lastName,
                streetAddress,
                city,
                state,
                zipCode,
                phone
                )
        {
            Salary = salary;
            paychecks = new List<Decimal>();
        }

        public void AddCheck(Decimal check)
        {
            paychecks.Add(check);
        }

        public void CalculateAverage()
        {
            if (paychecks.Count == 0)
            {
                average = 0;
            }
            else
            {
                Decimal sum = 0;
                for (int i = 0; i < paychecks.Count; i++)
                {
                    sum += paychecks[i];
                }
                average = sum / paychecks.Count;
            }
        }

        public String GetEmployeeInfo()
        {
            CalculateAverage();
            String employee = "Employee ID: " + PID + "\n" +
                "Name: " + FirstName + " " + LastName + "\n" +
                "Address: " + StreetAddress + ", " + City + ", " + State + ", " + ZipCode + "\n" +
                "Phone: " + Phone + "\n" +
                "Check Average: " + average + "\n\n";
            return employee;
        }

    }
}
