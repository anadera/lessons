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
            Assignment a = new Assignment
                (spyCodeTextBox.Text,
                newAssignmentTextBox.Text,
                endDateCalendar.SelectedDate,
                startDateCalendar.SelectedDate,
                projectedEndCalendar.SelectedDate);
            string result;
            if (a.CheckValidDate() == false)
                result = "Error. Must allow at least two weeks between previous assignment and new assignment.";
            else
                result = string.Format("Assignment of {0} to assignment {1} is authorized. Budget total: {2:C}",
                    a.SpyName, a.Name, a.CalculateBudget());
            resultLabel.Text = result;
        }

        protected void endDateCalendar_SelectionChanged(object sender, EventArgs e)
        {

        }
    }
}