using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace P02AplikacjaBazodanowa.ViewModels
{
    public class ZawodnikVM
    {
        public int Id { get; set; }
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public string Kraj { get; set; }
        public int? Waga { get; set; }
        public int? Wzrost {  get; set; }
        public DateTime? DataUr { get; set; }

        public string ImieNazwisko {  get { return Imie + " " + Nazwisko; } }
    }
}