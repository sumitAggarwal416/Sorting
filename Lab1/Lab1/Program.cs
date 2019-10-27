/*
 * @author Sumit Aggarwal - 000793607
 * I certify that all work done in the assignment is my own work and that I have not copied it
 * from any other source. I also certify that I have not allowed anyone else to copy my code.
 * 
 * Reference -  https://www.geeksforgeeks.org/selection-sort/
 * 
 */
using System;
using System.IO;

namespace Lab1
{
    class Program
    {
        private static int option;

        static void Main(String[] args)
        {
            Employee[] employees = new Employee[100]; // array of the type Employee with the
            // maximum size of 100 employees
            employees = Read(employees); // calls the function Read() to read the employees' data

            bool isRunning = true; // loop control variable
            while (isRunning)
            {
                Console.WriteLine("----------------H O M E ----------------");
                Console.WriteLine("Sort by: \n" +
                    "1 - Employee name \n" +
                    "2 - Employee number \n" +
                    "3 - Pay rate\n" +
                    "4 - Employee hours\n" +
                    "5 - Gross Pay\n" +
                    "6 - Exit\n\n");

                option = int.Parse(Console.ReadLine()); // the option user chooses to sort the
                // data with

                switch (option)
                {
                    case 1:
                        sort(employees);
                        break;
                    case 2:
                        sort(employees);
                        break;
                    case 3:
                        sort(employees);
                        break;
                    case 4:
                        sort(employees);
                        break;
                    case 5:
                        sort(employees);
                        break;
                    case 6:
                        isRunning = false;
                        break;
                    default:
                        Console.WriteLine("Invalid option. Please re-enter!");
                        break;
                }
            }
        }

        /*
         * @param Employee[] array - array that will be passed in the function to get sorted
         * returns void
         */
        static void sort(Employee[] array)
        { // Reference - https://www.geeksforgeeks.org/selection-sort/
            int n = array.Length; // the length of the array that is passed as argument

            for (int i = 0; i < n-1 ; i++) // outer loop
            {
                int min_index = i; // the index of the value with the smallest which will be 
                // swapped to a "upper" position and the larger one in its place
                for (int j = i+1; j < n; j++) // inner loop
                {
                    switch (option)
                    {
                        case 1:
                            if (array[j].GetName().CompareTo(array[min_index].GetName()) < 0)
                            {
                                min_index = j;
                            }
                            break;
                        case 2:
                            if (array[j].GetNumber() < array[min_index].GetNumber())
                                min_index = j;
                            break;
                        case 3:
                            if (array[j].GetRate() > array[min_index].GetRate())
                                min_index = j;
                            break;
                        case 4:
                            if (array[j].GetHours() > array[min_index].GetHours())
                                min_index = j;
                            break;
                        case 5:
                            if (array[j].GetGross() > array[min_index].GetGross())
                                min_index = j;
                            break;
                    }
                    
                }
                // swapping the smaller values with the larger ones
                Employee temp = array[min_index];
                array[min_index] = array[i];
                array[i] = temp;
            }
            for (int i = 0; i < n ; i++)
            {
                Console.WriteLine(array[i] + " "); //prints the elements of the array
            }
            Console.WriteLine();
        }

        /*
         * @param Employee[] array - array that will be passed in the function to get sorted
         * returns an array of the type Employee
         */
        static Employee[] Read(Employee[] array)
        {
            string line = "";
            int lineNumber = 0;

            try
            {
                StreamReader fileInput = new StreamReader("employees.csv"); // opens the file to 
                // read
                lineNumber = 0;
                while (!fileInput.EndOfStream)
                {
                    line = fileInput.ReadLine();
                    string[] parts = line.Split(',');
                    array[lineNumber] = new Employee(parts[0], int.Parse(parts[1]),
                        decimal.Parse(parts[2]), double.Parse(parts[3]));
                    lineNumber++;
                }
                fileInput.Close(); // close the file i.e. stop reading the file
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine("Could not find file 'employees.csv'" + ex.Message);
           
            }
            catch (FormatException ex)
            {
                Console.WriteLine($"Error on line {lineNumber + 1} reading line{line}" +
                    $"- {ex.Message}");
                
            }
            // trim the size of the array to the number of values in the file
            Employee[] newEmployees = new Employee[lineNumber];
            Array.ConstrainedCopy(array, 0, newEmployees, 0, lineNumber);
            return newEmployees;
        }
    }
}
