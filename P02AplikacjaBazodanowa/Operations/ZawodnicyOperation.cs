using P02AplikacjaBazodanowa.Models;
using P02AplikacjaBazodanowa.Repositories;
using P02AplikacjaBazodanowa.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace P02AplikacjaBazodanowa.Operations
{
    public class ZawodnicyOperation
    {

        private ZawodnikVM TransformujNaVM(Zawodnik x)
        {
            return new ZawodnikVM()
            {
                Id = x.id_zawodnika,
                Imie = x.imie,
                Nazwisko = x.nazwisko,
                DataUr = x.data_ur,
                Kraj = x.kraj,
                Waga = x.waga,
                Wzrost = x.wzrost
            };
        }

        private Zawodnik TransformujNaDB(ZawodnikVM x)
        {
            return new Zawodnik()
            {
                id_zawodnika = x.Id,
                imie = x.Imie,
                nazwisko = x.Nazwisko,
                data_ur = x.DataUr,
                kraj = x.Kraj,
                waga = x.Waga,
                wzrost = x.Wzrost
            };
        }

        public ZawodnikVM[] PodajZawodnikow()
        {
            ZawodnicyRepository zr = new ZawodnicyRepository();
            return zr.PodajZawodnikow().Select(x => TransformujNaVM(x)).ToArray();
        }

        public ZawodnikVM PodajZawodnika(int id)
        {
            ZawodnicyRepository zr = new ZawodnicyRepository();
            return TransformujNaVM(zr.PodajZawodnika(id));
        }


        public void Edytuj(ZawodnikVM z)
        {
            ZawodnicyRepository zr = new ZawodnicyRepository();
            zr.Edytuj(TransformujNaDB(z));
        }

        public void Dodaj(ZawodnikVM z)
        {
            ZawodnicyRepository zr = new ZawodnicyRepository();
            zr.Dodaj(TransformujNaDB(z));
        }

        public void Usun(int id)
        {
            ZawodnicyRepository zr = new ZawodnicyRepository();
            zr.Usun(id);
        }
    }
}