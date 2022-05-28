using P02AplikacjaBazodanowa.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace P02AplikacjaBazodanowa.Repositories
{
    public class TrenerzyRepository
    {
        public Trener[] PodajTrenerow()
        {
           return new ModelBazyDanychDataContext().Trener.ToArray();
        }
    }
}