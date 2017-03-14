using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Gatepass.Account
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Session["Jobs_selected"] !=null)
            {
                List<GatepassDetails> obj = (List<GatepassDetails>)Session["Jobs_selected"];
            }
        }
    }
}
