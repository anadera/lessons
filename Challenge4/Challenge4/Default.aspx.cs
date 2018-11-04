using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Challenge4
{
    public partial class Default : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void resultButton_Click(object sender, EventArgs e)
        {
            Pizza p = new Pizza(int.Parse(SizeRadioButtonList.SelectedValue), bool.Parse(CrustRadioButtonList.SelectedValue));
         
            List<string> selected = ToppingCheckBoxList.Items.Cast<ListItem>()
                .Where(li => li.Selected)
                .Select(li => li.Value)
                .ToList();
            foreach (var s in selected)
            {
                if (s == "Pepperoni")
                    p.Toping.Add(eToping.Pepperoni, 1.5);
                else if (s == "Onions")
                    p.Toping.Add(eToping.Onions, 0.75);
                else if (s == "GreenPeppers")
                    p.Toping.Add(eToping.GreenPeppers, 0.5);
                else if (s == "RedPeppers")
                    p.Toping.Add(eToping.RedPeppers, 0.75);
                else if (s == "Anchovies")
                    p.Toping.Add(eToping.Anchovies, 2);
            }
            double cost = p.GetCost();            
            resultLabel.Text = "Total: $" + cost.ToString();
        }


        protected void SizeRadioButtonList_SelectedIndexChanged(object sender, EventArgs e)
        {
        
        }

        protected void CrustRadioButtonList_SelectedIndexChanged(object sender, EventArgs e)
        {
       
        }

        protected void ToppingCheckBoxList_SelectedIndexChanged(object sender, EventArgs e)
        {
        
        }
    }
}
