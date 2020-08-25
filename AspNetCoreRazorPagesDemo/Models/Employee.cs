using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreRazorPagesDemo.Models
{
    public class Employee
    {
        #region Properties
        //This is the in Memory Implementation of my company business class Domain
        // Comax Employee Implementation
        // These are the Properties needed.
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Email { get; set; }
        public decimal Salary { get; set; }
        public Department Department { get; set; }
        #endregion
        #region My Custom Constructor
        //This class must be initilized on creation in memory
        //by passing data to its constuctor
        //This is mandatory...!
        public Employee(int id, string firstName, string lastName, string email, Department department, decimal salary)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Department = department;
            Salary = salary;
        }
        #endregion

    }
}
