using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC
{
    class ListaComida
    {

        List<comida> comidas;

            public ListaComida()
            {
                comidas = new List<comida>();
            }
           public void Agregar(comida comida)
            {
             comidas.Add(comida);
            }
        }
    }
}
