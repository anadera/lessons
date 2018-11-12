using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Challenge5
{
    public class Assignment
    {
        public string SpyName { get; set; }
        public string Name { get; set; }        
        public DateTime EndDatePA { get; set; }
        public DateTime StartDateNA { get; set; }
        public DateTime ProjectedEndDateNA { get; set; }
        //public int Budget;

        public Assignment(string spyName, string name, DateTime startDateNA, DateTime endDatePA, DateTime projectedEndDateNA)
        {
            this.SpyName = spyName;
            this.Name = name;
            this.StartDateNA = startDateNA;
            this.EndDatePA = endDatePA;
            this.ProjectedEndDateNA = projectedEndDateNA;
        }

        public bool CheckValidDate()
        {
            TimeSpan t = this.EndDatePA.Subtract(this.StartDateNA);            
            int result = TimeSpan.Compare(t, TimeSpan.FromDays(14));
            if (result >= 0)
                return true;
            else
                return false;
        }

        public int CalculateBudget()
        {
            int result;
            TimeSpan t = this.ProjectedEndDateNA.Subtract(this.StartDateNA);
            result = t.Days * 500;
            if (t.Days > 21)
                result += 1000;
            return result;
        }

            
    }
}