using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Challenge4
{
    class Pizza
    {
        int Size { get; set; }
        eCrust Crust { get; set; }
        Dictionary<eToping, double> Toping { get; set; }

        private bool GetSale(Pizza p)
        {
            bool result;
            if (p.Toping.ContainsKey(eToping.Pepperoni) && p.Toping.ContainsKey(eToping.GreenPeppers) && p.Toping.ContainsKey(eToping.Anchovies))
                result = true;
            else if (p.Toping.ContainsKey(eToping.Pepperoni) && p.Toping.ContainsKey(eToping.RedPeppers) && p.Toping.ContainsKey(eToping.Onions))
                result = true;
            else
                result = false;
            return result;
        }

        private double myGetCost(Pizza p)
        {
            double result = 0;
            result += (double)p.Size;
            if (p.Crust == eCrust.Deep)
                result += 2.0;
            if (p.Toping.Count != 0)
                result += p.Toping.Sum(v => v.Value);
            if (GetSale(p))
                result -= 2;
            return result;
        }

        public double GetCost(Pizza p)
        {
            return myGetCost(p);
        }       

    }

    enum eToping
    {
        Pepperoni,
        Onions,
        GreenPeppers,
        RedPeppers,
        Anchovies
    }

    enum eCrust
    {
        Thin,
        Deep
    }
}