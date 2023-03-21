using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema_proiect
{
    class GreutateMaximaGhiozdanDepasitaException : Exception
    {
        public GreutateMaximaGhiozdanDepasitaException()
    : base(String.Format("Greutatea maxima a ghiozdanului a fost depasita."))
        {

        }
    }
}
