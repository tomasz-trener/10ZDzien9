using P02AplikacjaBazodanowa.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace P02AplikacjaBazodanowa.Repositories
{
    public class ZawodnicyRepository
    {
        public Zawodnik[] PodajZawodnikow()
        {
            ModelBazyDanychDataContext db = new ModelBazyDanychDataContext();
            return db.Zawodnik.ToArray();
        }
    }
}