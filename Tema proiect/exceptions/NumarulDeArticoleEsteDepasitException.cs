using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema_proiect
{
     class NumarulDeArticoleEsteDepasitException : Exception
    {
        public NumarulDeArticoleEsteDepasitException()
            : base(String.Format("Numarul de articole a fost depasit."))
        {

        }

    }
}
