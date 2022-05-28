using P02AplikacjaBazodanowa.Models;
using P02AplikacjaBazodanowa.Repositories;
using P02AplikacjaBazodanowa.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace P02AplikacjaBazodanowa.Operations
{
    public class TrenerzyOperation
    {
        private TrenerVM TransformujNaVM(Trener x)
        {
            return new TrenerVM()
            {
                Id = x.id_trenera,
                Imie = x.imie_t,
                Nazwisko = x.nazwisko_t,
            };
        }

        public TrenerVM[] PodajTrenerow()
        {
            return new TrenerzyRepository().PodajTrenerow().Select(x=>TransformujNaVM(x)).ToArray();
        }
    }
}