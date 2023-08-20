using Employer;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Xml.Linq;

namespace Employer
{
    public class Employees
    {
        public int id;
        public string name;
        public string designation;
        public int salary;
        public DateTime dateOfJoining;

        public Employees(int id, string name, string designation, int salary, DateTime dateOfJoining)
        {
            Id = id;
            Name = name;
            Designation = designation;
            Salary = salary;
            DateOfJoining = dateOfJoining;
        }

        public int Id
        {
            get { return id; }
            set
            {
                if (value < 1 || value > 1000)
                    throw new Exception("Please enter id with a value between 1 and 1000");
                id = value;
            }
        }

        public string Name
        {
            get { return name; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new Exception("Please enter a valid Employee name");
                name = value;
            }
        }

        public string Designation
        {
            get { return designation; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new Exception("Please enter a valid designation");
                designation = value;
            }
        }

        public int Salary
        {
            get { return salary; }
            set
            {
                if (value < 20000 || value > 300000)
                    throw new Exception("Please enter a valid salary between 20000 and 300000");
                salary = value;
            }
        }

        public DateTime DateOfJoining
        {
            get { return dateOfJoining; }
            set
            {
                if (value > DateTime.Now)
                    throw new Exception("Date of Joining cannot be a future date");
                dateOfJoining = value;
            }
        }
    }



}


