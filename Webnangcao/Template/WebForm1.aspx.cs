using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.WebSockets;
using Webnangcao.Template;

namespace Webnangcao
{
    public partial class WebForm1 : System.Web.UI.Page
    {   
        protected void Page_Load(object sender, EventArgs e)
        {
            STUSO_DBEntities _db = new STUSO_DBEntities();
            GridView1.DataSource = _db.Users.ToList();
            GridView1.DataBind();
 
        }

        protected void Button1_Click1(object sender, EventArgs e)
        {
            try
            {
                STUSO_DBEntities _db = new STUSO_DBEntities();
                User a = new User();
                a.UserID = TextBox1.Text;
                a.matkhau = TextBox2.Text;
                _db.Users.Add(a);
                int res = _db.SaveChanges();
                if (res > 0)
                {

                    Response.Write("Data Inserted Successfully");

                }
                else
                {

                    Response.Write("Try Again!!!");

                }
                GridView1.DataSource = _db.Users.ToList();
                GridView1.DataBind();
            }
            catch
            {
                Response.Write("Loi");
            }
        }

        protected void Button1_Click2(object sender, EventArgs e)
        {
            try
            {
                STUSO_DBEntities _db = new STUSO_DBEntities();
                var a = new User();
                a.UserID = TextBox3.Text;
                _db.Users.Attach(a);
                _db.Users.Remove(a);
                _db.SaveChanges();
                GridView1.DataSource = _db.Users.ToList();
                GridView1.DataBind();
            }
            catch
            {
                Response.Write("Loi");
            }
        }
    }
}