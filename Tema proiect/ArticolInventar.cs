using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema_proiect
{
    public class ArticolInventar
    {
        public double Greutate { get; private set; }
        public double Volum { get; private set; }

        public ArticolInventar(double greutate, double volum) {

            Greutate = greutate;
            Volum = volum;
        
        }
    }
}
