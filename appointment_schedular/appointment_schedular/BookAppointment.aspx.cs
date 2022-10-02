using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace appointment_schedular
{
    public partial class BookAppointment : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["name"] == null)
            {
                Response.Redirect("Login.aspx");
            }
            TextBoxName.Value = Session["name"] as String;

            ValidationSettings.UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;
            

        }

        protected void BookApp_Click(object sender, EventArgs e)
        {

            if (IsPostBack)
            {

                SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["RegistrationConnectionString"].ConnectionString);
                conn.Open();
                string checkUser = "select count(*) from UserData where Username='" + TextBoxName.Value + "'  ";
                string checkDate = "select count(*) from BookAppo where Date = '" + TextBoxDate.Text + "' ";
                string checkTime = "select count(*) from BookAppo where Time = '" + TextBoxTime.Text + "' ";
                SqlCommand com = new SqlCommand(checkUser, conn);
                int temp = Convert.ToInt32(com.ExecuteScalar().ToString());

                SqlCommand com1 = new SqlCommand(checkDate, conn);
                int temp1 = Convert.ToInt32(com1.ExecuteScalar().ToString());

                SqlCommand com2 = new SqlCommand(checkTime, conn);
                int temp2 = Convert.ToInt32(com2.ExecuteScalar().ToString());

                String time = TextBoxTime.Text;
                time = time.Trim();
                int Time;
                Time = Int32.Parse(time);
                //Response.Write(Time);
                


                if ( temp == 1)
                  {
                        if ((temp1 == 0 || temp2 == 0)&& (Time >= 9 && Time <= 12) || (Time >= 1 && Time <= 5))
                        {
                            string insertQuery = "insert into BookAppo (Name,Date,Time,Purpose) values (@Name,@Date,@Time,@Purpose)";

                            SqlCommand coma = new SqlCommand(insertQuery, conn);
                            coma.Parameters.AddWithValue("@Name", TextBoxName.Value);
                            coma.Parameters.AddWithValue("@Date", TextBoxDate.Text);
                            coma.Parameters.AddWithValue("@Time", TextBoxTime.Text);
                            coma.Parameters.AddWithValue("@Purpose", TextBoxPurpose.Text.ToString());
                            //Response.Write(TextBoxPurpose.Text.ToString());
                            coma.ExecuteNonQuery();
                            Response.Write("Appointment is sucessful");
                            Response.Redirect("viewAppointment.aspx");
                        }
                        else
                        {
                            Response.Write("slot is not available,select another slot");
                        }
                  }

                else
                {
                    Response.Write("Enter the correct UserName");
                }

                conn.Close();
            }

           
            
        }

        protected void ButtonLogout_Click(object sender, EventArgs e)
        {
            Session.Abandon();
            Session.Remove("name");
            Response.Redirect("~/Login.aspx");
        }

        protected void TextBoxTime_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}