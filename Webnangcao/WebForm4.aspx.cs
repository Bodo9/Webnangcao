using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Webnangcao
{
    public partial class WebForm4 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_dn_Click(object sender, EventArgs e)
        {
            try
            {
                STUSO_DBEntities _db = new STUSO_DBEntities();
                User a = new User();
                a.UserID = tk_btn.Text;
                a.matkhau = mk_btn.Text;
                if (a.matkhau.ToString() == remk_btn.Text.ToString())
                {
                    _db.Users.Add(a);
                    int res = _db.SaveChanges();
                    if (res > 0)
                    {

                        Response.Redirect("WebForm2.aspx");

                    }
                    else
                    {

                        Response.Write("Try Again!!!");

                    }
                }
                else
                {
                    Response.Write("Mật Khẩu Không Khớp. Vui Lòng Thử Lại");
                }
            }
            catch
            {
                Response.Write("Loi");
            }
        }
    }
}