using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5Exeon_JArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of employees: ");
            int numEmployees = int.Parse(Console.ReadLine());

            Console.Write("Enter the number of working days for each employee: ");
            int numWorkingDays = int.Parse(Console.ReadLine());

            int[][] salaries = new int[numEmployees][];

            for (int i = 0; i < numEmployees; i++)
            {
                salaries[i] = new int[numWorkingDays];

                Console.WriteLine($"Employee {i + 1}:");

                for (int j = 0; j < numWorkingDays; j++)
                {
                    Console.Write($"Enter salary for day {j + 1} of employee {i + 1}: ");
                    salaries[i][j] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("\nDisplaying the weekly salary:");

            Console.Write("Day\t");
            for (int i = 0; i < numEmployees; i++)
            {
                Console.Write($"Employee {i + 1}\t");
            }
            Console.WriteLine("Total Salary");

            for (int j = 0; j < numWorkingDays; j++)
            {
                int totalSalary = 0;
                Console.Write($"Day{j + 1}\t");
                for (int i = 0; i < numEmployees; i++)
                {
                    Console.Write($"{salaries[i][j]}\t\t");
                    totalSalary += salaries[i][j];
                }
                Console.WriteLine(totalSalary);
            }
            Console.ReadKey();
        }
    }
}
