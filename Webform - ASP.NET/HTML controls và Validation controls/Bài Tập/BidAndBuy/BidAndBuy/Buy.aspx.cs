using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BidAndBuy
{
    public partial class Buy : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void ButtonBuy_Click(object sender, EventArgs e)
        {

            TblCart.Visible = true;
        }
        protected void ButtonConfirm_Click(object sender, EventArgs e)
        {
            Response.Redirect("/Home.aspx");
        }
        protected void ButtonCancel_Click(object sender, EventArgs e)
        {
            Message.Text = "Ban da cancel Credit Cart No";
        }
    }
}