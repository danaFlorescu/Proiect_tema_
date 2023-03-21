using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema_proiect
{
    public class Franghie : ArticolInventar
    {
        public Franghie() : base(1, 1.5f) { }

        public Franghie(double greutate, double volum) : base(greutate, volum) { }
      
    }
}
