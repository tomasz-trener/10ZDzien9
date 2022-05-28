using P02AplikacjaBazodanowa.Models;
using P02AplikacjaBazodanowa.Operations;
using P02AplikacjaBazodanowa.Repositories;
using P02AplikacjaBazodanowa.ViewModels;
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

        private void Odswiez()
        {
            // wersja gdy bindowaliśmy zawodnikow bezposrednio z bazy do kontrolki
            //ZawodnicyRepository zr = new ZawodnicyRepository();
            //Zawodnik[] zawodnicy= zr.PodajZawodnikow();

            //lbDane.DataSource = zawodnicy;
            //lbDane.DataTextField = "nazwisko";
            //lbDane.DataBind();

            // teraz laczymy kontrolkę z ZawodnikVM, który jest obiektem "lekkim", niepowiazanym z baza danych 

            ZawodnicyOperation zo = new ZawodnicyOperation();
            ZawodnikVM[] zawodnicy = zo.PodajZawodnikow();
            lbDane.DataSource = zawodnicy;
            lbDane.DataTextField = "ImieNazwisko";
            lbDane.DataValueField = "Id";
            lbDane.DataBind();
        }

        protected void btnWczytaj_Click(object sender, EventArgs e)
        {
            Odswiez();
        }

        protected void lbDane_SelectedIndexChanged(object sender, EventArgs e)
        {
            string id = lbDane.SelectedValue;
            //    Response.Write(imieNazwisko);

            ZawodnicyOperation zo = new ZawodnicyOperation();
            ZawodnikVM zawodnik= zo.PodajZawodnika(Convert.ToInt32(id));

            txtImie.Text = zawodnik.Imie;
            txtNazwisko.Text = zawodnik.Nazwisko;
            txtKraj.Text = zawodnik.Kraj;
            txtDataUrodzenia.Text = zawodnik.DataUr?.ToString("yyyy-MM-dd");
            txtWaga.Text = zawodnik.Waga?.ToString();
            txtWzrost.Text = zawodnik.Wzrost?.ToString();


        }

        protected void btnZapisz_Click(object sender, EventArgs e)
        {
            string id = lbDane.SelectedValue;

            ZawodnikVM z = new ZawodnikVM();
            z.Id = Convert.ToInt32(id);
            Zczytaj(z);

            ZawodnicyOperation zo = new ZawodnicyOperation();
            zo.Edytuj(z);
            Odswiez();
        }

        protected void btnDodaj_Click(object sender, EventArgs e)
        {
            ZawodnikVM z = new ZawodnikVM();
            Zczytaj(z);
            ZawodnicyOperation zo = new ZawodnicyOperation();
            zo.Dodaj(z);
            Odswiez();
        }

        protected void btnUsun_Click(object sender, EventArgs e)
        {
            string id = lbDane.SelectedValue;
            ZawodnicyOperation zo = new ZawodnicyOperation();
            zo.Usun(Convert.ToInt32(id));
            Odswiez();
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

        //http://tomaszles.pl/2019/03/17/szablon-dashboard/
    }
}