/*
 * @author Sumit Aggarwal - 000793607
 * I certify that all work done in the assignment is my own work and that I have not copied it
 * from any other source. I also certify that I have not allowed anyone else to copy my code.
 * 
 */
using System;

namespace Lab1
{
    class Employee
    {
        private string name;
        private int number;
        private decimal rate;
        private double hours;
        private decimal gross;

        public Employee(string name, int number, decimal rate, double hours)
        {
            this.name = name; // sets the current value of name at this instance when the 
            //constructor is called
            this.number = number; // sets the current value of number at this instance when the
            // constructor is called
            this.rate = rate; // sets the current value of rate at this instance when the 
            // constructor is called
            this.hours = hours; // sets the current value of hours at this instance when the 
            // cunstroctor is called
        }

        public decimal GetGross()
        { // this method is used to obtain the value of the gross pay of the employee
            //if he/she is working for more than 40 hours, they will be getting overtime pay
            if (hours <= 40 && hours > 0)
            {
                gross = rate * (decimal)hours; // variable hours (double) is type-casted to 
                // decimal because we cannot multiply a double and a decimal value
            }
            else
                gross = rate * (decimal)hours;
                
            return gross;
        }

        public double GetHours()
        { // this method is used to obtain the number of hours an employee has worked
            return hours;
        }

        public string GetName()
        { //  // this method is used to obtain the name of an employee
            return name;
        }

        public int GetNumber()
        {  // this method is used to obtain the employee number of an employee
            return number;
        }

        public decimal GetRate()
        {  // this method is used to obtain the hourly wage of an employee
            return rate;
        }

        public override string ToString()
        {
            return "["+name+","+number+","+rate+","+hours+"]";
        }

        public void SetHours(double hours)
        { // used to set the value of hours at the current instance
            this.hours = hours;
        }

        public void SetName(string name)
        { // used to set name of an employee at the current instance
            this.name = name;
        }

        public void SetNumber(int number)
        { // used to set the number of an employee at the current instance
            this.number = number;
        }

        public void SetRate(decimal rate)
        { // used to set the hourly wage of an employee at the current instance
            this.rate = rate;
        }

    }

}
    

