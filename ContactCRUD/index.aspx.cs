using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace ContactCRUD
{
    public partial class index : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security=True");
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Add_Contact(object sender, EventArgs e)
        {
            var txt1 = txtfirstname.Text;
            var txt2 = txtlastname.Text;
            var txt3 = txtnumber.Text;
            var txt4 = txtemail.Text;

            con.Open();
            SqlCommand command = con.CreateCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "INSERT INTO contact ( firstname, lastname,number,email ) values (" +
                "'" + txt1 + "','" + txt2 + "','" + txt3 + "','" + txt4 + "')";

            command.ExecuteNonQuery();
            con.Close();
            Response.Redirect("index.aspx");
        }
    }
}