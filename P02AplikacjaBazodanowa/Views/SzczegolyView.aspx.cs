using P02AplikacjaBazodanowa.Operations;
using P02AplikacjaBazodanowa.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace P02AplikacjaBazodanowa.Views
{
    public partial class SzczegolyView : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                int id = Convert.ToInt32(Request["id"]);

                ZawodnicyOperation zo = new ZawodnicyOperation();
                ZawodnikVM zawodnik = zo.PodajZawodnika(id);

                txtImie.Text = zawodnik.Imie;
                txtNazwisko.Text = zawodnik.Nazwisko;
                txtKraj.Text = zawodnik.Kraj;
                txtDataUrodzenia.Text = zawodnik.DataUr?.ToString("yyyy-MM-dd");
                txtWzrost.Text = zawodnik.Wzrost?.ToString();
                txtWaga.Text = zawodnik.Waga?.ToString();
            }
        }

           

        protected void btnZapisz_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(Request["id"]);

            ZawodnikVM zawodnik = new ZawodnikVM();
            zawodnik.Id = id;
            Zczytaj(zawodnik);

            ZawodnicyOperation zo = new ZawodnicyOperation();
            zo.Edytuj(zawodnik);

            Response.Redirect("ZawodnicyView.aspx");

        }


        private void Zczytaj(ZawodnikVM z)
        {
            z.Imie = txtImie.Text;
            z.Nazwisko = txtNazwisko.Text;
            z.Kraj = txtKraj.Text;
            z.DataUr = Convert.ToDateTime(txtDataUrodzenia.Text);
            z.Waga = Convert.ToInt32(txtWaga.Text);
            z.Wzrost = Convert.ToInt32(txtWzrost.Text);
        }
    }
}