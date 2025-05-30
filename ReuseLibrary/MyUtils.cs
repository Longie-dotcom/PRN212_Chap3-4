using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOP;

namespace ReuseLibrary
{
    public static class MyUtils
    {
        public static int countAge(Employee employee)
        {
            return DateTime.Now.Year - employee.DOB.Year;
        }
    }
}
