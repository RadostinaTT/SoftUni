using System;
using System.Collections.Generic;
using System.Text;

namespace DateModifier
{
    public class DateModifier
    {
        //private int diffrences;

        //public int Difference
        //{
        //    get { return this.diffrences; }
        //    set { this.diffrences = value; }
        //}

        public double DiffrenceInDaysBetweenTwoDates(string a, string b)
        {
            DateTime firstDate = DateTime.Parse(a); 
            DateTime secondDate = DateTime.Parse(b);
            var diffrence = (firstDate - secondDate).TotalDays;
            

            return diffrence;
        }
    }
}
