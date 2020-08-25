using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreRazorPagesDemo.Models
{
    public class MockEmployee : IEmployeeRepository
    {
        private readonly List<Employee> _listOfInMemoryEmployees;

        public MockEmployee()
        {
            _listOfInMemoryEmployees = new List<Employee>()
            {
                new Employee(id:1, firstName:"Dad", lastName:"Wonkulah",email:"dadwonkulahjr96@gmail.com",
                new Department(){DepartmentId=100, ListOfDepartment=ListOfDepartment.IT}, salary:10000),

                new Employee(id:2, firstName:"Arnold", lastName:"Smith",email:"arnold@yahoo.com",
                new Department(){DepartmentId=200, ListOfDepartment=ListOfDepartment.Finance}, salary:4500),

                new Employee(id:3, firstName:"Mohammed", lastName:"Jalloh",email:"mohammed@gmail.com",
                new Department(){DepartmentId=100, ListOfDepartment=ListOfDepartment.IT}, salary:8000),

                new Employee(id:4, firstName:"Dexter", lastName:"Maxwell",email:"dextermaxwell@gmail.com",
                new Department(){DepartmentId=100, ListOfDepartment=ListOfDepartment.IT}, salary:7000),

                new Employee(id:5, firstName:"Romeo", lastName:"David",email:"romeo@outlook.com",
                new Department(){DepartmentId=300, ListOfDepartment=ListOfDepartment.Network_Engineer}, salary:3000),

                new Employee(id:6, firstName:"Alicia", lastName:"Benson",email:"alicia@gmail.com",
                new Department(){DepartmentId=200, ListOfDepartment=ListOfDepartment.Finance}, salary:2000),

                new Employee(id:7, firstName:"Precious", lastName:"Andrew",email:"precious@yahoo.com",
                new Department(){DepartmentId=300, ListOfDepartment=ListOfDepartment.HR}, salary:3300),

                new Employee(id:8, firstName:"Beatrice", lastName:"Collins",email:"beatrice@outlook.com",
                new Department(){DepartmentId=300, ListOfDepartment=ListOfDepartment.Network_Engineer}, salary:5000)
            };
        }
        public Employee GetEmployeeById(int id)
        {
           Employee employee = _listOfInMemoryEmployees.FirstOrDefault(emp => emp.Id == id);
            if(employee == null)
            {
                throw new Exception($"The employee with Id {id.ToString()} cannot be found.");
            }
            else
            {
                return employee;
            }
        }

        public IEnumerable<Employee> GetEmployees()
        {
            return _listOfInMemoryEmployees;
        }

        
    }
}
