using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqSamples
{
    class Program
    {
        static void Main(string[] args)
        {
            var employees = GetEmployees();

            //Selecciona los empleados de IT, mayores de 25 años.

            var employeesIT = employees.Where(x => x.Deparment == "IT" && x.Age>25).ToList();


            //Agrupa todos los empleados por departamento
            var employeesDEP = employees.GroupBy(x => x.Deparment).ToList();

            foreach (var emp in employeesDEP) {

                Console.WriteLine(emp.Key);

            }

            Console.ReadKey();
            //Ordena a todos los usuarios mediante su salario, de menor a mayor
            

            //Crea un listado partiendo de los empleados con la clase NameAndAge
            

            //Obtiene todas las ausencias en una lista plana
            

            //Comprueba si existe algún empleado que contenga la letra F o la letra A (Separadas)
            

            //Obtiene el primer empleado de IT del listado y el último
            

            //Obten todos los empleados que ganen más de 20000 y sean menos de 30

            
            Console.ReadKey();
        }
        
        static List<Employee> GetEmployees()
        {
            return new List<Employee>()
            {
                new Employee() { Name = "Antonio" , Age = 20, Deparment = "Sales" , Salary = 20000,
                    Absences = new List<DateTime>() { DateTime.Now } },
                new Employee() { Name = "Carlos" , Age = 35, Deparment = "IT" , Salary = 30000,
                    Absences = new List<DateTime>() { DateTime.Now.AddDays(-1) } },                    
                new Employee() { Name = "Manuel" , Age = 35, Deparment = "IT" , Salary = 30000,
                    Absences = new List<DateTime>() { DateTime.Now.AddDays(-7) } },
                new Employee() { Name = "Fran" , Age = 25, Deparment = "HR" , Salary = 25000},
                new Employee() { Name = "Federico" , Age = 22, Deparment = "IT" , Salary = 22000}
            };
        }
    }

    class NameAndAge
    {
        public string Name { get; set; }

        public int Age { get; set; }

        public List<DateTime> Absenses { get; set; }
    }

    class Employee
    {
        public int Age { get; set; }

        public string Name { get; set; }

        public string Deparment { get; set; }

        public double Salary { get; set; }

        public List<DateTime> Absences { get; set; } = new List<DateTime>();
    }
}
