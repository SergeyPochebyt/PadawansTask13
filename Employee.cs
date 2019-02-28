using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace PadawansTask13
{
    class Employee
    {
        private string _surname;
        private int _age;

        public Employee()
        {
        }

        public Employee(string surname, int age)
        {
            _surname = surname;
            _age = age;
        }

        private string PrintAge()
        {
            return _age.ToString();
        }

        public void ChangeSurname(string surname)
        {
            _surname = surname;
        }

        public string EmployeeInfo()
        {
            return $"Surname:{_surname},Age:{_age}";
        }

    }
}
