using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema_proiect
{
    class Ghiozdan 
    {

         private readonly int numarTotalArticole;
         private readonly double greutateMax;
         private readonly double volumMax;

         private int numarArticoleAdaugate = 0;
         private double greutateArticoleAdaugate = 0;
         private double volumArticoleAdaugate = 0;

        private List<ArticolInventar> articoleGhiozdan = new List<ArticolInventar>();

        public Ghiozdan(int numarTotalArticole, double greutateMax, double volumMax) {

            this.numarTotalArticole = numarTotalArticole;
            this.greutateMax = greutateMax;
            this.volumMax = volumMax;
        }



        private void valideazaArticol(ArticolInventar articol)
        {

            if (this.numarArticoleAdaugate + 1 > this.numarTotalArticole)
            {

                throw new NumarulDeArticoleEsteDepasitException();
            }

            if (this.greutateArticoleAdaugate + articol.Greutate > this.greutateMax)
            {

                throw new GreutateMaximaGhiozdanDepasitaException();

            }

            if (this.volumArticoleAdaugate + articol.Volum > this.volumMax)
            {

                throw new VolumMaximGhiozdanDepasitException();

            }


        }

        public bool Adauga(ArticolInventar articol) {

            try {

                valideazaArticol(articol);

                articoleGhiozdan.Add(articol);

                numarArticoleAdaugate++;
                greutateArticoleAdaugate += articol.Greutate;
                volumArticoleAdaugate += articol.Volum;

                Console.WriteLine("Articolul a fost adaugat cu succes in ghiozdan.");

            }
            catch (Exception ex) {

                Console.WriteLine(ex.Message);

                return false;
            }


           
            return true;

        }
    }
}
