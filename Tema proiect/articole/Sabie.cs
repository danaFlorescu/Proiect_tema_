using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema_proiect
{
    public class Sabie : ArticolInventar
    {

        public Sabie() : base(5, 3) { }

        public Sabie(double greutate, double volum) : base(greutate, volum) { }

    }
}
