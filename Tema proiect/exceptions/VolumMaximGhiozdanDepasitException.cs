using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema_proiect
{
    class VolumMaximGhiozdanDepasitException : Exception
    {
        public VolumMaximGhiozdanDepasitException()
    : base(String.Format("Volumul maxim al ghiozdanului a fost depasit."))
        {

        }


    }
}
