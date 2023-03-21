using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema_proiect
{
    public class Apa : ArticolInventar
    {

        public Apa() : base(2, 3) { }

        public Apa(double greutate, double volum) : base(greutate, volum) { }


    }
}
