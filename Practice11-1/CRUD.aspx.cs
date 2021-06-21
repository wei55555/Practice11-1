using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace Practice11_1
{
    public partial class CRUD : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = test; Integrated Security = True; Connect Timeout = 30; Encrypt = False; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False
            string s = "";
            s = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=test;" +
                "Integrated Security=True;Connect Timeout=30;Encrypt=False;" +
                "TrustServerCertificate=False;ApplicationIntent=ReadWrite;" +
                "MultiSubnetFailover=False;" +
                "User ID=sa;Password=123456";
            SqlConnection o_connect = new SqlConnection(s);
            try
            {
                SqlCommand o_com = new SqlCommand("update Users set Birthday='2021/5/18' where Name=N'狗狗旭'", o_connect);
                o_connect.Open();
                o_com.ExecuteNonQuery();
                o_connect.Close();
            }
            catch (Exception error)
            {
                Response.Write(error.ToString());
            }


        }
    }
}