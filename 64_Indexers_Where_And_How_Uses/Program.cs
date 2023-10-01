/*
 * Indexers allow instances of a class to be indexed just like arrays
 * There are two type of indexers 1) Integral & 2) String
 * We can access data stored in session using indexers  
 * We can also use indexers to take access of specific data which returned by  database
 * use "THiS" keyword to create indexer
 * Indexers have get and set properties
 * Indexers can be overLoaded
 */

using System;
using System.Xml.Linq;

class Program
{
    public static void Main()
    {


    }



    //Session["Session1"] = "Session 1 Data"; 
    //Session["Session2"] = "Session 2 Data";
    //Response.Write("Session 1 Data = " + Session[0].ToString());
    //Response.Write("<br/>");
    //Response.Write("Session 1 Data = + Session["Session2"].ToString()");

    //protected void Page_Load(object sender, EventArgs e)
    //{
    //    string CS = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString; using (SqlConnection con = new SqlConnection(CS))
    //    {
    //        SqlCommand cmd = new SqlCommand("Select * from tblEmployee", con); con.Open();
    //        SqlDataReader rdr = cmd.ExecuteReader();
    //        while (rdr.Read())
    //        {
    //        }
    //        Response.Write("Id = + rdr[0].ToString() + " "); Response.Write("Name = +rdr["Name"].ToString()); Response.Write("<br/>");
    //    }
    //}
}