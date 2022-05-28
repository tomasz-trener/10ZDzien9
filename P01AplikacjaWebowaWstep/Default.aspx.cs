using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace P01AplikacjaWebowaWstep
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnPrzycisk_Click(object sender, EventArgs e)
        {


            Response.Write("ala ma kota");
        }
    }
}