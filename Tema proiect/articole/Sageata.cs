using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema_proiect
{
    public class Sageata : ArticolInventar
    {
        public Sageata() : base(0.1f, 0.05f) { }

        public Sageata(double greutate, double volum) : base(greutate, volum) { }
    }
}
