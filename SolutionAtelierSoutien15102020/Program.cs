using System;

namespace SolutionAtelierSoutien15102020
{
    class Program
    {
        static void Main(string[] args)
        {
            // Créer un employé
            Employee employee1 = new Employee();
            Employee employee2 = new Employee();
            Employee employee3 = new Employee();
            employee1.SetName("Georges");
            employee2.SetName("Georges");
            employee3.SetName("Georges");
            // Créer une entreprise
            Company company = new Company();
            // Embaucher un employé
            company.HireEmployee(employee1);
            company.HireEmployee(employee2);
            company.HireEmployee(employee3);

            Employee[] currentEmployees = company.GetEmployees();
            Console.WriteLine(currentEmployees[0] + ":" + currentEmployees[0].GetSalary());
            Console.WriteLine(currentEmployees[1] + ":" + currentEmployees[1].GetSalary());
            Console.WriteLine(currentEmployees[2] + ":" + currentEmployees[2].GetSalary());

            company.ModifySalaryByEmployeeName(22000, "Georges");

            Console.WriteLine(currentEmployees[0] + ":" + currentEmployees[0].GetSalary());
            Console.WriteLine(currentEmployees[1] + ":" + currentEmployees[1].GetSalary());
            Console.WriteLine(currentEmployees[2] + ":" + currentEmployees[2].GetSalary());
        }
    }

    class Employee
    {
        private String _name;
        private Single _salary;

        public String GetName()
        {
            return _name;
        }

        public void SetName(String name)
        {
            _name = name;
        }

        public Single GetSalary()
        {
            return _salary;
        }

        public void SetSalary(Single salary)
        {
            _salary = salary;
        }

        public override string ToString()
        {
            return _name;
        }
    }

    class Company
    {
        private String _name;
        private Employee[] _employees = new Employee[124];
        private Int32 _employeesCount = 0;

        public String GetName()
        {
            return _name;
        }

        public Employee[] GetEmployees()
        {
            return _employees;
        }

        public void HireEmployee(Employee newEmployee)
        {
            _employees[_employeesCount] = newEmployee;
            _employeesCount = _employeesCount + 1;
        }

        public void FireEmployeeByName(String employeeName)
        {
            Int32 employeesFired = 0;
            for (int i=0; i < _employeesCount; i++)
            {
                Employee employee = _employees[i];
                if (employeeName == employee.GetName())
                {
                    _employees[i] = null;
                    employeesFired = employeesFired + 1;
                }
            }
            _employeesCount = _employeesCount - employeesFired;
        }

        public void ModifySalaryByEmployeeName(Single salary, String employeeName)
        {
            for (int i=0; i < _employeesCount; i++)
            {
                Employee currentEmployee = _employees[i];
                if (employeeName == currentEmployee.GetName())
                {
                    currentEmployee.SetSalary(salary);
                }
            }
        }
    }
}
