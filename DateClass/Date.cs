using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateClass
{
    internal class Date
    {
        // fields
        private int year;
        private int month;
        private int day;

        // constructor:
        public Date(int year, int month, int day)
        {
            this.year = year;
            this.month = month;
            this.day = day;
        }


        // methods ("action members"): 
        public override string ToString()
        {
            return $"The date is: {day}-{GetMonthName(month)}-{year}, (day-month-year).";
        }

        //overloaded methods: 
        public void Add(int days)
        {
            day += days;
            Normalize();
        }

        public void Add(int months, int days)
        {
            day += days;
            month += months;
            Normalize();
        }

        public void Add(Date other)
        {
            year += other.year;
            month += other.month;
            day += other.day;
            Normalize();
        }

        private void Normalize()
        {
            if (day > 30)
            {
                day = day - 30;
                month++;
            }
            if (month > 12)
            {
                month = month - 12;
                year++;
            }
        }

        // method to assign month names
        // switch statements?? or list? -> ARRAY

        public static string GetMonthName(int month)
        {
            // 1st declare an array holding all the month names 
        string[] monthNames = new string[] { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };

            if (month <= 12 && month >= 1)
            {
                return monthNames[month - 1];
            }
            else
            {
                return "Invalid date.";
            }
        }
        







    }
}
