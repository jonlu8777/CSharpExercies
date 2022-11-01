namespace ExOne
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hello, How many number of employees do you want to register:");
            int numberOfEmployees = int.Parse(Console.ReadLine());
            Employee[] employeeRegister = new Employee[numberOfEmployees];
            for (int i = 0; i < numberOfEmployees; i++)
            {
                Console.WriteLine("Enter name:");
                string name = Console.ReadLine();
                Console.WriteLine("Enter wage:");
                double wage = double.Parse(Console.ReadLine());

                employeeRegister[i] = new Employee(i, name, wage);
                Console.WriteLine($"\nEmployee number {i+1} saved!");

            }
            Console.WriteLine("Registration complete!");

            Console.WriteLine("These employees are saved:");
            foreach (Employee employee in employeeRegister) 
            {
                Console.WriteLine();
                Console.WriteLine("ID:" + employee.employeeID);
                Console.WriteLine(employee.employeeName);
                Console.WriteLine(employee.employeeWage);
             
             }

            Console.WriteLine("Pick what ID number to view from above:");
            int id = int.Parse(Console.ReadLine());

            foreach(Employee employee in employeeRegister)
            {
                if(employee.employeeID == id)
                {
                    Console.WriteLine("ID:" + employee.employeeID);
                    Console.WriteLine(employee.employeeName);
                    Console.WriteLine(employee.employeeWage);
                }
            
            
            }
            

            
        }
    }
}