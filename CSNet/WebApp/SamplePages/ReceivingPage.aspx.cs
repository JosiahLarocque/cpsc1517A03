using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApp.SamplePages
{
    public partial class ReceivingPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                string pid = Request.QueryString["pid"];
                if (string.IsNullOrEmpty(pid))
                {
                    Response.Redirect("SqlQuery.aspx");
                }
                else
                {
                    MessageLabel.Text = "You passed the following data to this page: >" + pid + "<";
                }
            }
        }
    }
}