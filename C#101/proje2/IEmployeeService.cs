using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace proje2
{
    public interface IEmployeeService
    {
        List<Employee> GetList();
        Employee GetById(int id);
    }
}