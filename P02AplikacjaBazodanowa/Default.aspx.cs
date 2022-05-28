using P02AplikacjaBazodanowa.Models;
using P02AplikacjaBazodanowa.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace P02AplikacjaBazodanowa
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnWczytaj_Click(object sender, EventArgs e)
        {
            ZawodnicyRepository zr = new ZawodnicyRepository();
            Zawodnik[] zawodnicy= zr.PodajZawodnikow();

            lbDane.DataSource = zawodnicy;
            lbDane.DataTextField = "nazwisko";
            lbDane.DataBind();
        }
    }
}