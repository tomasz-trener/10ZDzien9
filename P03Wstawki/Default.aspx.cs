using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace P03Wstawki
{
    public partial class Default : System.Web.UI.Page
    {
        public string Napis;

        protected void Page_Load(object sender, EventArgs e)
        {

            string s = "ala ma kota";
            s = s.ToUpper();

            Napis = s;

        }
    }
}