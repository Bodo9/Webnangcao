using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Webnangcao
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_dn_Click(object sender, EventArgs e)
        {
               STUSO_DBEntities _db = new STUSO_DBEntities();
            if(_db.Users.Where(b => b.UserID.Equals(tk_btn.Text)).ToList().Count() >0 )
            {
                if (_db.Users.Where(b => b.matkhau.Equals(mk_btn.Text)).ToList().Count() > 0)
                {
                    Response.Write("Thanh cong");
                    Response.Redirect("WebForm3.aspx");
                }
                else
                {
                    Response.Write("Sai mat khau");
                }
            }
            else
            {
                Response.Write("Tai khoan khong ton tai");
            }
        }
    }
}