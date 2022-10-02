using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace appointment_schedular
{

    public partial class viewAppointment : System.Web.UI.Page
    {
       
        protected void Page_Load(object sender, EventArgs e)
        {
            con = new Functions();
            ShowAppointment();
        }
        Functions con;
        protected void ShowAppointment()
        {
           
            
            string query = "select * from BookAppo where Name = '{0}'";
            query = String.Format(query, Session["name"]);
            GridViewAppo.DataSource = con.GetData(query);
            GridViewAppo.DataBind();


        }

        protected void GridViewAppo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void ButtonNewAppo_Click(object sender, EventArgs e)
        {
            Response.Redirect("BookAppointment.aspx");
        }

        protected void BLogout_Click(object sender, EventArgs e)
        {
            Session.Abandon();
            Session.Remove("name");
            Response.Redirect("~/Login.aspx");
        }
    }
}