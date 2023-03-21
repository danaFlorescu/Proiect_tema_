using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema_proiect
{
    public class Mancare : ArticolInventar
    {

        public Mancare() : base(1, 0.5f) { }

        public Mancare(double greutate, double volum) : base(greutate, volum) { }

    }
}
