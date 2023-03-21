using System;

namespace Tema_proiect
{
    class Program
    {
        static void Main(string[] args)
        {
            ArticolInventarFactory articolFactory = new ArticolInventarFactory();

            ArticolInventar apa = articolFactory.returneazaArticol("apa", 1, 1);
            ArticolInventar mancare = articolFactory.returneazaArticol("mancare",1, 4);
            ArticolInventar arc = articolFactory.returneazaArticol("arc",1, 5);


            //nr total articole, greutate maxima, volum maxim
            Ghiozdan ghiozdan = new Ghiozdan(6, 2, 10);



            ghiozdan.Adauga(apa);
            ghiozdan.Adauga(mancare);
            ghiozdan.Adauga(arc);

        }
    }
}
