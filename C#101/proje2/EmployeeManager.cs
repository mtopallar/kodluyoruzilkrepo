using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace proje2
{
    public class EmployeeManager : IEmployeeService
    {
        List<Employee> EmployeeList;
        public EmployeeManager()
        {
            EmployeeList = new()
            {
                new Employee{Id=1,Name="Vernice",Lastname="Reinger"},
                new Employee{Id=2,Name="Zachery",Lastname="Oberbrunner"},
                new Employee{Id=3,Name="Conrad",Lastname="Schultz"},
                new Employee{Id=4,Name="Breanna",Lastname="Lemke"},
                new Employee{Id=5,Name="Electa",Lastname="Nathen"},
                new Employee{Id=6,Name="Noah",Lastname="Abernathy"},
                new Employee{Id=7,Name="Maiya",Lastname="Franey"}
            };
        }

        public Employee GetById(int id)
        {
            return EmployeeList.FirstOrDefault(x => x.Id == id);
        }

        public List<Employee> GetList()
        {
            return EmployeeList;
        }
    }
}