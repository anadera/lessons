using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Challenge5
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                endDateCalendar.SelectedDate = DateTime.Now;
                startDateCalendar.SelectedDate = DateTime.Now.Date.AddDays(14);
                projectedEndCalendar.SelectedDate = DateTime.Now.Date.AddDays(21);
            }
        }

        protected void assignButton_Click(object sender, EventArgs e)
        {

        }

        protected void endDateCalendar_SelectionChanged(object sender, EventArgs e)
        {

        }
    }
}