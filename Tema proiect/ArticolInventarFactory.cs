using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema_proiect
{
    public class ArticolInventarFactory
    {

        public ArticolInventar returneazaArticol(String nume, double greutate, double volum) {

            switch(nume)
            {
                case "franghie":
                    return new Franghie(greutate, volum); 
                    break;
                case "sageata":
                    return new Sageata(greutate, volum);
                    break;
                case "arc":
                    return new Arc(greutate, volum);
                    break;
                case "sabie":
                    return new Sabie(greutate, volum);
                    break;
                case "mancare":
                    return new Mancare(greutate, volum);
                    break;
                case "apa":
                    return new Apa(greutate, volum);
                    break;
                default:
                    return new ArticolInventar(greutate, volum);
                    break;

            }
        }
    }
}
