using demomvc.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;


namespace demomvc.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
       [HttpGet]
        //public ActionResult Index()
        //{
        //    //ViewData["Result"] = "0";
        //    //ViewBag.Message = "Ashish Tongalkar";
        //    return View(); 

        //}
        public ActionResult Home()
        {

            return View();


        }
        public ActionResult About()
        {

            return View();


        }
        public ActionResult Contact()
        {


            //String Name = ddlCountry.SelectedItem.Text;
            //String StudentName = txtStudentName.Text.Trim();
            //String CollegeName = txtCollegeName.Text.Trim();
            //String Mobile = txtMobile.Text.Trim();
            //String Email = TxtEmail.Text.Trim();
            //String City = TxtCity.Text.Trim();
            //String Gender = "";
            //if (rdbMale.Checked == true) { Gender = "Male"; }
            //else { Gender = "Female"; }

            //String ConnectionString = "Data Source=DESKTOP-SGMFTSP;Initial Catalog=ashish;Integrated Security=True";
            //SqlConnection conn = new SqlConnection(ConnectionString);
            //conn.Open();
            //String myquery = "insert into tblStudent(StudentName,CollegeName,Mobile,Email,City,Gender,Country,Photo) values(@StudentName,@CollegeName,@Mobile,@Email,@City,@Gender,@Country,@Photo)";

            //SqlCommand cmd = new SqlCommand(myquery, conn);

            //cmd.Parameters.AddWithValue("@StudentName", StudentName);
            //cmd.Parameters.AddWithValue("@CollegeName", CollegeName);
            //cmd.Parameters.AddWithValue("@Mobile", Mobile);
            //cmd.Parameters.AddWithValue("@Email", Email);
            //cmd.Parameters.AddWithValue("@City", City);
            //cmd.Parameters.AddWithValue("@Gender", Gender);
            //cmd.Parameters.AddWithValue("@Country", Country);
            //cmd.Parameters.AddWithValue("@Photo", Photo);


            //int res = cmd.ExecuteNonQuery();
            //conn.Close();
            //if (res > 0)
            //{
            //    lblMsg.Text = "Success....Record Inserted Successfully..";
            //    lblMsg.ForeColor = System.Drawing.Color.Green;

            //}
            //else
            //{
            //    lblMsg.Text = "Faild....Oops gone wrong....!!";
            //    lblMsg.ForeColor = System.Drawing.Color.Red;
            //}


            //txtStudentName.Text = "";
            //txtCollegeName.Text = "";
            //txtMobile.Text = "";
            //TxtEmail.Text = "";
            //TxtCity.Text = "";


            return View();


        }
        [HttpPost]
        public ActionResult Contact(ContactModel cm)
        {

            string conn = "Data Source=DESKTOP-SGMFTSP;Initial Catalog=ashish;Integrated Security=True";

            SqlConnection sqlConn = new SqlConnection(conn);
            string sqlquery = "insert into tblContact(Name,Mail,Subject,Message)values(@Name,@Mail,@Subject,@Message)";

            SqlCommand cmd = new SqlCommand(sqlquery, sqlConn);
            sqlConn.Open();
            cmd.Parameters.AddWithValue("@Name", cm.Name);
            cmd.Parameters.AddWithValue("@Mail", cm.Mail);
            cmd.Parameters.AddWithValue("@Subject", cm.Subject);
            cmd.Parameters.AddWithValue("@Message", cm.Message);
            cmd.ExecuteNonQuery();
            sqlConn.Close();
            ViewData["Message"] =" Message of "+" " + cm.Name +" "+ " Saved Successfully";
            ModelState.Clear();



            return View();
        }




        //public ActionResult Index(decimal firstnumber, decimal secondnumber)
        //{
        //    decimal Result = firstnumber + secondnumber;

        //    ViewData["Result"] = Result;

        //    return View();
        //}



    }
}