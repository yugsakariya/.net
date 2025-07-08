using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Prac_4
{
    public partial class _1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Add_Click(object sender, EventArgs e)
        {
            int no1 = Convert.ToInt32(text1.Text);
            int no2 = Convert.ToInt32(text2.Text);
            int result = no1 + no2;
            lbResult.Text = "Result: " + result.ToString();
        }
        protected void Sub_Click(object sender, EventArgs e)
        {
            int no1 = Convert.ToInt32(text1.Text);
            int no2 = Convert.ToInt32(text2.Text);
            int result = no1 - no2;
            lbResult.Text = "Result: " + result.ToString();
        }
        protected void Multi_Click(object sender, EventArgs e)
        {
            int no1 = Convert.ToInt32(text1.Text);
            int no2 = Convert.ToInt32(text2.Text);
            int result = no1 * no2;
            lbResult.Text = "Result: " + result.ToString();
        }
        protected void Div_Click(object sender, EventArgs e)
        {
            int no1 = Convert.ToInt32(text1.Text);
            int no2 = Convert.ToInt32(text2.Text);
            int result = 0;
            try { 
                result = no1 / no2;
                lbResult.Text = "Result: " + result.ToString();
            }
            catch (DivideByZeroException)
            {
                lbResult.Text = "Error: Division by zero is not allowed.";
            }
        }
    }
}