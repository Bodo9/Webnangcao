using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Webnangcao
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            STUSO_DBEntities _db = new STUSO_DBEntities();
            GridView1.DataSource = _db.questions.ToList();
            GridView1.DataBind();
        }
        protected void Button1_Click1(object sender, EventArgs e)
        {
            try
            {
                STUSO_DBEntities _db = new STUSO_DBEntities();
                question a = new question();
                a.questionID = TextBox1.Text;
                a.content = TextBox2.Text;
                _db.questions.Add(a);
                int res = _db.SaveChanges();
                if (res > 0)
                {

                    Response.Write("Data Inserted Successfully");

                }
                else
                {

                    Response.Write("Try Again!!!");

                }
                GridView1.DataSource = _db.questions.ToList();
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
                var a = new question();
                a.questionID = TextBox3.Text;
                _db.questions.Attach(a);
                _db.questions.Remove(a);
                _db.SaveChanges();
                GridView1.DataSource = _db.questions.ToList();
                GridView1.DataBind();
            }
            catch
            {
                Response.Write("Loi");
            }
        }
    }
}
