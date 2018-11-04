using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Challenge4
{
    public class Pizza
    {
        public int Size { get; set; }
        public bool DeepCrust { get; set; }
        public Dictionary<eToping, double> Toping { get; set; }
        //public double Cost { get;  }

        public Pizza ( int size, bool crust)
        {
            Size = size;
            DeepCrust = crust;
            Toping = new Dictionary<eToping, double>();           
        }

        private bool GetSale()
        {
            bool result;
            if (this.Toping.ContainsKey(eToping.Pepperoni) && this.Toping.ContainsKey(eToping.GreenPeppers) && this.Toping.ContainsKey(eToping.Anchovies))
                result = true;
            else if (this.Toping.ContainsKey(eToping.Pepperoni) && this.Toping.ContainsKey(eToping.RedPeppers) && this.Toping.ContainsKey(eToping.Onions))
                result = true;
            else
                result = false;
            return result;
        }

        public string TopingTotext()
        {
            string result = "";
            foreach (KeyValuePair <eToping,double> entry in this.Toping)
                result = result + entry.Key.ToString();
            return result;
        }
        
        public double GetCost()
        {
            double result = 0;
            result += this.Size;
            if (this.DeepCrust) 
                result += 2;
            if (this.Toping.Count != 0)
                result += this.Toping.Sum(v => v.Value);
            if (GetSale())
                result -= 2;
            return result;
        }       

    }

    public enum eToping
    {
        Pepperoni,
        Onions,
        GreenPeppers,
        RedPeppers,
        Anchovies
    }   
}