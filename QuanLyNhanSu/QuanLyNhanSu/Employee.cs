using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhanSu
{
    public class Employee
    {
        private string name;
        private DateTime birthdate;
        private string address;
        private string email;
        private string gender;
        private int phoneNumber;
        private string education;
        private string expertise;
        private int id;
        private string position;
        private double salary;
        private string department;
        private string status;
        private double benefit;

        public double Benefit
        {
            get { return benefit; }
            set { benefit = value; }
        }


        public string Status
        {
            get { return status; }
            set { status = value; }
        }

        public string Department
        {
            get { return department; }
            set { department = value; }
        }

        public double Salary
        {
            get { return salary; }
            set { salary = value; }
        }

        public string Position
        {
            get { return position; }
            set { position = value; }
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Education
        {
            get { return education; }
            set { education = value; }
        }

        public string Expertise
        {
          get { return expertise; }
          set { expertise = value; }
        }

        public int PhoneNumber
        {
            get { return phoneNumber; }
            set { phoneNumber = value; }
        }

        public string Gender
        {
            get { return gender; }
            set { gender = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public string Address
        {
            get { return address; }
            set { address = value; }
        }

        public DateTime Birthdate
        {
          get { return birthdate; }
          set { birthdate = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public Employee(string name, DateTime birthdate, string address, string email, string gender, int phoneNumber, string education, string expertise, int id, string position, double salary, string department, string status, double benefit)
        {
            this.name = name;
            this.birthdate = birthdate;
            this.address = address;
            this.email = email;
            this.gender = gender;
            this.phoneNumber = phoneNumber;
            this.education = education;
            this.expertise = expertise;
            this.id = id;
            this.position = position;
            this.salary = salary;
            this.department = department;
            this.status = status;
            this.benefit = benefit;
        }
    }
}
