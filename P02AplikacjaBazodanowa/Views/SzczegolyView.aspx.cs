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
        public enum TrybPracy
        {
            Dodawanie,
            Edycja
        }

        public TrybPracy TrybPracyOkienka;
        public TrenerVM[] Trenerzy;
        protected void Page_Load(object sender, EventArgs e)
        {
            TrybPracyOkienka = string.IsNullOrEmpty(Request["id"]) ? TrybPracy.Dodawanie : TrybPracy.Edycja;

            if (!Page.IsPostBack )
            {
                if (TrybPracyOkienka == TrybPracy.Edycja)
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

                    btnUsun.Visible = true;

                    if (!string.IsNullOrEmpty(zawodnik.ImieNazwiskoTrenera))
                        lblTrener.Text = zawodnik.ImieNazwiskoTrenera;
                }

                TrenerzyOperation to = new TrenerzyOperation();
                Trenerzy=to.PodajTrenerow();
               
            }
        }

           

        protected void btnZapisz_Click(object sender, EventArgs e)
        {
        
            ZawodnikVM zawodnik = new ZawodnikVM();
            
            if(TrybPracyOkienka== TrybPracy.Edycja)
            {
                int id = Convert.ToInt32(Request["id"]);
                zawodnik.Id = id;
            }
        
            Zczytaj(zawodnik);

            ZawodnicyOperation zo = new ZawodnicyOperation();

            int idZaznacznego = zawodnik.Id;
           
            if (TrybPracyOkienka == TrybPracy.Edycja)
                zo.Edytuj(zawodnik);
            else if (TrybPracyOkienka == TrybPracy.Dodawanie)
                idZaznacznego = zo.Dodaj(zawodnik);  
            else
                throw new Exception("Nieobługiwany tryb pracy");


            Response.Redirect($"ZawodnicyView.aspx?id={idZaznacznego}");
        }


        private void Zczytaj(ZawodnikVM z)
        {
            z.Imie = txtImie.Text;
            z.Nazwisko = txtNazwisko.Text;
            z.Kraj = txtKraj.Text;
            if(!string.IsNullOrWhiteSpace(txtDataUrodzenia.Text))
                z.DataUr = Convert.ToDateTime(txtDataUrodzenia.Text);
            if (!string.IsNullOrWhiteSpace(txtWaga.Text))
                z.Waga = Convert.ToInt32(txtWaga.Text);
            if (!string.IsNullOrWhiteSpace(txtWzrost.Text))
                z.Wzrost = Convert.ToInt32(txtWzrost.Text);
        }

        protected void btnUsun_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(Request["id"]);

            ZawodnicyOperation zo = new ZawodnicyOperation();
            zo.Usun(id);
            Response.Redirect("ZawodnicyView.aspx");
        }
    }
}