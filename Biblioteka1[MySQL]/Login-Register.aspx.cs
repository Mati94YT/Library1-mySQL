using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace Biblioteka1_MySQL_
{
    public partial class Login_Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnLogin_Click(object sender, EventArgs e)
        {
            if(tbLogin.Text == "" || tbPassword.Text == "")
            {
                lblMessage.Text = "Login and password fields must be filled!";
            }
            else
            {
                MySqlConnection conn = new MySqlConnection("server=localhost;user id=root;password=;database=library");
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("CREATE TABLE IF NOT EXISTS Users (Id_user INT AUTO_INCREMENT PRIMARY KEY,Login VARCHAR(30) NOT NULL, Password VARCHAR(30) NOT NULL)", conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                reader.Close();
                cmd = new MySqlCommand("SELECT COUNT(Users.login) FROM Users WHERE Users.login = " + "\"" + tbLogin.Text + "\" AND Users.password = " + "\"" + tbPassword.Text + "\"", conn);
                reader = cmd.ExecuteReader();
                reader.Read();
                if (reader.GetInt32(0) > 0)
                {
                    reader.Close();
                    cmd = new MySqlCommand("SELECT Users.Id_user FROM Users WHERE Users.login = " + "\"" + tbLogin.Text + "\"", conn);
                    reader = cmd.ExecuteReader();
                    reader.Read();
                    Session["login"] = tbLogin.Text;
                    Session["userID"] = reader.GetInt32(0);
                    Response.Redirect("MainPage.aspx");
                }
                else
                {
                    lblMessage.Text = "Invalid login or password!";
                }

            }
            
        }
        protected void btnRegister_Click(object sender, EventArgs e)
        {
            if (tbLogin.Text == "" || tbPassword.Text == "")
            {
                lblMessage.Text = "Login and password fields must be filled!";
            }
            else
            {
                MySqlConnection conn = new MySqlConnection("server=localhost;user id=root;password=;database=library");
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("CREATE TABLE IF NOT EXISTS Users (Id_user INT AUTO_INCREMENT PRIMARY KEY,Login VARCHAR(30) NOT NULL, Password VARCHAR(30) NOT NULL)", conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                reader.Close();
                cmd = new MySqlCommand("SELECT COUNT(Users.login) FROM Users WHERE Users.login = " + "\""+tbLogin.Text+"\"", conn);
                reader = cmd.ExecuteReader();
                reader.Read();
                if (reader.GetInt32(0) > 0)
                {
                    lblMessage.Text = "User with this login already exists!";
                }
                else
                {
                    reader.Close();
                    cmd = new MySqlCommand("SELECT COUNT(*) FROM users", conn);
                    reader = cmd.ExecuteReader();
                    reader.Read();
                    int userCount = reader.GetInt32(0);
                    userCount++;
                    reader.Close();
                    cmd = new MySqlCommand("INSERT INTO users (Id_user, Login, Password) VALUES (" + userCount.ToString() + ", \"" + tbLogin.Text + "\", \"" + tbPassword.Text + "\")", conn);
                    reader = cmd.ExecuteReader();
                    if (reader.RecordsAffected > 0)
                    {
                        lblMessage.Text = "User registered successfully! You can log in now";
                    }
                    else
                    {
                        lblMessage.Text = "Error registering user!";
                    }
                    reader.Close();
                }
            }
        }
    }
}