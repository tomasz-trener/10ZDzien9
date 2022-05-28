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

        public Zawodnik PodajZawodnika(int id)
        {
            ModelBazyDanychDataContext db = new ModelBazyDanychDataContext();
            return db.Zawodnik.FirstOrDefault(x=>x.id_zawodnika==id);
        }

        public void Edytuj(Zawodnik z)
        {
            ModelBazyDanychDataContext db = new ModelBazyDanychDataContext();
            Zawodnik doEdycji = db.Zawodnik.FirstOrDefault(x => x.id_zawodnika == z.id_zawodnika);

            doEdycji.imie = z.imie;
            doEdycji.nazwisko = z.nazwisko;
            doEdycji.kraj = z.kraj;
            doEdycji.waga = z.waga;
            doEdycji.wzrost = z.wzrost;
            doEdycji.data_ur = z.data_ur;

            db.SubmitChanges();
        }

        public void Dodaj(Zawodnik z)
        {
            ModelBazyDanychDataContext db = new ModelBazyDanychDataContext();
            db.Zawodnik.InsertOnSubmit(z);
            db.SubmitChanges();
        }

        public void Usun(int id)
        {
            ModelBazyDanychDataContext db = new ModelBazyDanychDataContext();
            Zawodnik z = db.Zawodnik.FirstOrDefault(x => x.id_zawodnika == id);
            db.Zawodnik.DeleteOnSubmit(z);
            db.SubmitChanges();
        }
    }
}