using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services.Description;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace Biblioteka1_MySQL_
{
    public partial class MainPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblUser.Text = "Logged in as: " + Session["login"].ToString()+"; ";
            lblID.Text = "User ID: " + Session["userID"].ToString();
            if (!IsPostBack)
            {
                // Znajdujemy w ListView nagłówek tabeli
                HtmlTableRow headerRow = (HtmlTableRow)list1.FindControl("headerRow");

                if (headerRow != null)
                {
                    // Tworzenie dynamicznych nagłówków kolumn
                    HtmlTableCell cell1 = new HtmlTableCell { InnerText = "Title" };
                    HtmlTableCell cell2 = new HtmlTableCell { InnerText = "Author" };
                    HtmlTableCell cell3 = new HtmlTableCell { InnerText = "Year" }; // Nowa kolumna
                    HtmlTableCell cell4 = new HtmlTableCell { InnerText = "Publisher" };

                    // Dodanie kolumn do wiersza nagłówkowego
                    headerRow.Cells.Add(cell1);
                    headerRow.Cells.Add(cell2);
                    headerRow.Cells.Add(cell3);
                    headerRow.Cells.Add(cell4);
                }
                
                }

        }
        public class Book
        {
            public string Author { get; set; }
            public string Title { get; set; }
            public int Year { get; set; }
            public string Publisher { get; set; }
        }

        protected void btnLogout_Click(object sender, EventArgs e)
        {
            Session["login"] = null;
            Response.Redirect("Login-Register.aspx");
        }
        protected void btnAddBook_Click(object sender, EventArgs e)
        {
            Session["userID"] = Session["userID"];
            Response.Redirect("AddBook.aspx");
            
        }
    }
}