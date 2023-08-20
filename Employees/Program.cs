using System;
namespace Employer
{
    class Program
    {
        static void Main(string[] args)
        {
            bool shouldContinue = true;

            while (shouldContinue)
            {
                try
                {
                    Console.Write("Enter Id (or type 'exit' to quit): ");
                    string idInput = Console.ReadLine();

                    if (idInput.ToLower() == "exit" || idInput.ToLower() == "quit")
                    {
                        shouldContinue = false;
                        break;
                    }

                    int id = int.Parse(idInput);

                    Console.Write("Enter Name: ");
                    string name = Console.ReadLine();

                    Console.Write("Enter Designation: ");
                    string designation = Console.ReadLine();

                    Console.Write("Enter Salary: ");
                    int salary = int.Parse(Console.ReadLine());

                    Console.Write("Enter Date of Joining (yyyy-MM-dd) or type 'exit' to quit: ");
                    string dateInput = Console.ReadLine();

                    if (dateInput.ToLower() == "exit" || dateInput.ToLower() == "quit")
                    {
                        shouldContinue = false;
                        break;
                    }

                    DateTime dateOfJoining = Utility.ConvertToDate(dateInput);

                    Employees employee = new Employees(id, name, designation, salary, dateOfJoining);
                    Console.WriteLine("Employee details added successfully!");
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input format.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            }
        }
    }
}
