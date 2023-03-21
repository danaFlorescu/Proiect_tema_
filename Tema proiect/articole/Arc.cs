using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema_proiect
{
    public class Arc : ArticolInventar
    {
        public Arc() : base(1, 4) { }

        public Arc(double greutate, double volum) : base(greutate, volum) { }

    }
}
