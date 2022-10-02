using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace appointment_schedular
{
    public partial class Logout : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButtonLogOut_Click(object sender, EventArgs e)
        {
            
                Session.Abandon();
                Session.Remove("name");
                Response.Redirect("~/Login.aspx");
            
        }
    }
}