using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;

namespace Biblioteka1_MySQL_
{
    public partial class AddBook : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblID.Text = "User ID: " + Session["userID"].ToString();
        }
        protected void btnAdd_Click(object sender, EventArgs e)
        {
            if (tbTitle.Text == "" || tbAuthor.Text == "" || tbYear.Text == "" || tbPublisher.Text == "")
            {
                lblMessage.Text = "All fields must be filled!";
            }
            else
            {
                MySqlConnection conn = new MySqlConnection("server=localhost;user id=root;password=;database=library");
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("CREATE TABLE IF NOT EXISTS Books (Id_user INT,title VARCHAR(100) NOT NULL, author VARCHAR(100) NOT NULL, year INT, publisher VARCHAR(30))", conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                reader.Close();
                int id_user = Convert.ToInt32(Session["userID"]);
                cmd = new MySqlCommand("INSERT INTO Books (Id_user, title, author, year, publisher) VALUES (" + id_user.ToString() + ",\"" + tbTitle.Text + "\", " + "\"" + tbAuthor.Text + "\", " + "\"" + tbYear.Text + "\", " + "\"" + tbPublisher.Text + "\")", conn);
                cmd.ExecuteNonQuery();
                lblMessage.Text = "Book added successfully!";
                conn.Close();
            }
        }
        protected void btnCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("MainPage.aspx");
        }
    }
}