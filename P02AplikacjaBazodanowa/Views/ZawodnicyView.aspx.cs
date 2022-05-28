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
    public partial class ZawodnicyView : System.Web.UI.Page
    {
        public ZawodnikVM[] Zawodnicy;
        
        protected void Page_Load(object sender, EventArgs e)
        {
            ZawodnicyOperation zo = new ZawodnicyOperation();
            Zawodnicy= zo.PodajZawodnikow();

            if (!string.IsNullOrEmpty(Request["id"]))
            {
                int IdZaznaczonego = Convert.ToInt32(Request["id"]);
                Zawodnicy.FirstOrDefault(x => x.Id == IdZaznaczonego).Zaznaczony = true;
            }

            if (!string.IsNullOrEmpty(Request["idTrenera"]))
            {
                int idTrenera = Convert.ToInt32(Request["idTrenera"]);
            }
              
        }
    }
}