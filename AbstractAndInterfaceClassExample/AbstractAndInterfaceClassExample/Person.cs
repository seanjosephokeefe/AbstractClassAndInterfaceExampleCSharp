using System;

namespace AbstractAndInterfaceClassExample
{
    abstract class Person
    {

        private int currentId = 1;

        private int pid;

        public int PID
        {
            get { return pid; }
        }

        private String firstName;

        public String FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        private String lastName;

        public String LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        private String streetAddress;

        public String StreetAddress
        {
            get { return streetAddress; }
            set { streetAddress = value; }
        }

        private String city;

        public String City
        {
            get { return city; }
            set { city = value; }
        }

        private String state;

        public String State
        {
            get { return state; }
            set { state = value; }
        }

        private String zipCode;

        public String ZipCode
        {
            get { return zipCode; }
            set { zipCode = value; }
        }

        private String phone;

        public String Phone
        {
            get { return phone; }
            set { phone = value; }
        }

        protected Person( 
            string firstName, 
            string lastName, 
            string streetAddress, 
            string city, 
            string state, 
            string zipCode, 
            string phone
            )
        {
            pid=currentId++;
            FirstName = firstName;
            LastName = lastName;
            StreetAddress = streetAddress;
            City = city;
            State = state;
            ZipCode = zipCode;
            Phone = phone;
        }

    }
}
